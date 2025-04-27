# AcrylicLabel

`AcrylicLabel` is the standard text label control for AcrylicUI, providing themed styling consistent with the application's appearance. It replaces the standard `System.Windows.Forms.Label`.

## Basic Usage

Add `AcrylicLabel` to your form or user control via the designer or code, and set its `Text` property.

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

        var infoLabel = new AcrylicLabel
        {
            Text = "User Name:",
            Location = new Point(20, 50),
            AutoSize = true, // Automatically adjust size to fit text
            ForeColor = Colors.LightText // Use themed text color
        };
        Controls.Add(infoLabel);

        var dataLabel = new AcrylicLabel
        {
            Text = "(Name goes here)",
            Location = new Point(infoLabel.Right + 5, 50),
            AutoSize = true,
            ForeColor = Colors.DisabledText // Use a different color for emphasis
        };
        Controls.Add(dataLabel);
    }
}
```

## Key Properties

*   `Text`: The text displayed by the label.
*   `ForeColor`: The color of the text.
*   `AutoSize`: Gets or sets a value indicating whether the control automatically resizes based on its contents.
*   `TextAlign`: Gets or sets the alignment of text within the label.
*   Standard layout properties like `Location`, `Size`, `Dock`, `Anchor`.

---

**See also:** Example Form [`Form11_Labels.cs`](../../Examples/Form11_Labels.cs) 