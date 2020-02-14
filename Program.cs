using System;

namespace WineCatalogApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myNewWine = WineCatalog.AddWineToList("Troublemaker", "Adam West Winery",2017, "Red Blend", "Paso Robles California", 17.99, "1 / 20 / 2020", "plum, leather, long finish");
            Console.WriteLine($"WineID:{myNewWine.WineIDNumber},WineName:{myNewWine.WineName},WineryName:{myNewWine.WineryName},Vintange:{myNewWine.Vintange},Varietal:{myNewWine.WineVarietals},Price:{myNewWine.WinePrice},Sampled Date:{myNewWine.SampledDate},Notes:{myNewWine.WineNotes}");

            Console.WriteLine("**********************************************************************");
            Console.WriteLine("Welcome to the Wine entry App");

            while (true)
            {
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Update");
                Console.WriteLine("3.Show all Wines");
                Console.WriteLine("4.Add Comment");

                Console.Write("Please select an option: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thanks you for visiting the Wine App");
                        return;
                    case "1":
                        Console.Write("Wine Name:");
                        var wineName = Console.ReadLine();
                        Console.Write("Winery:");
                        var winery = Console.ReadLine();
                        Console.Write("Vintange:");
                        var vintg = Convert.ToInt32(Console.ReadLine());
                        var typeofGrapes = Enum.GetNames(typeof(TypeOfGrapes));
                        for (int i = 0; i < typeofGrapes.Length; i++)
                        {
                            Console.WriteLine($"{i}.{typeofGrapes[i]}");
                        }

                        Console.Write("Select a Type of Grape:");
                        var variat = Convert.ToString(Enum.Parse<TypeOfGrapes>(Console.ReadLine()));
                        Console.Write("Region:");
                        var Region = Console.ReadLine();
                        Console.Write("Price:");
                        var price = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Notes:");
                        var notes = Console.ReadLine();
                        Console.Write("Sampled Date:");
                        var sampDate = Console.ReadLine();

                        var myWine = WineCatalog.AddWineToList(wineName, winery, vintg, variat, Region, price, notes, sampDate);
                        
                        break;
                    case "2":
                    case "3":
                        NewMethod();
                        break;

                    case "4":
                    default:
                        Console.WriteLine("Invalid option - try again!!");
                        break;

                }
            }
        }

        private static void NewMethod()
        {
            Console.Write("Enter Wine Name:");
            var nme = Console.ReadLine();
            var targetwine = WineCatalog.GetWineByName(nme);
            foreach (var w in targetwine)
            {
                Console.WriteLine($"WineID:{w.WineIDNumber},WineName:{w.WineName},WineryName:{w.WineryName},Vintange:{w.Vintange},Varietal:{w.WineVarietals},Price:{w.WinePrice},Sampled Date:{w.SampledDate},Notes:{w.WineNotes}");
            }
        }
    }

}
