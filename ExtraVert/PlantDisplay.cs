public class PlantDisplay
{
    public static void DisplayAllPlants(List<Plant> plants)
    {
        DateTime now = DateTime.Now;
        for (int i = 0; i < plants.Count; i++)
        {
            var plant = plants[i];
            if (!plant.Sold && plant.AvailableUntil > now)
            {
                string availability = "is available";
                Console.WriteLine($"{i + 1}. {plant.Species} in {plant.City} {availability} for {plant.AskingPrice} dollars, available until {plant.AvailableUntil.ToShortDateString()}");
            }
        }
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }

    public static string PlantDetails(Plant plant)
{
    string availability = plant.Sold ? "was sold" : "is available";
    return $"{plant.Species} in {plant.City} {availability} for {plant.AskingPrice} dollars, available until {plant.AvailableUntil.ToShortDateString()}";
}
}