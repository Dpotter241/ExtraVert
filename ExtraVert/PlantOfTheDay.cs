public class PlantOfTheDay
{
    public static void ShowPlantOfTheDay(List<Plant> plants, Random random)
    {
        Console.Clear();
        Plant selectedPlant = null;

        while (selectedPlant == null)
        {
            int randomIndex = random.Next(plants.Count);
            Plant plant = plants[randomIndex];
            if (!plant.Sold)
            {
                selectedPlant = plant;
            }
        }

        Console.WriteLine("Plant of the Day:");
        Console.WriteLine($"Species: {selectedPlant.Species}");
        Console.WriteLine($"Location: {selectedPlant.City}");
        Console.WriteLine($"Light Needs: {selectedPlant.LightNeeds}");
        Console.WriteLine($"Price: {selectedPlant.AskingPrice} dollars");
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }
}