# AcrylicDataGridView

`AcrylicDataGridView` is a data grid view control styled for AcrylicUI. It wraps the standard `System.Windows.Forms.DataGridView` to provide a themed appearance, including custom scrollbars and cell styles. It supports standard data binding and cell formatting.

## Basic Usage

Add `AcrylicDataGridView` to your form, configure its columns (either manually or through data binding), and populate it with data.

```csharp
using AcrylicUI.Controls;
using AcrylicUI.Forms;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic; // For List<T>
using System.ComponentModel; // For BindingList<T>

public partial class MyForm : AcrylicForm
{
    private AcrylicDataGridView dgvData;

    // Sample data structure
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
    }

    public MyForm()
    {
        InitializeComponent();

        dgvData = new AcrylicDataGridView
        {
            Location = new Point(20, 50),
            Size = new Size(500, 300),
            // AllowUserToAddRows = false, // Common setting
            // AllowUserToDeleteRows = false,
            // ReadOnly = true, // If data is display-only
            // AutoGenerateColumns = false, // Recommended for defined columns
            // MultiSelect = false,
            // SelectionMode = DataGridViewSelectionMode.FullRowSelect
        };
        Controls.Add(dgvData);

        // Define Columns (if AutoGenerateColumns = false)
        /* 
        var idCol = new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "ID", DataPropertyName = "Id", ReadOnly = true };
        var nameCol = new DataGridViewTextBoxColumn { Name = "Name", HeaderText = "Full Name", DataPropertyName = "Name" };
        var ageCol = new DataGridViewTextBoxColumn { Name = "Age", HeaderText = "Age", DataPropertyName = "Age" };
        var activeCol = new AcrylicDataGridViewCheckBoxColumn { Name = "IsActive", HeaderText = "Active", DataPropertyName = "IsActive" }; // Use Acrylic CheckBox column

dgvData.Columns.AddRange(idCol, nameCol, ageCol, activeCol);
        */

        // Load Data (Example using BindingList for change notification)
        var people = new BindingList<Person>()
        {
            new Person { Id = 1, Name = "Alice Smith", Age = 30, IsActive = true },
            new Person { Id = 2, Name = "Bob Johnson", Age = 25, IsActive = false },
            new Person { Id = 3, Name = "Charlie Brown", Age = 42, IsActive = true }
        };
        dgvData.DataSource = people;

        // Handle events (Example)
        dgvData.SelectionChanged += (s, e) => 
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                var selectedPerson = dgvData.SelectedRows[0].DataBoundItem as Person;
                // Use selectedPerson...
            }
        };
    }
}
```

## Key Properties

`AcrylicDataGridView` exposes many standard `DataGridView` properties. Some common ones include:

*   `DataSource`: Gets or sets the data source that the `AcrylicDataGridView` is displaying data for.
*   `Columns`: Gets the collection of columns displayed in the control.
*   `Rows`: Gets the collection of rows displayed in the control.
*   `CurrentCell`: Gets or sets the currently active cell.
*   `SelectedCells`, `SelectedColumns`, `SelectedRows`: Get collections of selected elements.
*   `AllowUserToAddRows`, `AllowUserToDeleteRows`, `AllowUserToOrderColumns`, `AllowUserToResizeColumns`, `AllowUserToResizeRows`: Control user interaction permissions.
*   `AutoGenerateColumns`: Gets or sets a value indicating whether columns are created automatically when the `DataSource` is set.
*   `ReadOnly`: Gets or sets a value indicating whether the user can edit the cells.
*   `SelectionMode`: Gets or sets how cells are selected (`CellSelect`, `FullRowSelect`, `FullColumnSelect`, etc.).
*   `MultiSelect`: Gets or sets a value indicating whether the user can select multiple elements.

## Custom Column/Cell Types

AcrylicUI provides themed versions for some cell types:
*   `AcrylicDataGridViewButtonColumn` / `AcrylicDataGridViewButtonCell`
*   `AcrylicDataGridViewCheckBoxColumn` / `AcrylicDataGridViewCheckBoxCell`

Use these column types when adding columns programmatically or in the designer for themed buttons or checkboxes within the grid.

## Events

Exposes standard `DataGridView` events, such as:
*   `CellClick`, `CellDoubleClick`
*   `CellValueChanged`
*   `SelectionChanged`
*   `DataBindingComplete`
*   `CellFormatting`: Allows custom formatting of cell display values.
*   `CellFormattingSafe`: A potentially safer alternative event for formatting (check component source for specifics). 