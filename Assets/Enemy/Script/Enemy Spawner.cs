using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawer : MonoBehaviour
{
    [SerializeField] private BoxCollider spawnArea;
    [SerializeField] private List<GameObject> enemies;
    [SerializeField] private List<EnemyCollection> enemyCollections;
    [SerializeField] private float timerSpawn;
    private float timer;
    private float totalTimer;
    private int index;
    private int collectionIndex;

    private void Update()
    {
        Progression();
        Spawn();
    }
    void Progression()
    {
        totalTimer += Time.deltaTime;
        if (totalTimer <= 10)
        {
            if (collectionIndex != 0)
            {
                index = 0;
            }
            collectionIndex = 0;
            enemies = enemyCollections[collectionIndex].Enemies;
        }
        else if (totalTimer <= 20)
        {
            if (collectionIndex != 1)
            {
                index = 0;
            }
            collectionIndex = 1;
            enemies = enemyCollections[collectionIndex].Enemies;
        }
        else if (totalTimer <= 30)
        {
            if (collectionIndex != 2)
            {
                index = 0;
            }
            collectionIndex = 2;
            enemies = enemyCollections[collectionIndex].Enemies;
        }
        else { totalTimer = 0; }
    }
    void Spawn()
    {
        timer += Time.deltaTime;
        if (timer > timerSpawn)
        {
            Vector3 spawnPosition = GetRandomPositionInCollider(spawnArea);
            Instantiate(enemies[index], spawnPosition, Quaternion.identity);
            index++;
            if (index >= enemies.Count)
            {
                index = 0;
            }
            timer = 0;
        }
    }

    Vector3 GetRandomPositionInCollider(BoxCollider boxCollider)
    {
        Vector3 min = boxCollider.bounds.min;
        Vector3 max = boxCollider.bounds.max;
        float x = Random.Range(min.x, max.x);
        float y = Random.Range(min.y, max.y);
        
        return new Vector3(x, y);
    }
}
