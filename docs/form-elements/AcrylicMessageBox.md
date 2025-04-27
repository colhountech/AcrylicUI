# AcrylicMessageBox

`AcrylicMessageBox` provides static methods for displaying common message dialogs (Information, Warning, Error) with the AcrylicUI theme and styling. It simplifies showing standard messages to the user without needing to manually create an `AcrylicDialog` instance.

## Basic Usage

Call the static `Show*` methods directly from your code.

```csharp
using AcrylicUI.Forms;
using System.Windows.Forms;

public partial class MyForm : AcrylicForm
{
    // Simple informational message
    private void ShowInfo()
    {
        AcrylicMessageBox.ShowInformation(this, "Operation completed successfully.", "Success");
        // The first argument `this` sets the owner window.
    }

    // Warning message with Yes/No buttons
    private void ShowConfirmation()
    {
        DialogResult result = AcrylicMessageBox.ShowWarning(this, 
                                                          "Are you sure you want to delete this item? This action cannot be undone.", 
                                                          "Confirm Deletion", 
                                                          AcrylicDialogButton.YesNo); // Specify buttons

        if (result == DialogResult.Yes)
        {
            // Proceed with deletion
        }
    }

    // Error message
    private void ShowError()
    {
        AcrylicMessageBox.ShowError(this, "Failed to connect to the server. Please check your network connection.", "Connection Error");
    }
}
```

## Available Methods

*   `ShowInformation(owner, message, caption, [buttons])`: Displays an informational message box with an 'i' icon.
*   `ShowWarning(owner, message, caption, [buttons])`: Displays a warning message box with an exclamation mark icon.
*   `ShowError(owner, message, caption, [buttons])`: Displays an error message box with an error icon.

**Parameters:**

*   `owner`: The `IWin32Window` that will own the modal dialog box.
*   `message`: The text to display in the message box.
*   `caption`: The text to display in the title bar of the message box.
*   `buttons` (Optional): An `AcrylicDialogButton` enumeration value specifying which buttons to display (e.g., `Ok`, `OkCancel`, `YesNo`, `YesNoCancel`). Defaults to `Ok` if omitted.

**Returns:**

A `DialogResult` value corresponding to the button clicked by the user. 