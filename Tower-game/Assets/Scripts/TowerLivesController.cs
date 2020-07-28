using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLivesController : MonoBehaviour
{

    public int towerLives;
    public GameObject explosion1;
    public GameObject explosion2;
    public Sprite MidLife;
    public Sprite LowLife;
    private int maxTowerLives;
    private SpriteRenderer spriteRenderer;

    private void Start() {
        maxTowerLives = towerLives;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {

        float normalizedHealth = (float) towerLives/ (float) maxTowerLives;
        Debug.Log(normalizedHealth);
        HealthBarController.SetSize(normalizedHealth);

        if (towerLives <= 0) {
            Instantiate(explosion1, transform.position, Quaternion.identity);
            Instantiate(explosion2, transform.position, Quaternion.identity);

            FindObjectOfType<AudioManager>().Stop("Theme");
            FindObjectOfType<AudioManager>().Play("Tower Explosion");
            Destroy(gameObject);
        } else if (towerLives <= maxTowerLives * 0.3) {
            spriteRenderer.sprite = LowLife;
        } else if (towerLives <= maxTowerLives * 0.6) {
            spriteRenderer.sprite = MidLife;
        }
    }
    
}
