using System;
using System.Drawing;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        private readonly decimal[] exchangeRates = { 1.0m, 0.24m, 0.22m, 0.19m, 34.78m, 722.06m }; // PLN, USD, EUR, GBP, JPY, DT
        private readonly string[] currencyNames = { "PLN", "USD", "EUR", "GBP", "JPY", "DT" }; // Nazwy walut

        private RadioButton[] sourceCurrencyButtons;
        private RadioButton[] targetCurrencyButtons;

        private Label lblSourceCurrency;
        private Label lblTargetCurrency;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            this.Text = "Kalkulator walut";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Label "Waluta źródłowa"
            var lblSourceValue = new Label
            {
                Text = "Waluta źródłowa",
                Location = new Point(50, 30),
                AutoSize = true
            };
            this.Controls.Add(lblSourceValue);

            // TextBox dla kwoty źródłowej
            var txtSourceValue = new TextBox
            {
                Name = "txtSourceValue",
                Location = new Point(150, 25),
                Width = 150
            };
            txtSourceValue.TextChanged += TxtSourceValue_TextChanged;
            this.Controls.Add(txtSourceValue);

            // Label dla wybranej waluty źródłowej
            lblSourceCurrency = new Label
            {
                Text = "PLN",
                Location = new Point(310, 30),
                AutoSize = true
            };
            this.Controls.Add(lblSourceCurrency);

            // Label "Waluta docelowa"
            var lblTargetValue = new Label
            {
                Text = "Waluta docelowa",
                Location = new Point(50, 70),
                AutoSize = true
            };
            this.Controls.Add(lblTargetValue);

            // TextBox dla kwoty docelowej
            var txtTargetValue = new TextBox
            {
                Name = "txtTargetValue",
                Location = new Point(150, 65),
                Width = 150,
                ReadOnly = true
            };
            this.Controls.Add(txtTargetValue);

            // Label dla wybranej waluty docelowej
            lblTargetCurrency = new Label
            {
                Text = "USD",
                Location = new Point(310, 70),
                AutoSize = true
            };
            this.Controls.Add(lblTargetCurrency);

            // Grupa "Waluta źródłowa"
            var grpSource = new GroupBox
            {
                Text = "Waluta źródłowa",
                Location = new Point(50, 100),
                Size = new Size(150, 200)
            };
            this.Controls.Add(grpSource);

            sourceCurrencyButtons = new RadioButton[currencyNames.Length];
            for (int i = 0; i < currencyNames.Length; i++)
            {
                var rb = new RadioButton
                {
                    Text = currencyNames[i],
                    Location = new Point(10, 20 + i * 30),
                    AutoSize = true
                };
                rb.CheckedChanged += SourceCurrencyChanged;
                sourceCurrencyButtons[i] = rb;
                grpSource.Controls.Add(rb);
            }
            sourceCurrencyButtons[0].Checked = true;

            // Grupa "Waluta docelowa"
            var grpTarget = new GroupBox
            {
                Text = "Waluta docelowa",
                Location = new Point(220, 100),
                Size = new Size(150, 200)
            };
            this.Controls.Add(grpTarget);

            targetCurrencyButtons = new RadioButton[currencyNames.Length];
            for (int i = 0; i < currencyNames.Length; i++)
            {
                var rb = new RadioButton
                {
                    Text = currencyNames[i],
                    Location = new Point(10, 20 + i * 30),
                    AutoSize = true
                };
                rb.CheckedChanged += TargetCurrencyChanged;
                targetCurrencyButtons[i] = rb;
                grpTarget.Controls.Add(rb);
            }
            targetCurrencyButtons[1].Checked = true;

            // Pasek przewijania
            var hScrollBar = new HScrollBar
            {
                Name = "hScrollBar",
                Minimum = 0,
                Maximum = 10000,
                Location = new Point(50, 320),
                Width = 400
            };
            hScrollBar.ValueChanged += HScrollBar_ValueChanged;
            this.Controls.Add(hScrollBar);
        }

        private void SourceCurrencyChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                lblSourceCurrency.Text = rb.Text; // Aktualizacja etykiety źródłowej waluty
                ConvertCurrency();
            }
        }

        private void TargetCurrencyChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                lblTargetCurrency.Text = rb.Text; // Aktualizacja etykiety docelowej waluty
                ConvertCurrency();
            }
        }

        private void TxtSourceValue_TextChanged(object sender, EventArgs e)
        {
            var txtSourceValue = sender as TextBox;
            var hScrollBar = this.Controls["hScrollBar"] as HScrollBar;

            if (decimal.TryParse(txtSourceValue.Text, out decimal value) && hScrollBar != null)
            {
                hScrollBar.Value = Math.Min(hScrollBar.Maximum, (int)value);
                ConvertCurrency();
            }
            else if (!string.IsNullOrEmpty(txtSourceValue.Text))
            {
                MessageBox.Show("Wprowadź poprawną liczbę.", "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HScrollBar_ValueChanged(object sender, EventArgs e)
        {
            var hScrollBar = sender as HScrollBar;
            var txtSourceValue = this.Controls["txtSourceValue"] as TextBox;
            if (txtSourceValue != null)
            {
                txtSourceValue.Text = hScrollBar.Value.ToString();
            }
        }

        private void ConvertCurrency()
        {
            var txtSourceValue = this.Controls["txtSourceValue"] as TextBox;
            var txtTargetValue = this.Controls["txtTargetValue"] as TextBox;

            if (txtSourceValue != null && txtTargetValue != null &&
                decimal.TryParse(txtSourceValue.Text, out decimal sourceValue))
            {
                int sourceIndex = Array.FindIndex(sourceCurrencyButtons, rb => rb.Checked);
                int targetIndex = Array.FindIndex(targetCurrencyButtons, rb => rb.Checked);

                if (sourceIndex != -1 && targetIndex != -1)
                {
                    decimal targetValue = sourceValue * (exchangeRates[targetIndex] / exchangeRates[sourceIndex]);
                    txtTargetValue.Text = targetValue.ToString("F2");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
