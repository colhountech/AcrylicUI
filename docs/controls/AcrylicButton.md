# AcrylicButton

`AcrylicButton` is the standard button control for AcrylicUI, providing themed styling consistent with Windows 11 aesthetics. It supports text, icons, and different visual styles.

## Basic Usage

Add `AcrylicButton` to your form or user control via the designer or code, set its properties, and handle its `Click` event.

```csharp
using AcrylicUI.Controls;
using AcrylicUI.Resources; // For ButtonStyle
using System.Windows.Forms;
using System.Drawing;

public partial class MyForm : AcrylicUI.Forms.AcrylicForm
{
    public MyForm()
    {
        InitializeComponent();

        // Example Button 1: Standard Style
        var standardButton = new AcrylicButton
        {
            Text = "Save",
            Location = new Point(20, 50),
            Size = new Size(100, 32), // Standard height is often 32
            // Icon = Properties.Resources.SaveIcon, // Optional: Set an icon 
        };
        standardButton.Click += StandardButton_Click; 
        Controls.Add(standardButton);

        // Example Button 2: Primary Style
        var primaryButton = new AcrylicButton
        {
            Text = "Confirm",
            Location = new Point(standardButton.Right + 10, 50),
            Size = new Size(100, 32),
            Style = ButtonStyle.Primary // Use Primary style for emphasis
        };
        primaryButton.Click += (sender, e) => { /* Confirmation logic */ };
        Controls.Add(primaryButton);
        
        // Example Button 3: Icon Only (e.g., for ToolStrip)
        var iconButton = new AcrylicButton
        {
            Icon = Icons.close_grey_16x_svg, // Assign an appropriate image 
            ButtonStyle = ButtonStyle.None, // Often used for icon-only buttons
            Size = new Size(28, 28), // Square size common for icon buttons
            Location = new Point(primaryButton.Right + 10, 52)
        };
        iconButton.Click += (sender, e) => { /* Close action */ };
        Controls.Add(iconButton);
    }

    private void StandardButton_Click(object sender, System.EventArgs e)
    {
        AcrylicUI.Forms.AcrylicMessageBox.ShowInformation(this, "Save action triggered!", "Button Click");
    }
}
```

## Key Properties

*   `Text`: The text displayed on the button.
*   `Icon`: An `Image` to display on the button (often placed to the left of the text).
*   `Style`: An `AcrylicUI.Resources.ButtonStyle` enum value determining the button's appearance (`Standard`, `Primary`, `None`, etc.). `Primary` is often used for the main confirmation action.
*   `Enabled`: Standard property to enable/disable the button.
*   `Size`, `Location`, `Dock`, `Anchor`: Standard WinForms layout properties.

## Events

*   `Click`: The standard event raised when the button is clicked. 