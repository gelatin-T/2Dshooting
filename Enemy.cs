using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 3.0f;


    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        // 現在の座標を取得
        Vector3 pos = transform.position;

        // 進行方向に向かって直進
        pos += -transform.right * speed * Time.fixedDeltaTime;

        // 新しい座標に変更
        transform.position = pos;
    }
}
