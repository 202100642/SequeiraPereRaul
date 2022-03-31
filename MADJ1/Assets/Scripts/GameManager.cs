using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private Coordinate[] locals;
    [SerializeField] private Truck playerTruck;
    [SerializeField] private List<Truck> truckList;

    [SerializeField] private GameObject playerTruckPrefab;
    [SerializeField] private GameObject truckPrefab;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("Multiple Game Managers!!!");
        }
        
    }

    private void Start()
    {
        Instantiate(playerTruckPrefab, playerTruck.getPosition(), Quaternion.identity);

        foreach(Truck truck in truckList)
        {
            if (truck == null)
            {
                Debug.LogWarning("Alguma truck não foi inserida");
                break;
            }

            Instantiate(truckPrefab, truck.getPosition(), Quaternion.identity);
        }
    }

    public Coordinate[] getLocals()
    {
        return locals;
    }

}
