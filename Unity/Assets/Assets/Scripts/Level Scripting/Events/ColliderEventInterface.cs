using UnityEngine;

public enum ColliderEventState
{
    ENTER,
    STAY,
    EXIT
}

public delegate void ColliderHandler(Collider sender, Collider other, ColliderEventState state);
public delegate void CollisionHandler(Collider sender, Collision collision, ColliderEventState state);

interface ITriggerEvents
{
    event ColliderHandler Incident;
}

interface IColliderEvents
{
    event CollisionHandler Incident;
}