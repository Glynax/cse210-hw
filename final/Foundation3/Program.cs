using System;

class Program
{
    static void Main(string[] args)
    {
        Address eventAddress = new Address("123 Main St", "Cityville", "Stateville", "12345");

        Event genericEvent = new Event("Generic Event", DateTime.Now.AddDays(7), eventAddress);
        ConcertEvent concertEvent = new ConcertEvent("Rock Concert", DateTime.Now.AddDays(14), eventAddress, "Rock Band");
        ConferenceEvent conferenceEvent = new ConferenceEvent("Tech Conference", DateTime.Now.AddDays(21), eventAddress, "Technology Trends");
        SportsEvent sportsEvent = new SportsEvent("Football Match", DateTime.Now.AddDays(28), eventAddress, "Football");

        Console.WriteLine(genericEvent.GetEventMessage());
        Console.WriteLine(concertEvent.GetEventMessage());
        Console.WriteLine(conferenceEvent.GetEventMessage());
        Console.WriteLine(sportsEvent.GetEventMessage());
    }
}