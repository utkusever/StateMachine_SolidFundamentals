using System.Collections.Generic;
using UnityEngine;

public abstract class HealthEventsSubject : MonoBehaviour
{
    private List<IHealthObserver> healthObserversList = new();

    public void AddListener(IHealthObserver observer)
    {
        healthObserversList.Add(observer);
    }

    public void RemoveListener(IHealthObserver observer)
    {
        healthObserversList.Remove(observer);
    }

    protected virtual void NotifyObservers(float value)
    {
        foreach (var observer in healthObserversList)
        {
            observer.OnNotify(value);
        }
    }
}