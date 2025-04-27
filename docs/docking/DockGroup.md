# DockGroup

`DockGroup` is an internal control within the AcrylicUI docking framework. It represents a group of one or more `DockContent` items within a specific `DockRegion`.

## Usage

Developers typically do not interact directly with `DockGroup`. It is managed internally by the `DockPanel` and `DockRegion` controls.

*   When you add `DockContent` to a `DockPanel`, the panel determines which `DockRegion` it belongs to.
*   The `DockRegion` then places the content into an appropriate `DockGroup`.
*   If multiple `DockContent` items are placed into the same `DockGroup`, the group displays them with tabs.
*   Dragging and dropping `DockContent` items can create new `DockGroup` instances or move content between existing groups, handled automatically by the framework.

Essentially, a `DockGroup` acts as the visual container (a `Panel`) that holds the actual `DockContent` controls and renders the tabs if necessary.

## Key Functionality (Internal)

*   Manages a collection of `DockContent` items.
*   Displays tabs (`DockTab`) if it contains more than one item (or one item in the Document area).
*   Handles switching the visibility between tabbed `DockContent` items.
*   Manages the layout and painting of the tab area and the content area.

---

**See also:** [`DockPanel`](DockPanel.md), [`DockRegion`](DockRegion.md), [`DockContent`](DockContent.md), [`DockTab`](DockTab.md) 