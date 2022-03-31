using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTruck : MonoBehaviour
{
    [SerializeField] private Truck gameTruck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(gameTruck.getVelocity() * Time.deltaTime, 0, 0);
    }

    public Truck getGameTruck()
    {
        return gameTruck;
    }
}
