- [Czytaj po Polsku](README.pl.md)

# Currency Calculator

**Currency Calculator** is a Windows Forms application developed in the Visual Studio .NET Framework environment. It is used for converting currency values based on predefined exchange rates, providing an intuitive user interface and additional functionalities that meet the project requirements.

---

## Application Features

1. **Entering Currency Values:**

   - Users can enter the amount of the source currency in the first text field (textBox1).

2. **Control via Scrollbar:**

   - A horizontal scrollbar (hScrollBar) allows users to set the value of the source currency.

3. **Currency Conversion:**

   - The application converts the source currency value to the target currency using predefined exchange rates.
   - Users can select the source and target currencies using radio buttons (RadioButton).

4. **Custom Currency:**

   - As required by the project, a custom currency named "DT" (derived from the author's initials) is included, with an exchange rate of 722.06 (based on the author's index number).

5. **Dynamic Currency Labels:**

   - The currency names in the labels automatically change depending on the selected options.

6. **Error Handling:**

   - Input validation in the text field (textBox1) prevents entering invalid values.
   - Error messages notify the user about the need to correctly enter the data.

7. **Predefined Exchange Rates:**
   - Exchange rates are stored in an array, allowing quick and easy conversions and future modifications.

---

## Implemented Events

1. **Text Change in the Input Field (`TextBox.TextChanged`):**

   - Validates the entered data and automatically updates the conversion result.

2. **Scrollbar Control (`HScrollBar.ValueChanged`):**

   - Synchronizes the scrollbar value with the text field.

3. **Source and Target Currency Change (`RadioButton.CheckedChanged`):**

   - Updates the currency labels and conversion result.

4. **Character Validation (`TextBox.KeyPress`):**
   - Limits input to digits, commas, and control keys.

---

## Limitations and Possible Improvements

1. **User Interface:**

   - The user interface could be modernized, for example, by adding styles or responsiveness.

2. **Lack of Dynamic Exchange Rates:**

   - Currently, the exchange rates are hardcoded. Integrating data from an external API would enhance the application's functionality.

3. **Multilingual Support:**
   - The application could support multiple languages in the user interface.

---

## Project Self-Assessment

The project meets all specification requirements:

- It supports currency input and conversion.
- A custom currency has been implemented as required.
- Data validation and dynamic currency labels have been introduced.

**Suggested Rating:** 5/5

---

## Running Instructions

1. Open the project in Visual Studio.
2. Build the application by selecting the "Build" option.
3. Run the application and use the currency calculator functions via the graphical interface.

---

## Author

[Damian Tchorzewski, Index: 72206]
