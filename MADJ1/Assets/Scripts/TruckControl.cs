using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckControl : MonoBehaviour
{
    //[SerializeField] private Truck gameTruck;
    //private float newVelocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Plus) || Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            GetComponent<SceneTruck>().getGameTruck().setNewVelocity(1);
        }
        if(Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            //newVelocity -= 5;
            GetComponent<SceneTruck>().getGameTruck().setNewVelocity(-1);
            //newVelocity = 0;
        }
    }
}
