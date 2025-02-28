string season = Console.ReadLine();
string accomodationType = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

int price = 0;
double multiplier  = 1;
if (season == "Spring")
{
    multiplier = 0.8;
    if (accomodationType == "Hotel")
    {
        price = 30;

    }
    else
    {
        price = 10;
    }
}
else if (season == "Summer")
{
    if (accomodationType == "Hotel") 
    {
        price = 50;
    }
    else
    {
        price = 30;
    }
    
}
else if (season == "Autumn") 
{
    multiplier = 0.7;
    if(accomodationType == "Hotel") 
    {
        price = 20;
    }
    else
    {
        price = 15;
    }
}
else 
{
    multiplier = 0.9;
    if (accomodationType == "Hotel") 
    {
        price = 40;
    }
    else 
    {
        price = 10;
    }
}
double totalPrice  = (price * days) *  multiplier;
Console.WriteLine($"{totalPrice:F2}");