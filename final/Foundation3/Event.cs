class Event
{
    protected string eventName;
    protected DateTime eventDate;
    protected Address eventAddress;

    public Event(string eventName, DateTime eventDate, Address eventAddress)
    {
        this.eventName = eventName;
        this.eventDate = eventDate;
        this.eventAddress = eventAddress;
    }

    public virtual string GetEventMessage()
    {
        return $"Join us for the {eventName} event on {eventDate.ToString("MMMM dd, yyyy")} at {eventAddress.GetAddressString()}!";
    }
}