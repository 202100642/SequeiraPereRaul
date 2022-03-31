using System;
using UnityEngine;


[Serializable]
public class Coordinate
{
    [SerializeField] private float XCoordinate;
    [SerializeField] private float YCoordinate;

    public float getX()
    {
        return XCoordinate;
    }

    public float getY()
    {
        return YCoordinate;
    }
}
