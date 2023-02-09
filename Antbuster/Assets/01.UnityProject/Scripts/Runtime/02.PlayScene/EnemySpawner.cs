using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject antPrefab;
    [SerializeField]
    private float spawnTime;
    [SerializeField]
    private Transform[] wayPoints;

    private void Awake()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            GameObject ant = Instantiate(antPrefab);
            Enemy enemy = ant.GetComponent<Enemy>();

            enemy.Setup(wayPoints);

            yield return new WaitForSeconds(spawnTime);
        }
    }
}
