using System;
using System.Collections.Generic;
using System.Text;

namespace WineCatalogApp
{
    static class WineCatalog
    {
        /// <summary>
        /// Creates a new wine in the list
        /// </summary>
        /// <param name="wineName">name of the wine</param>
        /// <param name="winery">name of the winery</param>
        /// <param name="wineVintage">year the wine was bottled</param>
        /// <param name="varietal">main grape used in the wine</param>
        /// <param name="region">where the wine was produced</param>
        /// <param name="price">whats the retail cost of the wine bottle</param>
        /// <param name="dateSampled">when was the wined sampled</param>
        /// <param name="notes">your personal wine description</param>
        /// <returns></returns>
        /// 
        
        public static WineInformation AddWineToList(string wineName, string winery, int wineVintage, string varietal, string region, double price, string notes, string dateSampled = null )
        {
            var newWine = new WineInformation
            {
                WineName = wineName,
                WineryName = winery,
                Vintange = wineVintage,
                WineVarietals = varietal,
                WineRegion = region,
                WinePrice = price,
                WineNotes = notes,
                SampledDate = dateSampled

            };

            return newWine;
        }
    }
}
