using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarController : MonoBehaviour
{
    private static Transform redBar;
    private static float maxHealth;
    private void Start()
    {
        redBar = transform.Find("Bar");
        maxHealth = redBar.localScale.x;
    }

    public static void SetSize(float sizeNormalized) {

        Vector3 newScale = redBar.localScale;

        if (sizeNormalized <= 0) {
            newScale.x = 0;
            redBar.localScale = newScale;
        } else {
            newScale.x = maxHealth * sizeNormalized;
            redBar.localScale = newScale;
        }
        
    }
}
