using System;
using UnityEngine;

[Serializable]
public class Truck
{
    [SerializeField] private float velocity;
    [SerializeField] private int capacity;
    [SerializeField] private Coordinate position;

    public void setNewVelocity(float newVelocity)
    {
        velocity = velocity + newVelocity;
    }

    public float getVelocity()
    {
        return velocity;
    }

    public Vector3 getPosition()
    {
        return new Vector3(position.getX(), 0, position.getY());
    }
}