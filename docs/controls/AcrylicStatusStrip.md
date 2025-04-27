# AcrylicStatusStrip

`AcrylicStatusStrip` provides a status bar control, typically docked at the bottom of a form, with AcrylicUI styling. It replaces the standard `System.Windows.Forms.StatusStrip`.

## Basic Usage

Add `AcrylicStatusStrip` to your form (usually via the designer, docked to the bottom). Add items like `ToolStripStatusLabel` or `ToolStripProgressBar` to its `Items` collection to display information.

```csharp
using AcrylicUI.Controls;
using AcrylicUI.Forms;
using AcrylicUI.Resources;
using System.Windows.Forms;
using System.Drawing;

public partial class MyForm : AcrylicForm
{
    private AcrylicStatusStrip statusStrip;
    private ToolStripStatusLabel statusLabelLeft;
    private ToolStripStatusLabel statusLabelRight;

    public MyForm()
    {
        InitializeComponent(); // Assumes StatusStrip and items are added in designer

        // Example: Accessing items added in the designer by name
        // statusLabelLeft = (ToolStripStatusLabel)statusStrip.Items["statusLabelLeft"];
        // statusLabelRight = (ToolStripStatusLabel)statusStrip.Items["statusLabelRight"];
        
        // Or add programmatically:
        statusStrip = new AcrylicStatusStrip
        {
            Dock = DockStyle.Bottom,
            Padding = new Padding(statusStrip.Padding.Left + 2, 
                              statusStrip.Padding.Top, 
                              statusStrip.Padding.Right, 
                              statusStrip.Padding.Bottom), // Adjust padding slightly
            SizingGrip = false // Usually disabled for themed look
        };

        statusLabelLeft = new ToolStripStatusLabel("Ready") 
        { 
             Name = "statusLabelLeft", 
             TextAlign = ContentAlignment.MiddleLeft, 
             Spring = true // Allow this label to take up extra space
        };
        
        statusLabelRight = new ToolStripStatusLabel("Version 1.0") 
        { 
            Name = "statusLabelRight",
            TextAlign = ContentAlignment.MiddleRight
        };

        statusStrip.Items.AddRange(new ToolStripItem[] { 
            statusLabelLeft, 
            statusLabelRight 
        });

        Controls.Add(statusStrip);
    }

    // Example method to update status text
    public void UpdateStatus(string message)
    {
        if (statusLabelLeft != null)
        {
            // Ensure update is on UI thread if necessary
            if (statusStrip.InvokeRequired)
            {
                statusStrip.Invoke(new Action(() => statusLabelLeft.Text = message));
            }
            else
            { 
                statusLabelLeft.Text = message;
            }
        }
    }
}
```

## Key Properties

*   `Items`: Gets the collection of `ToolStripItem` objects displayed on the status strip.
*   `IsAcrylicEnabled`: Gets or sets whether the status strip should attempt to render with an acrylic background effect.
*   `SizingGrip`: Gets or sets a value indicating whether a sizing grip (handle) is displayed in the lower-right corner. Typically set to `false` for a themed appearance.
*   `Renderer`: Controls how the status strip is painted (automatically set by AcrylicUI).
*   Standard layout properties (`Dock`, `Padding`, etc.).

## Adding Items

Common items to add to the `Items` collection include:
*   `ToolStripStatusLabel`: Displays text.
*   `ToolStripProgressBar`: Displays a progress bar.
*   `ToolStripDropDownButton` / `ToolStripSplitButton`: For buttons with dropdown menus.

These can be added via the designer or programmatically.

---

**See also:** Example Form [`Form5_Borderless.cs`](../../Examples/Form5_Borderless.cs) 