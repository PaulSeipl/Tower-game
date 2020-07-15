using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    // Start is called before the first frame update

    public float offset;
    public Transform shootingPoint;
    public GameObject bullet;
    private float scaleY;
    private float timeBtwShots;
    public float startTimeBtwShots;
    public float shootingSpeed;

    void Start()
    {
        scaleY = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x < transform.position.x) {

            Vector3 theScale = transform.localScale;
            theScale.y = -scaleY;
            transform.localScale = theScale;
        } else {
            
            Vector3 theScale = transform.localScale;
            theScale.y = scaleY;
            transform.localScale = theScale;
        }
        
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ + offset);

        if (timeBtwShots <= 0) {
            if (Input.GetMouseButtonDown(0)) {
                shoot();
            }
        } else {
            timeBtwShots -= Time.deltaTime;
        }
    }

    private void shoot() {
        GameObject firedBullet = Instantiate(bullet, shootingPoint.position, transform.rotation);
                firedBullet.GetComponent<Rigidbody2D>().velocity = shootingPoint.right * shootingSpeed;
                timeBtwShots = startTimeBtwShots;
    }
}
