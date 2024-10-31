public class PlantActions
{
    public static void PostAPlant(List<Plant> plants)
    {
        Console.Clear();

        Console.Write("Enter the species of the plant: ");
        string species = Console.ReadLine();

        Console.Write("Enter the light needs of the plant (as an integer value): ");
        int lightNeeds = int.Parse(Console.ReadLine());

        Console.Write("Enter the asking price of the plant: ");
        decimal askingPrice = decimal.Parse(Console.ReadLine());

        Console.Write("Enter the city where the plant is located: ");
        string city = Console.ReadLine();

        Console.Write("Enter the ZIP code: ");
        string zip = Console.ReadLine();

        DateTime availableUntil;

        try
        {
            Console.Write("Enter the available until date (Year): ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Enter the available until date (Month): ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter the available until date (Day): ");
            int day = int.Parse(Console.ReadLine());

            availableUntil = new DateTime(year, month, day);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The date you entered is invalid. Please enter a valid date.");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
            return;
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid date format. Please make sure you enter numbers for the date.");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
            return;
        }

        Plant newPlant = new Plant(species, lightNeeds, askingPrice, city, zip, availableUntil);
        plants.Add(newPlant);

        Console.WriteLine("Plant has been successfully posted for adoption!");
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }

    public static void AdoptAPlant(List<Plant> plants)
    {
        Console.Clear();
    List<Plant> availablePlants = plants.Where(p => !p.Sold && p.AvailableUntil > DateTime.Now).ToList();

    if (availablePlants.Count == 0)
    {
        Console.WriteLine("No plants are available for adoption.");
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
        return;
    }

    Console.WriteLine("Available Plants for Adoption:");
    for (int i = 0; i < availablePlants.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {PlantDisplay.PlantDetails(availablePlants[i])}");

    }

        Console.Write("Please enter the number of the plant you want to adopt: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice >= 1 && choice <= availablePlants.Count)
        {
            Plant selectedPlant = availablePlants[choice - 1];
            selectedPlant.Sold = true;

            Console.WriteLine($"You have successfully adopted the {selectedPlant.Species}.");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }

        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }

    public static void DelistAPlant(List<Plant> plants)
    {
        Console.Clear();

        if (plants.Count == 0)
        {
            Console.WriteLine("No plants are available to delist.");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Plants Available for Delisting:");
        for (int i = 0; i < plants.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {plants[i].Species} in {plants[i].City} for {plants[i].AskingPrice} dollars");
        }

        Console.Write("Please enter the number of the plant you want to delist: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice >= 1 && choice <= plants.Count)
        {
            plants.RemoveAt(choice - 1);
            Console.WriteLine("Plant has been successfully delisted.");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }

        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }
}