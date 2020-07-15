using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLegController : MonoBehaviour
{

    private float xScale;
    void Start()
    {
        xScale = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x > transform.position.x) {
            Vector3 theScale = transform.localScale;
            theScale.y = xScale;
            transform.localScale = theScale;
            Debug.Log("Hello World");
        } else {
            Vector3 theScale = transform.localScale;
            theScale.y = -xScale;
            transform.localScale = theScale;
            Debug.Log("Hello World 2");
        }
    }
}
