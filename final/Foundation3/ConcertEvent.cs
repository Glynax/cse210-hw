class ConcertEvent : Event
{
    private string artistName;

    public ConcertEvent(string eventName, DateTime eventDate, Address eventAddress, string artistName) 
        : base(eventName, eventDate, eventAddress)
    {
        this.artistName = artistName;
    }

    public override string GetEventMessage()
    {
        return $"Don't miss the {artistName} concert at the {eventName} on {eventDate.ToString("MMMM dd, yyyy")} at {eventAddress.GetAddressString()}!";
    }
}
