using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLivesController : MonoBehaviour
{

    public int towerLives;
    public GameObject explosion1;
    public GameObject explosion2;
    private int maxTowerLives;

    private void Start() {
        maxTowerLives = towerLives;
    }
    void Update()
    {

        float normalizedHealth = (float) towerLives/ (float) maxTowerLives;
        Debug.Log(normalizedHealth);
        HealthBarController.SetSize(normalizedHealth);

        if (towerLives <= 0) {

            Instantiate(explosion1, transform.position, Quaternion.identity);
            Instantiate(explosion2, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    
}
