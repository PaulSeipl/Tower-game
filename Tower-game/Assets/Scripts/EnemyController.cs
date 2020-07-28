using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float movingSpeed;
    public GameObject Tower;
    public int lives;

    public GameObject onDestroyAnimation;
    private bool isMovingRight;
    private float xScale;


    // Start is called before the first frame update
    void Start()
    {

        xScale = transform.localScale.x;

        if (Tower.transform.position.x < transform.position.x) {
            isMovingRight = false;

            Vector3 theScale = transform.localScale;
            theScale.x = -xScale;
            transform.localScale = theScale;
        } else {
            isMovingRight = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isMovingRight) {
            transform.Translate(2 * Time.deltaTime * movingSpeed, 0,0);
        } else {
            transform.Translate(-2 * Time.deltaTime * movingSpeed, 0,0);
        }

        if (lives <= 0) {
            Instantiate(onDestroyAnimation, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
