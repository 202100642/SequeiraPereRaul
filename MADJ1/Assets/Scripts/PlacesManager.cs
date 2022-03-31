using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacesManager : MonoBehaviour
{
    [SerializeField]
    private GameObject SupplierPrefab, ShopPrefab;

    private int spawnCount;


    void Start()
    {
        Coordinate[] locals = GameManager.Instance.getLocals();
        spawnCount = 0;

        //SUPPLIES AND SHOP SPAWNER
        foreach (Coordinate coord in locals)
        {
            if (coord == null)
            {
                Debug.LogWarning("Alguma coordenada não foi inserida");
                break;
            }

            if(spawnCount < 2)
            {
                Instantiate(SupplierPrefab, new Vector3(coord.getX(), 0 , coord.getY()), Quaternion.identity);
                spawnCount++;
            }
            else Instantiate(ShopPrefab, new Vector3(coord.getX(), 0, coord.getY()), Quaternion.identity);
        }


    }
}
