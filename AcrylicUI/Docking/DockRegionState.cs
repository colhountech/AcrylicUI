﻿using System.Collections.Generic;
using System.Drawing;

namespace AcrylicUI.Docking
{
    public class DockRegionState
    {
        #region Property Region

        public DockArea Area { get; set; }

        public Size Size { get; set; }

        public List<DockGroupState> Groups { get; set; }

        #endregion

        #region Constructor Region

        public DockRegionState()
        {
            Groups = new List<DockGroupState>();
        }

        public DockRegionState(DockArea area)
            : this()
        {
            Area = area;
        }

        public DockRegionState(DockArea area, Size size)
            : this(area)
        {
            Size = size;
        }

        #endregion
    }
}
