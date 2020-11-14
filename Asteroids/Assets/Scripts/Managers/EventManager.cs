using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    private static  EventManager eventManager;
    public static EventManager Instance => eventManager;

    private void Awake()
    {
        eventManager = this;
    }

    public UnityEvent ShipDie = new UnityEvent();
}
