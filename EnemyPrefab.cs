using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPrefab : MonoBehaviour, IFeEnemy
{
    public GameObject enemyPrefab;


    void Start()
    {
        // formを繰り返す
        InvokeRepeating("form",1.5f,0.8f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void form()
    {
        Vector3 formPosition = new Vector3(
            transform.position.x,
            Random.Range(-3.5f, 4f),
            transform.position.z);
        // 敵の自動生成
        Instantiate(enemyPrefab,formPosition,transform.rotation);
    }
}
