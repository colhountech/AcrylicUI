# AcrylicCheckBox

`AcrylicCheckBox` provides a standard check box control with AcrylicUI styling.

## Basic Usage

Add `AcrylicCheckBox` to your form or user control, set its `Text` property, and check its `Checked` state or handle the `CheckedChanged` event.

```csharp
using AcrylicUI.Controls;
using System.Windows.Forms;
using System.Drawing;

public partial class MyForm : AcrylicUI.Forms.AcrylicForm
{
    private AcrylicCheckBox chkEnableFeature;

    public MyForm()
    {
        InitializeComponent();

        chkEnableFeature = new AcrylicCheckBox
        {
            Text = "Enable Advanced Feature",
            Location = new Point(20, 50),
            AutoSize = true, // Let the control size itself based on text
            Checked = false // Initial state
        };

        // Handle state changes
        chkEnableFeature.CheckedChanged += ChkEnableFeature_CheckedChanged;
        
        Controls.Add(chkEnableFeature);
    }

    private void ChkEnableFeature_CheckedChanged(object sender, System.EventArgs e)
    {
        bool isEnabled = chkEnableFeature.Checked;
        AcrylicUI.Forms.AcrylicMessageBox.ShowInformation(this, $"Advanced Feature Enabled: {isEnabled}", "Setting Changed");
        // Update other UI elements based on the state...
    }

    private void CheckCurrentState()
    {
        if (chkEnableFeature.Checked)
        {
            // Feature is currently enabled
        }
        else
        {
            // Feature is currently disabled
        }
    }
}
```

## Key Properties

*   `Text`: The descriptive label displayed next to the check box.
*   `Checked`: Gets or sets a boolean value indicating whether the check box is checked.
*   `CheckState`: Gets or sets the state (`Unchecked`, `Checked`, `Indeterminate`). Useful for three-state checkboxes.
*   `ThreeState`: Gets or sets whether the checkbox supports an indeterminate state along with checked and unchecked.
*   `Enabled`: Standard property to enable/disable interaction.
*   `AutoSize`, `Location`: Standard WinForms layout properties.

## Events

*   `CheckedChanged`: Occurs when the value of the `Checked` property changes.
*   `CheckStateChanged`: Occurs when the value of the `CheckState` property changes.

```csharp
using AcrylicUI.Controls;
using System.Windows.Forms;
using System.Drawing;

public partial class MyForm : AcrylicUI.Forms.AcrylicForm
{
    private AcrylicCheckBox chkEnableFeature;

    public MyForm()
    {
        InitializeComponent();

        chkEnableFeature = new AcrylicCheckBox
        {
            Text = "Enable Advanced Feature",
            Location = new Point(20, 50),
            AutoSize = true, // Let the control size itself based on text
            Checked = false // Initial state
        };

        // Handle state changes
        chkEnableFeature.CheckedChanged += ChkEnableFeature_CheckedChanged;
        
        Controls.Add(chkEnableFeature);
    }

    private void ChkEnableFeature_CheckedChanged(object sender, System.EventArgs e)
    {
        bool isEnabled = chkEnableFeature.Checked;
        AcrylicUI.Forms.AcrylicMessageBox.ShowInformation(this, $"Advanced Feature Enabled: {isEnabled}", "Setting Changed");
        // Update other UI elements based on the state...
    }

    private void CheckCurrentState()
    {
        if (chkEnableFeature.Checked)
        {
            // Feature is currently enabled
        }
        else
        {
            // Feature is currently disabled
        }
    }
} 