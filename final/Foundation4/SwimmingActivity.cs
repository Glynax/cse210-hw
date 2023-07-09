class SwimmingActivity : Activity
{
    private int laps;

    public SwimmingActivity(string name, int minutes, int laps) : base(name, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        double distanceKm = laps * 50 / 1000.0;
        double distanceMiles = distanceKm * 0.62;
        return distanceMiles;
    }

    public override double GetSpeed()
    {
        double distanceKm = laps * 50 / 1000.0;
        double speedKph = (distanceKm / (minutes / 60.0));
        double speedMph = speedKph * 0.621371;
        return speedMph;
    }

    public override double GetPace()
    {
        double distanceKm = laps * 50 / 1000.0;
        double paceKm = minutes / distanceKm;
        double paceMiles = paceKm * 0.621371;
        return paceMiles;
    }
}