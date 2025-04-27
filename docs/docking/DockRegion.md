# DockRegion

`DockRegion` is an internal control within the AcrylicUI docking framework. It represents one of the main docking areas within a `DockPanel`: Document, Left, Right, or Bottom.

## Usage

Developers do not interact directly with `DockRegion`. The `DockPanel` automatically creates and manages four `DockRegion` instances (one for each `DockArea`).

*   When `DockContent` is added to the `DockPanel`, it's routed to the appropriate `DockRegion` based on its `DefaultDockArea` or docking state.
*   Each `DockRegion` manages the layout, size, and visibility of the `DockGroup`(s) it contains.
*   The `DockRegion` handles the display and interaction logic for its associated `DockSplitter` (if applicable) to allow resizing.

Essentially, `DockRegion` acts as the top-level container for a specific docking area (e.g., the entire left-hand docked area) and manages the groups of tabbed content within that area.

## Key Functionality (Internal)

*   Represents a specific `DockArea` (Document, Left, Right, Bottom).
*   Manages a collection of `DockGroup` instances.
*   Controls the docking (`Dock` property) and sizing of the region within the `DockPanel`.
*   Manages the visibility and position of its associated `DockSplitter`.
*   Handles adding, removing, and inserting content into its `DockGroup`s.

---

**See also:** [`DockPanel`](DockPanel.md), [`DockGroup`](DockGroup.md), [`DockArea`](DockArea.md), [`DockSplitter`](DockSplitter.md) 