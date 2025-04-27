# AcrylicListItem

`AcrylicListItem` represents a single item within an `AcrylicListView` control. It holds the text, optional icon, and associated data for an item.

## Basic Usage

Create instances of `AcrylicListItem` and add them to the `Items` collection of an `AcrylicListView`. You typically set the `Text` property and can optionally assign an `Icon` and store related data in the `Tag` property.

```csharp
using AcrylicUI.Controls;
using AcrylicUI.Forms;
using AcrylicUI.Resources; // For Icons
using System.Windows.Forms;
using System.Drawing;

public partial class MyForm : AcrylicForm
{
    private AcrylicListView myListView;

    public class MyItemData
    {
        public int ItemId { get; set; }
        public string Description { get; set; }
    }

    public MyForm()
    {
        InitializeComponent();

        myListView = new AcrylicListView
        {
            Location = new Point(20, 50),
            Size = new Size(250, 300)
        };
        Controls.Add(myListView);

        // Add items individually
        var item1 = new AcrylicListItem("First Item");
        item1.Icon = Icons.folder_16x; // Example using built-in icon
        item1.Tag = new MyItemData { ItemId = 101, Description = "Data for item 1" };
        myListView.Items.Add(item1);

        var item2 = new AcrylicListItem("Second Item (No Icon)");
        item2.Tag = new MyItemData { ItemId = 102, Description = "Data for item 2" };
        myListView.Items.Add(item2);
        
        // Add multiple items
        for(int i=3; i<=5; i++)
        {
            var newItem = new AcrylicListItem($"Item {i}");
            newItem.Tag = new MyItemData { ItemId = 100 + i, Description = $"Data for item {i}" };
            myListView.Items.Add(newItem);
        }

        // Handle selection change in the ListView
        myListView.SelectedItemsChanged += (s, e) => {
            if (myListView.SelectedItems.Count > 0)
            {
                AcrylicListItem selectedItem = myListView.SelectedItems[0];
                if (selectedItem.Tag is MyItemData data)
                {
                    AcrylicMessageBox.ShowInformation(this, $"Selected: {selectedItem.Text}\nID: {data.ItemId}\nDesc: {data.Description}", "Item Selected");
                }
            }
        };
    }
}
```

## Key Properties

*   `Text`: Gets or sets the primary text displayed for the list item.
*   `Icon`: Gets or sets the `Image` displayed next to the text.
*   `Tag`: Gets or sets the object that contains data about the control. Commonly used to associate business objects or identifiers with the list item.
*   `Area`: Represents the rectangle occupied by the item within the list view (used internally by `AcrylicListView`).
*   `Selected`: Indicates whether the item is currently selected (managed by `AcrylicListView`).

---

**See also:** [`AcrylicListView`](AcrylicListView.md), Example Form [`Form7_ListItems.cs`](../../Examples/Form7_ListItems.cs) 