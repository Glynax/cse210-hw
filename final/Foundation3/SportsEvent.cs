class SportsEvent : Event
{
    private string sportName;

    public SportsEvent(string eventName, DateTime eventDate, Address eventAddress, string sportName) 
        : base(eventName, eventDate, eventAddress)
    {
        this.sportName = sportName;
    }

    public override string GetEventMessage()
    {
        return $"Get ready for an exciting {sportName} match at the {eventName} on {eventDate.ToString("MMMM dd, yyyy")} at {eventAddress.GetAddressString()}!";
    }
}