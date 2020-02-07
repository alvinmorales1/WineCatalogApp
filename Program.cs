using System;

namespace WineCatalogApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myNewWine = WineCatalog.AddWineToList("Troublemaker", "Adam West Winery",2017, "Red Blend", "Paso Robles California", 17.99, "1 / 20 / 2020", "plum, leather, long finish");
            Console.WriteLine($"WineID:{myNewWine.WineIDNumber},WineName:{myNewWine.WineName},WineryName:{myNewWine.WineryName},Vintange:{myNewWine.Vintange},Varietal:{myNewWine.WineVarietals},Price:{myNewWine.WinePrice},Sampled Date:{myNewWine.SampledDate},Notes:{myNewWine.WineNotes}");

            Console.Writeline("**********************************************************************");
            Console.Writeline("Welcome to the Wine entry App");
            Console.Writeline("0.Exit");
            Console.Writeline("1.Add");
            Console.Writeline("2.Update");
            Console.Writeline("3.Add Comment");

            Console.Write("Please select an option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "0":
                    Console.WriteLine("Thanks you for visiting the Wine App");
                    return;
                case "1":
                    Console.Write("Wine Name");
                    var wineName = Console.ReadLine();
                    Console.Write("Winery");
                    var winery = Console.ReadLine();
                    Console.Write("Vintange");
                    var vintg = Console.ReadLine();
                    Console.Write("Type of Grape");
                    var variat = Console.ReadLine();
                    Console.Write("Region");
                    var Region = Console.ReadLine();
                    Console.Write("Price");
                    var price = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Sampled Date");
                    var sampDate = Console.ReadLine();
                    Console.Write("Notes");
                    var notes = Console.ReadLine();
                    
                case "3":
                default:
                    Console.WriteLine("Invalid option - try again!!");
                    break;
                
            }
        }
    }

}
