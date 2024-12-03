// See https://aka.ms/new-console-template for more information
public class Concert
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public string AvailableSeats { get; set; }
}

public class Ticket
{
    public string Concert { get; set; }
    public int Price { get; set; }
    public int SeatNumber { get; set; }

    public void rezerwacjaBiletu()
    {
        Console.WriteLine($"Użytkownik zarezerowal miejsce: {SeatNumber}");
    }
}



internal class Program
{
    public static void Main(string[] args)
    {
        Concert koncert = new Concert
        {
            Name = "Clout Festival",
            Date = new DateTime(2019, 12, 10),
            Location = "Warszawa",
            AvailableSeats = "100"
        };
    }
}