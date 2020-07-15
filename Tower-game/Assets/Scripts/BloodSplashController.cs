using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodSplashController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObject", 2);
    }

    private void DestroyObject() {
        Destroy(gameObject);
    }
    
}
