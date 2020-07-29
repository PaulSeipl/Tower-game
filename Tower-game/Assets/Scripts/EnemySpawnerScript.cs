using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject normalEnemy;
    public GameObject tankEnemy;
    public GameObject fastEnemy;
    public float minWaiting = 5;
    public float maxWaiting = 10;
    public float probabilityNormal = 0.5f;
    public float probabilityFast = 0.3f;
    public float probabilityTank = 0.2f;

    private float probabilitySum;
    private List<GameObject> enemyList = new List<GameObject>();
    private Vector2 whereToSpawn;
    private float spawnRate;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        enemyList.Add(normalEnemy);
        enemyList.Add(fastEnemy);
        enemyList.Add(tankEnemy);
        spawnRate = Random.Range(minWaiting, maxWaiting);
        probabilitySum = probabilityTank + probabilityFast + probabilityNormal;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!TowerLivesController.gameOver) {
            if (Time.time > nextSpawn) {
                nextSpawn = Time.time + spawnRate;
                whereToSpawn = new Vector2(transform.position.x, transform.position.y);

                float probability = Random.Range(0, probabilitySum);

                int enemyIndex;
                if (probability <= probabilityNormal) {
                    enemyIndex = 0;
                } else if (probability < probabilityNormal + probabilityFast) {
                    enemyIndex = 1;
                } else {
                    enemyIndex = 2;
                }

                GameObject enemy = enemyList[enemyIndex];

                Instantiate(enemy, whereToSpawn, Quaternion.identity);
                spawnRate = Random.Range(minWaiting, maxWaiting);
            }
        }
    }
}
