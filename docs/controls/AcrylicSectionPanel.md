# AcrylicSectionPanel

`AcrylicSectionPanel` is a specialized `AcrylicPanel` that includes a distinct header area at the top, allowing for a title or section header text.

## Basic Usage

Add `AcrylicSectionPanel` to your form, set its `SectionHeader` property, and add child controls to its `Controls` collection. The child controls will be placed below the header area.

```csharp
using AcrylicUI.Controls;
using AcrylicUI.Forms;
using AcrylicUI.Resources;
using System.Windows.Forms;
using System.Drawing;

public partial class MyForm : AcrylicForm
{
    public MyForm()
    {
        InitializeComponent();

        var sectionPanel = new AcrylicSectionPanel
        {
            Location = new Point(20, 50),
            Size = new Size(300, 200),
            SectionHeader = "User Details", // Set the header text
            // Icon = Icons.User_16x // Optional: Set an icon for the header
        };
        Controls.Add(sectionPanel);

        // Add controls within the section panel's content area
        var nameLabel = new AcrylicLabel
        {
            Text = "Name:",
            Location = new Point(10, 10) // Position relative to panel's content area
        };
        sectionPanel.Controls.Add(nameLabel);

        var nameTextBox = new AcrylicTextBox
        {
            Location = new Point(nameLabel.Right + 5, 8),
            Width = 180
        };
        sectionPanel.Controls.Add(nameTextBox);
    }
}
```

## Key Properties

*   `SectionHeader`: Gets or sets the text displayed in the header area of the panel.
*   `Icon`: Gets or sets the `Image` displayed in the header area, typically to the left of the `SectionHeader` text.
*   Inherits properties from `AcrylicPanel`:
    *   `BackColor`, `BorderColor`, `BorderStyle`
    *   `Controls`
    *   Standard layout properties (`Location`, `Size`, `Dock`, `Anchor`, `Padding`)

*Note: The `Padding` property influences the space between the section panel's border and its child controls, below the header.* 

---

**See also:** [`AcrylicPanel`](AcrylicPanel.md), Example Form [`Form14_SectionPanel.cs`](../../Examples/Form14_SectionPanel.cs) 