﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public float lifeTime;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyBullet", lifeTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.EndsWith("Enemy")) {
            EnemyController enemy = other.gameObject.GetComponent<EnemyController>();
            enemy.lives = enemy.lives - damage;
            
        }

        Destroy(gameObject);
    }

    private void DestroyBullet() {
        Destroy(gameObject);
    }
}