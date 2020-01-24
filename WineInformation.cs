using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;


namespace WineCatalogApp
{
/// <summary>
///  Describes the properties for all the Wine listed in the page
/// </summary>

    class WineInformation
    {
        #region Properties
        public int WineIDNumber { get; private set; }
        public string WineName { get; private set; }
        public string WineryName { get; private set; }
        public int Vintange { get; private set; }
        public int WineScore { get; private set; }
        public string WineVarietals { get; private set; }
        public string WineRegion { get; private set; }
        public decimal WinePrice { get; private set; }
        public DateAndTime SampledDate { get; private set; }
        public string WineNotes { get; private set; }
        public string Comments { get; set; }
        #endregion


    }
}
