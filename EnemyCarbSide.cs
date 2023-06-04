using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarbSide : MonoBehaviour
{

    private float speed = 3.0f;
    public float cycleCount = 1;    // １秒間に往復する回数
    public float curveLength = 2;   // カーブの最大距離
    float cycleRadian = 0;          // サインに渡す値
    float centerY;                  // Y座標の中心

    // 動きの種類
    public enum ENEMY_TYPE {
        LINE,                       // まっすぐ進む
        CURVE                       // 上下にカーブ
    }

    // 動きの種類
    public ENEMY_TYPE type = ENEMY_TYPE.CURVE;

    void Start()
    {
        // 初期Y座標を「Y座標の中心」として保存
        centerY = transform.position.y;
    }

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

        // 上下にカーブ
        if (type == ENEMY_TYPE.CURVE)
        {
            if (cycleCount > 0)
            {
                cycleRadian += (cycleCount * 2 * Mathf.PI) / 50;
                pos.y = Mathf.Sin(cycleRadian) * curveLength + centerY;
            }
        }

        // 新しい座標に変更
        transform.position = pos;
    }
}
