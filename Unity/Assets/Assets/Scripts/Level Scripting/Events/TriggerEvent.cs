using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class TriggerEvent : MonoBehaviour , ITriggerEvents 
{
    // TODO: Foldouts to hide these events
    public UnityEvent onEnter;
    public UnityEvent onStay;
    public UnityEvent onExit;

    public event ColliderHandler Incident;

    private Collider _collider;

    void Awake()
    {
        _collider = GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (Incident != null)
        {
            Incident(_collider, other, ColliderEventState.ENTER);
        }

        onEnter.Invoke();
    }

    void OnTriggerStay(Collider other)
    {
        if (Incident != null)
        {
            Incident(_collider, other, ColliderEventState.STAY);
        }

        onStay.Invoke();
    }

    void OnTriggerExit(Collider other)
    {
        if (Incident != null)
        {
            Incident(_collider, other, ColliderEventState.EXIT);
        }

        onExit.Invoke();
    }
}
