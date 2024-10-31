public class PlantStats
{
    public static void DisplayStats(List<Plant> plants)
    {
        if (plants.Count == 0)
        {
            Console.WriteLine("No plants are listed in the app.");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
            return;
        }

        Plant lowestPricePlant = plants.OrderBy(p => p.AskingPrice).First();
        Plant highestLightNeedsPlant = plants.OrderByDescending(p => p.LightNeeds).First();
        int availablePlantsCount = plants.Count(p => !p.Sold && p.AvailableUntil > DateTime.Now);
        double averageLightNeeds = plants.Average(p => p.LightNeeds);
        int totalPlants = plants.Count;
        int adoptedPlantsCount = plants.Count(p => p.Sold);
        double adoptionPercentage = (double)adoptedPlantsCount / totalPlants * 100;

        Console.Clear();
        Console.WriteLine("App Statistics:");
        Console.WriteLine($"Lowest price plant: {lowestPricePlant.Species} (${lowestPricePlant.AskingPrice})");
        Console.WriteLine($"Number of plants available: {availablePlantsCount}");
        Console.WriteLine($"Plant with highest light needs: {highestLightNeedsPlant.Species} (Light needs: {highestLightNeedsPlant.LightNeeds})");
        Console.WriteLine($"Average light needs: {averageLightNeeds:F2}");
        Console.WriteLine($"Percentage of plants adopted: {adoptionPercentage:F2}%");

        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }
}