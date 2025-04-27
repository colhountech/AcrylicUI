# AcrylicGroupBox

`AcrylicGroupBox` provides a container control with AcrylicUI styling, displaying a frame and a title around a group of child controls.

## Basic Usage

Add `AcrylicGroupBox` to your form, set its `Text` property for the title, and add other controls inside it either via the designer or programmatically to its `Controls` collection.

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

        var groupBox = new AcrylicGroupBox
        {
            Text = "User Options",
            Location = new Point(20, 50),
            Size = new Size(300, 150),
            BorderColor = Colors.DarkBorder, // Optional: Customize border color
            ForeColor = Colors.LightText // Sets the Text color for the title
        };
        Controls.Add(groupBox);

        // Add controls inside the GroupBox
        var checkBox = new AcrylicCheckBox
        {
            Text = "Enable Notifications",
            Location = new Point(15, 30), // Position relative to GroupBox top-left
            AutoSize = true
        };
        groupBox.Controls.Add(checkBox);

        var button = new AcrylicButton
        {
            Text = "Apply",
            Location = new Point(15, checkBox.Bottom + 10),
            Size = new Size(80, 32)
        };
        groupBox.Controls.Add(button);
    }
}
```

## Key Properties

*   `Text`: Gets or sets the title text displayed on the group box frame.
*   `BorderColor`: Gets or sets the color used to draw the border frame.
*   `ForeColor`: Gets or sets the color of the title text.
*   `Controls`: The collection of controls contained within the group box.
*   Standard layout properties like `Location`, `Size`, `Dock`, `Anchor`.

---

**See also:** Example Form [`Form2_Buttons.cs`](../../Examples/Form2_Buttons.cs) 