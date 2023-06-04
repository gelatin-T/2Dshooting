using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pengin : MonoBehaviour
{

    // public Animator anime;
    private float speed = 0.05f;
    public GameObject shotPrefab;       // 弾プレハブ
    public int maxShotCount = 20;       // 事前に弾を作成する数
    public float shotSpeed = 30;        // 弾が１秒間に進む距離
    List<GameObject> shotList;          // 弾キャッシュ（事前に作成する弾）
    int nextShotIndex = 0;              // 次に発射する弾キャッシュの位置
    const int FLASH_VIEW_FRAME = 4;     // 発射効果を継続して表示するフレーム数
    public int shotPerSec = 8;          // １秒間に発射する弾の数
    int shotFrame;                      // 前の弾を発射してからの経過フレーム数
    
    // Start is called before the first frame update
    void Start()
    {
        // カメラの後ろ位置
        Vector3 hidePos = Camera.main.transform.position - Camera.main.transform.forward;

        // 弾を事前に作成し、カメラの後ろに配置
        shotList = new List<GameObject>();
        for (int i = 0; i < maxShotCount; i++)
        {
            // プレハブから弾を作成
            shotList.Add(Instantiate(shotPrefab));
            shotList[i].transform.position = hidePos;
            // リジッドボディの加速度を指定
            Rigidbody2D rb = shotList[i].GetComponent<Rigidbody2D>();
            rb.velocity = transform.right * shotSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey("left")){
            position.x -= speed;
        }else if(Input.GetKey("right")){
            position.x += speed;
        }else if(Input.GetKey("up")){
            position.y += speed;
        }else if (Input.GetKey("down")){
            position.y -= speed;
        }

        position.x = Mathf.Clamp(position.x, -7.5f, 7.5f);
        position.y = Mathf.Clamp(position.y, -4.5f, 5f);

        transform.position = position;
    }

   void FixedUpdate(){
    int shotInterval = 50 / shotPerSec;
    // 弾発射
    shotFrame++;
    if (shotFrame >= shotInterval){
        // 次の弾待機を開始するため経過時間を初期化
        shotFrame = 0;
    }
    // 弾をプレイヤー位置に移動
    shotList[nextShotIndex].transform.position = transform.position + transform.right * 0.5f;

    // 次の弾位置
    nextShotIndex++;
    if (nextShotIndex >= maxShotCount){
        nextShotIndex = 0;
    }
  }
}
