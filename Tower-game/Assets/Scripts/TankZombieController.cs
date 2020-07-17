﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankZombieController : MonoBehaviour
{

    public float movingSpeed;
    public GameObject Tower;
    private TowerLivesController towerLives;
    public int lives;
    public int damage;
    private float timeBtwAttac;
    private float startTimeBtwAttac = 1;
    public GameObject onDestroyAnimation;
    private bool isMovingRight;
    private bool isRunning;
    private bool touchedTower = false;
    private float xScale;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {

        xScale = transform.localScale.x;
        isRunning = true;
        if (Tower.transform.position.x < transform.position.x) {
            isMovingRight = false;

            Vector3 theScale = transform.localScale;
            theScale.x = -xScale;
            transform.localScale = theScale;
        } else {
            isMovingRight = true;
        }

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMovingRight) {
            if (isRunning) {
                transform.Translate(2 * Time.deltaTime * movingSpeed, 0,0);
            }
        } else {
            if (isRunning) {
                transform.Translate(-2 * Time.deltaTime * movingSpeed, 0,0);
            }
        }

        if (!isRunning) {

                if (timeBtwAttac <= 0) {
                    towerLives.towerLives -= damage;
                    timeBtwAttac = startTimeBtwAttac;
                } else {
                    timeBtwAttac -= Time.deltaTime;
                }

            }

        if (lives <= 0) {
            Instantiate(onDestroyAnimation, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag.Equals("Tower")) {
            if (touchedTower) {
                isRunning = false;
                towerLives = other.gameObject.GetComponent<TowerLivesController>();
            } else {
                touchedTower = true;
                anim.SetBool("isRunning", false);
            }
        }
    }
}