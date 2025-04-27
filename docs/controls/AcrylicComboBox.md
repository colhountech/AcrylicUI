# AcrylicComboBox

`AcrylicComboBox` is a combo box control providing AcrylicUI styling. It allows users to select an item from a dropdown list or enter new text if the `DropDownStyle` property allows.

## Basic Usage

Add `AcrylicComboBox` to your form, populate its `Items` collection, and handle the `SelectedIndexChanged` event or retrieve the selected item using properties like `SelectedItem` or `SelectedIndex`.

```csharp
using AcrylicUI.Controls;
using AcrylicUI.Forms;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

public partial class MyForm : AcrylicForm
{
    private AcrylicComboBox cmbOptions;

    public MyForm()
    {
        InitializeComponent();

        cmbOptions = new AcrylicComboBox
        {
            Location = new Point(20, 50),
            Width = 200,
            DropDownStyle = ComboBoxStyle.DropDownList // Prevent user text entry
        };

        // Populate items
        cmbOptions.Items.Add("Option 1");
        cmbOptions.Items.Add("Option 2");
        cmbOptions.Items.Add("Another Option");
        
        // Or bind to a list of objects
        // List<MyObject> data = ...;
        // cmbOptions.DataSource = data;
        // cmbOptions.DisplayMember = "NameProperty"; // Property to display
        // cmbOptions.ValueMember = "IdProperty";   // Property for the value

        // Set initial selection (optional)
        if (cmbOptions.Items.Count > 0)
        {
            cmbOptions.SelectedIndex = 0;
        }

        // Handle selection changes
        cmbOptions.SelectedIndexChanged += CmbOptions_SelectedIndexChanged;
        
        Controls.Add(cmbOptions);
    }

    private void CmbOptions_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        if (cmbOptions.SelectedItem != null)
        {
            string selectedText = cmbOptions.SelectedItem.ToString();
            int selectedIndex = cmbOptions.SelectedIndex;
            AcrylicMessageBox.ShowInformation(this, $"Selected: {selectedText} (Index: {selectedIndex})", "Selection Changed");
        }
    }
}
```

## Key Properties

*   `Items`: Gets the collection of items in the combo box.
*   `SelectedItem`: Gets or sets the currently selected item.
*   `SelectedIndex`: Gets or sets the index of the currently selected item.
*   `SelectedText`: Gets or sets the text that is selected in the editable portion of a `ComboBox`.
*   `SelectedValue`: Gets or sets the value of the member property specified by the `ValueMember` property (used with data binding).
*   `DataSource`: Gets or sets the data source for the combo box.
*   `DisplayMember`: Gets or sets the property to display for the items in this control (used with data binding).
*   `ValueMember`: Gets or sets the property to use as the actual value for the items in the control (used with data binding).
*   `DropDownStyle`: Gets or sets a value specifying the style of the combo box (`DropDown`, `DropDownList`, `Simple`). `DropDownList` prevents user text entry.

## Events

*   `SelectedIndexChanged`: Occurs when the `SelectedIndex` property has changed.

---

**See also:** Example Form [`Form15_ComboBox.cs`](../../Examples/Form15_ComboBox.cs) 