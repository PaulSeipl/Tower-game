using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarController : MonoBehaviour
{
    private static Transform redBar;
    private void Start()
    {
        redBar = transform.Find("Bar");
    }

    public static void SetSize(float sizeNormalized) {
        //redBar.localScale = new Vector3(sizeNormalized, 1f);

        Debug.Log("Ich bin drin");
    }
}
