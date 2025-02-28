int hourOfTheDay = int.Parse(Console.ReadLine());
string dayOfTheWeek = Console.ReadLine();

if (hourOfTheDay >= 10 && hourOfTheDay <= 18 &&
    (dayOfTheWeek == "Monday" || dayOfTheWeek == "Tuesday" || dayOfTheWeek == "Wednesday" || dayOfTheWeek == "Thursday" || dayOfTheWeek == "Friday" || dayOfTheWeek == "Saturday"))
{
    Console.WriteLine("open");
}
else
{
    Console.WriteLine("closed");
}