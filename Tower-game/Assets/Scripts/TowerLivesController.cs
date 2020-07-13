using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLivesController : MonoBehaviour
{

    public int towerLives;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(towerLives);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("TankEnemy")) {
            towerLives -= 5;
        }

        if (other.gameObject.tag.Equals("FastEnemy")) {
            towerLives -= 1;
        }

        if (other.gameObject.tag.Equals("NormalEnemy")) {
            towerLives -= 3;
        }

    }
    
}
