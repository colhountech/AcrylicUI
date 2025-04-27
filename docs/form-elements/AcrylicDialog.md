# AcrylicDialog

`AcrylicDialog` serves as a base class for creating custom modal dialog windows within an AcrylicUI application. It provides a consistent look and feel, including the themed border and title bar, and allows for predefined button sets (like OK, Cancel, Yes/No) via the `DialogButtons` property.

## Basic Usage

Typically, you would create a new class that inherits from `AcrylicDialog`, add your specific controls in the designer or code, and then instantiate and show your custom dialog.

```csharp
using AcrylicUI.Forms;
using AcrylicUI.Controls;
using System.Windows.Forms;
using System.Drawing;

// 1. Define your custom dialog by inheriting from AcrylicDialog
public class MyCustomDialog : AcrylicDialog
{
    public string UserInput { get; private set; }
    private AcrylicTextBox txtInput;

    public MyCustomDialog()
    {
        // Set standard buttons (optional)
        DialogButtons = AcrylicDialogButton.OkCancel;
        Text = "Enter Value"; // Set Dialog Title
        
        // Add custom controls
        var lblPrompt = new AcrylicLabel
        {
            Text = "Please enter your name:",
            Location = new Point(15, 15),
            AutoSize = true
        };
        Controls.Add(lblPrompt);

        txtInput = new AcrylicTextBox
        {
            Location = new Point(15, lblPrompt.Bottom + 10),
            Width = ClientSize.Width - 30 // Adjust width dynamically
        };
        Controls.Add(txtInput);

        // Set initial size (optional, can also be done in designer)
        ClientSize = new Size(300, 130);

        // Set the input textbox to take focus
        ActiveControl = txtInput; 

        // Adjust button locations if needed (they are added automatically based on DialogButtons)
        // Example: okButton.Location = ...; 
    }

    // Override OnDialogButtonClicked if you need custom logic before closing
    protected override void OnDialogButtonClicked(DialogResult result)
    {
        if (result == DialogResult.OK)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                AcrylicMessageBox.ShowWarning(this, "Input cannot be empty.", "Validation");
                return; // Prevent dialog from closing
            }
            UserInput = txtInput.Text;
        }
        base.OnDialogButtonClicked(result);
    }
}

// 2. Use your custom dialog
public void ShowMyDialog()
{
    using (var customDialog = new MyCustomDialog())
    {
        DialogResult result = customDialog.ShowDialog(this); // Pass owner form

        if (result == DialogResult.OK)
        {
            string enteredValue = customDialog.UserInput;
            AcrylicMessageBox.ShowInformation(this, $"You entered: {enteredValue}", "Result");
        }
        else
        {   
            AcrylicMessageBox.ShowInformation(this, "Dialog was cancelled.", "Result");
        }
    }
}
```

## Key Properties

*   `DialogButtons`: Gets or sets which standard buttons (OK, Cancel, Yes, No, etc.) appear on the dialog. Set this in your custom dialog's constructor.
*   `Controls`: Add your custom labels, text boxes, etc., to this collection, just like a standard Form. 