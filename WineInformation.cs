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
        public int WineIDNumber { get;private set; }
        public string WineName { get;set; }
        public string WineryName { get;set; }
        public int Vintange { get;set; }
        public int WineScore { get;set; }
        public string WineVarietals { get;set; }
        public string WineRegion { get;set; }
        public double WinePrice { get;set; }
        public String SampledDate { get;set; }
        public DateTime RecordedDate { get;private set; }
        public string WineNotes { get;set; }
        public string CommentsEmail { get;set; }
        public string WineComments { get;set; }
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
        public void AddWinePrice(double Price)
        {
            WinePrice = Price;
        }
        public void AddSampleDate(string Sample)
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
