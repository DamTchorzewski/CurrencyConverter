using System;
using System.Linq;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        private readonly decimal[] exchangeRates = { 1.0m, 0.24m, 0.22m, 0.19m, 34.78m, 722.06m };
        private readonly string[] currencyNames = { "PLN", "USD", "EUR", "GBP", "JPY", "DT" };

        public Form1()
        {
            InitializeComponent();
            InitializeCustomLogic();
        }

        private void InitializeCustomLogic()
        {
            textBox1.TextChanged += TextBox1_TextChanged;
            textBox1.KeyPress += TextBox1_KeyPress; // Dodanie obsługi walidacji znaków
            hScrollBar1.ValueChanged += HScrollBar1_ValueChanged;

            foreach (var radioButton in groupBox1.Controls.OfType<RadioButton>())
            {
                radioButton.CheckedChanged += SourceCurrencyChanged;
            }

            foreach (var radioButton in groupBox2.Controls.OfType<RadioButton>())
            {
                radioButton.CheckedChanged += TargetCurrencyChanged;
            }

            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = 100000;

            radioButton1.Checked = true; // Default source: PLN
            radioButton11.Checked = true; // Default target: USD
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal value))
            {
                hScrollBar1.Value = Math.Min(hScrollBar1.Maximum, (int)value);
                ConvertCurrency();
            }
            else if (!string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Wprowadź poprawną liczbę.", "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Akceptuj tylko cyfry, przecinek oraz klawisze sterujące (np. Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Ignoruj niepoprawne znaki
            }
        }

        private void HScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
        }

        private void SourceCurrencyChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                label3.Text = rb.Text;
                ConvertCurrency();
            }
        }

        private void TargetCurrencyChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                label4.Text = rb.Text;
                ConvertCurrency();
            }
        }

        private void ConvertCurrency()
        {
            if (decimal.TryParse(textBox1.Text, out decimal sourceValue))
            {
                int sourceIndex = Array.IndexOf(currencyNames, label3.Text);
                int targetIndex = Array.IndexOf(currencyNames, label4.Text);

                if (sourceIndex != -1 && targetIndex != -1)
                {
                    decimal targetValue = sourceValue * (exchangeRates[targetIndex] / exchangeRates[sourceIndex]);
                    textBox2.Text = targetValue.ToString("F2");

                }
                else
                {
                    textBox2.Text = "Błąd walut";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
