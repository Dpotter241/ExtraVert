﻿public class Program
{
    public static void Main()
    {
        List<Plant> plants = new List<Plant>
        {
            new Plant("Ficus", 5, 15, "Pasadena", "91101", new DateTime(2024, 12, 31), true),
            new Plant("Hydrangea", 3, 25, "Walla Walla", "99362", new DateTime(2024, 10, 30), false),
            new Plant("Aloe Vera", 2, 10, "Austin", "78701", new DateTime(2024, 11, 15), false),
            new Plant("Bamboo", 4, 30, "San Diego", "92101", new DateTime(2024, 12, 25), false)
        };

        MainMenu.ShowMenu(plants);
    }
}