public class Plant
{
    public string Species { get; set; }
    public int LightNeeds { get; set; }
    public decimal AskingPrice { get; set; }
    public string City { get; set; }
    public string ZIP { get; set; }
    public bool Sold { get; set; }
    public DateTime AvailableUntil { get; set; }

    public Plant(string species, int lightNeeds, decimal askingPrice, string city, string zip, DateTime availableUntil, bool sold = false)
    {
        Species = species;
        LightNeeds = lightNeeds;
        AskingPrice = askingPrice;
        City = city;
        ZIP = zip;
        AvailableUntil = availableUntil;
        Sold = sold;
    }
}