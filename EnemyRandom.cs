using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandom : MonoBehaviour
{
    public float speed = 8.0f;
    private Vector3 targetPosition;

    void Start()
    {
        targetPosition = GetRandomPosition();
    }

    void Update()
    {
        if (transform.position == targetPosition)
        {
            targetPosition = GetRandomPosition();
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    private Vector3 GetRandomPosition()
    {
        float randomX = Random.Range(-5f, 5f);
        float randomY = Random.Range(-5f, 5f);
        return new Vector3(randomX, randomY, 0f);
    }
}

