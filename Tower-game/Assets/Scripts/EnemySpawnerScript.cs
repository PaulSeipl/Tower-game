using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{

    public GameObject normalEnemy;
    public GameObject tankEnemy;
    public GameObject fastEnemy;

    private List<GameObject> enemyList = new List<GameObject>();
    Vector2 whereToSpawn;
    public float spawnRate = 2;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        enemyList.Add(normalEnemy);
        enemyList.Add(fastEnemy);
        enemyList.Add(tankEnemy);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time > nextSpawn) {
            nextSpawn = Time.time + spawnRate;
            whereToSpawn = new Vector2(transform.position.x, transform.position.y);

            int enemyIndex = (int) Random.Range(0, 3.1f);

            GameObject enemy = enemyList[enemyIndex];

            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }

    }
}
