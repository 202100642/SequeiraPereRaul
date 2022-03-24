using System;
using UnityEngine;

[Serializable]
public class Truck
{
    [SerializeField] private float velocity;
    [SerializeField] private int capacity;

    public void setNewVelocity(float newVelocity)
    {
        velocity = velocity + newVelocity;
    }

    public float getVelocity()
    {
        return velocity;
    }
}