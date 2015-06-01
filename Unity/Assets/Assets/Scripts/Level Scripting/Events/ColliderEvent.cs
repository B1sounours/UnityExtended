using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class ColliderEvent : MonoBehaviour, IColliderEvents
{
    // TODO: Foldouts to hide these events
    public UnityEvent onEnter;
    public UnityEvent onStay;
    public UnityEvent onExit;

    public event CollisionHandler Incident;

    private Collider _collider;

    void Awake()
    {
        _collider = GetComponent<Collider>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (Incident != null)
        {
            Incident(_collider, other, ColliderEventState.ENTER);
        }

        onEnter.Invoke();
    }

    void OnCollisionStay(Collision other)
    {
        if (Incident != null)
        {
            Incident(_collider, other, ColliderEventState.STAY);
        }

        onStay.Invoke();
    }

    void OnCollisionExit(Collision other)
    {
        if (Incident != null)
        {
            Incident(_collider, other, ColliderEventState.EXIT);
        }

        onExit.Invoke();
    }
}
