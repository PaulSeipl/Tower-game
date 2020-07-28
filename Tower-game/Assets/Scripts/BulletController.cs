using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public float lifeTime;
    public int damage;
    public float HeadshotBonus = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyBullet", lifeTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("FastEnemy")) {
            FastZombieController enemy = other.gameObject.GetComponent<FastZombieController>();
            if (other.collider.GetType() == typeof(CircleCollider2D)) {
                enemy.lives = enemy.lives - HeadshotBonus * damage;
            } else {
                enemy.lives = enemy.lives - damage;
            }
        } else if (other.gameObject.tag.Equals("TankEnemy")) {
            TankZombieController enemy = other.gameObject.GetComponent<TankZombieController>();
            if (other.collider.GetType() == typeof(CircleCollider2D)) {
                enemy.lives = enemy.lives - HeadshotBonus * damage;
            } else {
                enemy.lives = enemy.lives - damage;
            }
        } else if (other.gameObject.tag.Equals("NormalEnemy")) {
            NormalZombieController enemy = other.gameObject.GetComponent<NormalZombieController>();
            if (other.collider.GetType() == typeof(CircleCollider2D)) {
                enemy.lives = enemy.lives - HeadshotBonus * damage;
            } else {
                enemy.lives = enemy.lives - damage;
            }
        }
        Destroy(gameObject);

        
    }

    private void DestroyBullet() {
        Destroy(gameObject);
    }
}
