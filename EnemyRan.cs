using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRan : MonoBehaviour
{
    public GameObject enemyPrefabCarb;
    
    void Start()
    {
        // formを繰り返す
        InvokeRepeating("formCarb",15f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void formCarb()
    {
        Vector3 formPosition = new Vector3(
            transform.position.x,
            Random.Range(-3.5f, 4f),
            transform.position.z);
        // 敵の自動生成
        Instantiate(enemyPrefabCarb,formPosition,transform.rotation);
    }
}
