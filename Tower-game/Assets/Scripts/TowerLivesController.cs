using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLivesController : MonoBehaviour
{

    public int towerLives;
    public GameObject explosion1;
    public GameObject explosion2;

    // Update is called once per frame
    void Update()
    {

        Debug.Log(towerLives);

        if (towerLives <= 0) {

            Instantiate(explosion1, transform.position, Quaternion.identity);
            Instantiate(explosion2, transform.position, Quaternion.identity);

            Destroy(gameObject);
        }
    }
    
}
