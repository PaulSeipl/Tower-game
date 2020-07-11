using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEnemyController : MonoBehaviour {

    public float speed;

    private bool isMoveingRight = true;

    public GameObject Tower;

    void Start() {
        if (Tower.transform.position.x < transform.position.x) {
            isMoveingRight = false;
        } else {
            isMoveingRight = true;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (isMoveingRight) {
            transform.Translate(2 * Time.deltaTime * speed, 0,0);
        } else {
            transform.Translate(-2 * Time.deltaTime * speed, 0,0);
        }
    }
}
