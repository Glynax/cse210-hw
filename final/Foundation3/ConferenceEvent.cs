class ConferenceEvent : Event
{
    private string topic;

    public ConferenceEvent(string eventName, DateTime eventDate, Address eventAddress, string topic) 
        : base(eventName, eventDate, eventAddress)
    {
        this.topic = topic;
    }

    public override string GetEventMessage()
    {
        return $"Join us for the {eventName} conference on {eventDate.ToString("MMMM dd, yyyy")} at {eventAddress.GetAddressString()} to learn about {topic}!";
    }
}