# AcrylicSingleInput

`AcrylicSingleInput` is a specialized `AcrylicDialog` designed to easily prompt the user for a single line of text input. It displays a label, a text box, and standard dialog buttons.

## Basic Usage

Instantiate `AcrylicSingleInput`, optionally set its properties, show it using `ShowDialog()`, and retrieve the entered text from the `TextName` property if the dialog result is `OK`.

```csharp
using AcrylicUI.Forms;
using System.Windows.Forms;

public partial class MyForm : AcrylicForm
{
    private void PromptForName()
    {
        using (var inputDialog = new AcrylicSingleInput())
        {
            // Configure the dialog
            inputDialog.Text = "Enter Name"; // Dialog title
            inputDialog.LabelText = "Please enter the new item name:"; // Prompt label
            inputDialog.TextName = "Default Name"; // Optional: Pre-fill the text box
            inputDialog.DialogButtons = AcrylicDialogButton.OkCancel; // Set buttons

            // Show the dialog
            DialogResult result = inputDialog.ShowDialog(this); 

            // Process the result
            if (result == DialogResult.OK)
            {
                string enteredName = inputDialog.TextName; // Get the entered value
                AcrylicMessageBox.ShowInformation(this, $"You entered: {enteredName}", "Input Received");
                // ... use enteredName ...
            }
        }
    }
}
```

## Key Properties

*   `LabelText`: Gets or sets the text displayed in the label above the input box.
*   `TextName`: Gets or sets the text within the input text box. Use this to pre-fill the input and retrieve the value entered by the user.
*   `DialogButtons`: Gets or sets the standard buttons (inherited from `AcrylicDialog`).
*   `Text`: Sets the title of the dialog window (inherited from `Form`). 