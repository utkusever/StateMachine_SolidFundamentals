public class HealthEvents : HealthEventsSubject
{
    private float currentHealth;
    private float tempHealth;

    public void CheckHealth(float value)
    {
        currentHealth = value;
        if (currentHealth < tempHealth)
        {
            base.NotifyObservers(-value);
            print("took dmg");
        }

        if (currentHealth > tempHealth)
        {
            base.NotifyObservers(value);
            print("healed");
        }

        tempHealth = currentHealth;
    }
}