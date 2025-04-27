# AcrylicListView

`AcrylicListView` provides a list view control with AcrylicUI styling, capable of displaying a collection of `AcrylicListItem` objects with custom drawing, scrolling, and selection.

## Basic Usage

Add `AcrylicListView` to your form, and populate its `Items` collection with `AcrylicListItem` instances. Handle selection events like `SelectedItemsChanged` to respond to user interaction.

```csharp
using AcrylicUI.Controls;
using AcrylicUI.Forms;
using AcrylicUI.Resources; // For Icons
using System.Windows.Forms;
using System.Drawing;
using System.Linq; // For FirstOrDefault

public partial class MyForm : AcrylicForm
{
    private AcrylicListView myListView;
    private AcrylicLabel lblSelection;

    public MyForm()
    {
        InitializeComponent();

        myListView = new AcrylicListView
        {
            Location = new Point(20, 50),
            Size = new Size(250, 300),
            ShowIcons = true, // Show icons if items have them
            AlternateBackground = true // Alternate row background colors
        };
        Controls.Add(myListView);

        lblSelection = new AcrylicLabel
        {
            Text = "Selected: (None)",
            Location = new Point(20, myListView.Bottom + 10),
            AutoSize = true
        };
        Controls.Add(lblSelection);
        
        // Populate with AcrylicListItems
        for(int i=1; i<=15; i++)
        {
            var item = new AcrylicListItem($"List Item Number {i}");
            if (i % 3 == 0) // Add icon to every third item
            {
                item.Icon = Icons.document_16x;
            }
            item.Tag = i; // Store item index in Tag
            myListView.Items.Add(item);
        }

        // Handle selection changes
        myListView.SelectedItemsChanged += MyListView_SelectedItemsChanged;
    }

    private void MyListView_SelectedItemsChanged(object sender, System.EventArgs e)
    {
        AcrylicListItem selectedItem = myListView.SelectedItems.FirstOrDefault();
        
        if (selectedItem != null)
        {
            lblSelection.Text = $"Selected: {selectedItem.Text} (Tag: {selectedItem.Tag})";
        }
        else
        {
            lblSelection.Text = "Selected: (None)";
        }
    }
}
```

## Key Properties

*   `Items`: Gets the `ObservableCollection<AcrylicListItem>` containing the items displayed in the list.
*   `SelectedItems`: Gets a list of the currently selected `AcrylicListItem` objects.
*   `SelectedIndices`: Gets a list of the indexes of the currently selected items.
*   `MultiSelect`: Gets or sets a value indicating whether multiple items can be selected.
*   `ShowIcons`: Gets or sets a value indicating whether icons assigned to `AcrylicListItem` objects should be displayed.
*   `AlternateBackground`: Gets or sets a value indicating whether alternating row background colors should be used.
*   `ItemPadding`: Gets or sets the padding within each item's drawing area.

## Events

*   `SelectedItemsChanged`: Occurs when the selection changes (items are selected or deselected).
*   `ItemClicked`: Occurs when an item is clicked.
*   `ItemDoubleClicked`: Occurs when an item is double-clicked.

---

**See also:** [`AcrylicListItem`](AcrylicListItem.md), Example Form [`Form7_ListItems.cs`](../../Examples/Form7_ListItems.cs) 