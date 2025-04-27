# AcrylicScrollView

`AcrylicScrollView` is an **abstract base class** within AcrylicUI, designed to provide the foundational logic for controls that need to display scrollable content with themed scrollbars (e.g., `AcrylicListView`, `AcrylicTreeView`).

## Usage

This class is not intended to be instantiated directly in application code. Instead, you use controls that inherit from it, such as:

*   [`AcrylicListView`](AcrylicListView.md)
*   [`AcrylicTreeView`](AcrylicTreeView.md)

These derived controls implement the specific content rendering (like list items or tree nodes) within the scrollable framework provided by `AcrylicScrollView`.

## Key Functionality (Internal / Protected)

*   Manages vertical and horizontal `AcrylicScrollBar` instances.
*   Calculates content size and determines scrollbar visibility.
*   Handles scroll events and updates the displayed content area.
*   Provides protected methods for derived classes to interact with the scrolling mechanism. 