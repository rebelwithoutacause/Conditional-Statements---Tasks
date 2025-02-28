int temperature = int.Parse(Console.ReadLine());
string partOfDay = Console.ReadLine();

string cloths = "Shirt";
string shoes = "Moccasins";

if (partOfDay == "Morning")
{
    if (temperature >= 25)
    {
        cloths = "T-Shirt";
        shoes = "Sandals";
    }
    else if (temperature > 10 && temperature <= 18)
    {
        cloths = "Sweatshirt";
        shoes = "Sneakers";
    }
}
else if (partOfDay == "Afternoon")
{
    if (temperature >= 25)
    {
        cloths = "Swim suit";
        shoes = "Barefoot";
    }
    else if (temperature > 18 && temperature <= 24)
    {
        cloths = "T-Shirt";
        shoes = "Sandals";
    }
}
else if (partOfDay == "Evening")
{
    cloths = "Shirt";
    shoes = "Moccasins";
}

Console.WriteLine($"It's {temperature} degrees, get your {cloths} and {shoes}.");
