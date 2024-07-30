using OOP2;

class Program
{
    static void Main(string[] args)
    {
        Baby baby = new Baby();
        baby.Name = "Andrey";
        baby.Surname = "Poroşen";
        baby.DisplayBaby();

        Baby baby1 = new Baby("Ali","Haco");
    }
}