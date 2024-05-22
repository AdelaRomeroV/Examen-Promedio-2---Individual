using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawer : MonoBehaviour
{
    [SerializeField] private List<GameObject> enemies;
    [SerializeField] List<EnemyCollection> enemyCollections;

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
            if(collectionIndex !=0)
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
            if (collectionIndex !=2 )
            {
                index = 0;
            }
            collectionIndex = 2;
            enemies = enemyCollections[collectionIndex].Enemies;
        }
        else
        {
            totalTimer = 0;
        }
    }

    void Spawn()
    {
        timer += Time.deltaTime;
        if (timer > 0.5f)
        {
            int xPoint = Random.Range(15, -20);
            Instantiate(enemies[index], new Vector3(xPoint + xPoint, transform.position.y, 0), Quaternion.identity);
            index++;
            if(index >= enemies.Count)
            {
                index = 0;
            }
            timer = 0;
        }
    }
}
