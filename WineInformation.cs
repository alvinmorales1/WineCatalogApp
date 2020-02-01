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
        private static int lastIDNumber = 0;
        #region Properties
        public int WineIDNumber { get; private set; }
        public string WineName { get; private set; }
        public string WineryName { get; private set; }
        public int Vintange { get; private set; }
        public int WineScore { get; private set; }
        public string WineVarietals { get; private set; }
        public string WineRegion { get; private set; }
        public decimal WinePrice { get; private set; }
        public DateTime SampledDate { get; private set; }
        public DateTime RecordedDate { get;private set; }
        public string WineNotes { get; private set; }
        public string WineComments { get; set; }
        #endregion

        #region Methods
        public void AddWineName(string Name)
        {
            WineName = Name;
        }
        public void AddWineryName(string Winery)
        {
            WineryName = Winery;
        }
        public void AddVintage(int Year)
        {
            Vintange = Year;
        }
        public void AddWineScore(int Score)
        {
            Vintange = Score;
        }
        public void AddWineVarietals(string Grape)
        {
            WineVarietals = Grape;
        }
        public void AddWineRegion(string Region)
        {
            WineRegion = Region;
        }
        public void AddWinePrice(decimal Price)
        {
            WinePrice = Price;
        }
        public void AddSampleDate(DateTime Sample)
        {
            SampledDate = Sample;
        }
        public void AddWineNotes(string Notes)
        {
            WineNotes = Notes;
        }

        #endregion

        #region Constructor

        public WineInformation()
        {
            WineIDNumber = ++lastIDNumber;
            RecordedDate = DateTime.UtcNow;

        }
        #endregion
    }
}
