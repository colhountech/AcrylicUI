# AcrylicNumericUpDown

`AcrylicNumericUpDown` provides a numeric input control with up/down spinner buttons, styled according to the AcrylicUI theme. It replaces the standard `System.Windows.Forms.NumericUpDown`, notably providing custom rendering for the spinner buttons to match the theme, which is difficult to achieve with the default control.

## Basic Usage

Add `AcrylicNumericUpDown` to your form, configure its range (`Minimum`, `Maximum`) and increment (`Increment`), and access its `Value` property.

```csharp
using AcrylicUI.Controls;
using AcrylicUI.Forms;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization; // For NumberFormatInfo

public partial class MyForm : AcrylicForm
{
    private AcrylicNumericUpDown numericInput;
    private AcrylicLabel lblValueDisplay;

    public MyForm()
    {
        InitializeComponent();

        numericInput = new AcrylicNumericUpDown
        {
            Location = new Point(20, 50),
            Size = new Size(120, 28), // Adjust size as needed
            Minimum = 0,      // Set the allowed range
            Maximum = 100,
            Value = 25,       // Set the initial value
            Increment = 5,      // Step value for spinner buttons
            DecimalPlaces = 0   // Number of decimal places to display
            // ThousandsSeparator = true, // Optional formatting
        };
        Controls.Add(numericInput);

        lblValueDisplay = new AcrylicLabel
        {
            Text = $"Current Value: {numericInput.Value}",
            Location = new Point(numericInput.Right + 10, 55),
            AutoSize = true
        };
        Controls.Add(lblValueDisplay);

        // Handle value changes
        numericInput.ValueChanged += NumericInput_ValueChanged;
    }

    private void NumericInput_ValueChanged(object sender, System.EventArgs e)
    {
        // Update label when value changes
        lblValueDisplay.Text = $"Current Value: {numericInput.Value}";
        
        // Perform actions based on the new value...
        decimal currentValue = numericInput.Value;
        // ...
    }
}
```

## Key Properties

*   `Value`: Gets or sets the current numeric value.
*   `Minimum`: Gets or sets the minimum allowed value.
*   `Maximum`: Gets or sets the maximum allowed value.
*   `Increment`: Gets or sets the value to increment or decrement by when the spinner buttons are clicked.
*   `DecimalPlaces`: Gets or sets the number of decimal places to display.
*   `ThousandsSeparator`: Gets or sets a value indicating whether the thousands separator will be inserted between every three decimal digits.
*   `Hexadecimal`: Gets or sets a value indicating whether the spin box should display the value in hexadecimal format.
*   `ReadOnly`: Gets or sets a value indicating whether the text can be changed only by using the spinner buttons and not by typing.
*   `TextAlign`: Gets or sets the horizontal alignment of the text.

## Events

*   `ValueChanged`: Occurs when the `Value` property has changed. 