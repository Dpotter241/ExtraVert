public class MainMenu
{
    public static void ShowMenu(List<Plant> plants)
    {
        string choice = "";
        while (choice != "8")
        {
            Console.Clear();
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Display all plants");
            Console.WriteLine("2. Post a plant to be adopted");
            Console.WriteLine("3. Adopt a plant");
            Console.WriteLine("4. Delist a plant");
            Console.WriteLine("5. Plant of the Day");
            Console.WriteLine("6. Search plants by light needs");
            Console.WriteLine("7. View app statistics");
            Console.WriteLine("8. Exit");

            Console.Write("Please choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                PlantDisplay.DisplayAllPlants(plants);
            }
            else if (choice == "2")
            {
                PlantActions.PostAPlant(plants);
            }
            else if (choice == "3")
            {
                PlantActions.AdoptAPlant(plants);
            }
            else if (choice == "4")
            {
                PlantActions.DelistAPlant(plants);
            }
            else if (choice == "5")
            {
                PlantOfTheDay.ShowPlantOfTheDay(plants, new Random());
            }
            else if (choice == "6")
            {
                PlantSearch.SearchByLightNeeds(plants);
            }
            else if (choice == "7")
            {
                PlantStats.DisplayStats(plants);
            }
            else if (choice == "8")
            {
                Console.WriteLine("Thank you for using the Plant Store. Goodbye!");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();
            }
        }
    }
}