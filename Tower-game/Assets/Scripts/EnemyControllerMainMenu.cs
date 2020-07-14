using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControllerMainMenu : MonoBehaviour
{


    public GameObject EndPoint;
    private bool isMovingRight;
    public float movingSpeed;
    void Start()
    {
        if (EndPoint.transform.position.x < transform.position.x) {
            isMovingRight = false;
        } else {
            isMovingRight = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isMovingRight) {
            transform.Translate(2 * Time.deltaTime * movingSpeed, 0,0);

            if (EndPoint.transform.position.x < transform.position.x) {
                Destroy(gameObject);
            }

        } else {
            transform.Translate(-2 * Time.deltaTime * movingSpeed, 0,0);

            if (EndPoint.transform.position.x > transform.position.x) {
                Destroy(gameObject);
            }
        }

        
    }
}
