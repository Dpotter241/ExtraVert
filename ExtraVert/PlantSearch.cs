public class PlantSearch
{
    public static void SearchByLightNeeds(List<Plant> plants)
    {
        Console.Clear();
        Console.Write("Enter the maximum light needs level (1-5): ");
        int maxLightNeeds = int.Parse(Console.ReadLine());

        List<Plant> matchingPlants = new List<Plant>();

        foreach (var plant in plants)
        {
            if (plant.LightNeeds <= maxLightNeeds)
            {
                matchingPlants.Add(plant);
            }
        }

        if (matchingPlants.Count > 0)
        {
            Console.WriteLine("Plants with light needs at or below your specified level:");
            for (int i = 0; i < matchingPlants.Count; i++)
            {
                var plant = matchingPlants[i];
                string availability = plant.Sold ? "was sold" : "is available";
                Console.WriteLine($"{i + 1}. {plant.Species} in {plant.City} {availability} for {plant.AskingPrice} dollars");
            }
        }
        else
        {
            Console.WriteLine("No plants match your light needs.");
        }

        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }
}