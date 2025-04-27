# AcrylicTextBox

`AcrylicTextBox` is a text box control providing AcrylicUI styling. It replaces the standard `System.Windows.Forms.TextBox` and includes support for placeholder text.

## Basic Usage

Add `AcrylicTextBox` to your form, set its initial `Text` or `PlaceholderText`, and handle text change events or retrieve the entered text via the `Text` property.

```csharp
using AcrylicUI.Controls;
using AcrylicUI.Forms;
using System.Windows.Forms;
using System.Drawing;

public partial class MyForm : AcrylicForm
{
    private AcrylicTextBox txtName;
    private AcrylicTextBox txtNotes;

    public MyForm()
    {
        InitializeComponent();

        txtName = new AcrylicTextBox
        {
            Location = new Point(20, 50),
            Width = 200,
            PlaceholderText = "Enter item name..." // Display hint when empty
        };
        Controls.Add(txtName);

        txtNotes = new AcrylicTextBox
        {
            Location = new Point(20, txtName.Bottom + 10),
            Size = new Size(300, 100),
            Multiline = true, // Enable multiple lines
            ScrollBars = ScrollBars.Vertical, // Add scrollbars if needed
            PlaceholderText = "Enter notes here..."
        };
        Controls.Add(txtNotes);

        // Handle text changes (optional)
        txtName.TextChanged += TxtName_TextChanged;
    }

    private void TxtName_TextChanged(object sender, System.EventArgs e)
    {
        // Respond to text changes in the name box
        string currentName = txtName.Text;
        // ... 
    }

    private void SaveData()
    {
        string nameValue = txtName.Text;
        string notesValue = txtNotes.Text;
        // ... use the values ...
    }
}
```

## Key Properties

*   `Text`: Gets or sets the current text in the text box.
*   `PlaceholderText`: Gets or sets the text that is displayed when the control has no text and does not have the focus.
*   `Multiline`: Gets or sets a value indicating whether this is a multiline text box.
*   `ScrollBars`: Gets or sets which scroll bars should appear in a multiline text box (`None`, `Horizontal`, `Vertical`, `Both`).
*   `ReadOnly`: Gets or sets a value indicating whether text can be edited.
*   `PasswordChar`: Gets or sets the character used to mask characters in a single-line text box.
*   `MaxLength`: Gets or sets the maximum number of characters the user can type.
*   `TextAlign`: Gets or sets how text is aligned.

## Events

*   `TextChanged`: Occurs when the `Text` property value changes.
*   Standard control events like `KeyDown`, `KeyPress`, `KeyUp`, `Enter`, `Leave`.

---

**See also:** Example Form [`Form7_ListItems.cs`](../../Examples/Form7_ListItems.cs) 