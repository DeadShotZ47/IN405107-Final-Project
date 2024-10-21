using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleSpawner : MonoBehaviour
{
    public GameObject eaglePrefab;
    public Transform player;
    public float minSpawnTime = 2f;
    public float maxSpawnTime = 5f;
    public float yMin = -1f;
    public float yMax = 5f;

    void Start()
    {
        StartCoroutine(SpawnEagle());
    }

    IEnumerator SpawnEagle()
    {
        while (true)
        {
            // สุ่มเวลาเกิดของนก
            float spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(spawnTime);

            // สุ่มตำแหน่งแกน y และตำแหน่งขอบซ้ายหรือขวาของจอ
            float spawnY = Random.Range(yMin, yMax);
            bool spawnLeft = Random.value > 0.5f;

            Vector3 spawnPosition;

            if (spawnLeft)
            {
                spawnPosition = new Vector3(player.position.x - 15f, spawnY, 0); // นกเกิดจากด้านซ้าย
            }
            else
            {
                spawnPosition = new Vector3(player.position.x + 15f, spawnY, 0); // นกเกิดจากด้านขวา
            }

            // สร้างนก
            Instantiate(eaglePrefab, spawnPosition, Quaternion.identity);
        }
    }
}
