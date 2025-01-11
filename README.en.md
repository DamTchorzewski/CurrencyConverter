# Currency Converter

**CurrencyConverter** is a Windows Forms application that serves as a currency conversion calculator. The project was developed according to the specification requirements, offering an intuitive user interface and functionalities such as dynamic currency labels, support for custom currencies, and conversion of values ​​based on predefined exchange rates.

---

## Application Features

1. **Currency Value Entry:**
- Users can enter the source currency amount in the text field.

2. **Scrollbar Control:**
- The source currency value can also be set using the horizontal scrollbar (hScrollBar).

3. **Currency Conversion:**
- The application converts the source currency value to the target currency using the defined exchange rates.
- The source and target currencies are selected using radio buttons (RadioButton).

4. **Custom Currency:**
- Custom currency named "DT" (derived from the author's initials) with an exchange rate of 722.06 (according to the author's index number).

5. **Dynamic Labels:**
- Currency names in labels change dynamically based on user selection.

6. **Error Handling:**
- Validation of numeric data in the text box to avoid errors.
- Displaying error messages in case of invalid data entry.

7. **Predefined Exchange Rates:**
- Currency rates are stored in an array, which ensures fast conversion and easy modification.

---

## Implemented Events

1. **Text Change in Input Box (`TextBox.TextChanged`):**
- Validates the entered data and calls the function to convert the target currency.

2. **ScrollBar Value Change (`HScrollBar.ValueChanged`):**
- Synchronizes the scrollbar value with the text field.

3. **Currency Change (`RadioButton.CheckedChanged`):**
- Updates the source and target currency labels and recalculates the currency values.

4. **Automatic Currency Conversion:**
- Called whenever the source value changes or a different currency is selected.

---

## Limitations and Possible Improvements

- **User Interface:**
- The GUI could be modernized to improve aesthetics and usability.

- **Lack of Language Support:**
- Currently, the application only supports English labels and messages.

- **Dynamic Exchange Rates:**
- The rates are statically encoded and are not updated in real time.

---

## Project self-assessment

The project fully meets the specification assumptions, and all required functionalities have been implemented. Additionally, the application includes error handling, integration with the scroll bar, and dynamically changing currency labels. The introduction of a non-standard currency has also been implemented according to the assumptions.

### **Suggested rating: 5/5**
The project meets all the requirements and works as expected, which justifies the highest rating.

---

## Startup instructions

1. Open the project in the Visual Studio environment.

2. Select the "Build" option and run the application.

3. Use the graphical interface to test the currency conversion functionality.

---

## Author
[Damian Tchorzewski 72206]