using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenginHit : MonoBehaviour
{

    public int energy = 1;
    public GameObject exposion;


    // Start is called before the first frame update
    void Start()
    {

    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        
        // タグが同じ場合は衝突させない
        if (tag == collider.gameObject.tag) 
        {
            return;
        }
        // 体力を減らす
        energy--;
        // 体力が無くなった場合
        if (energy <= 0)
        {
            // 自分を削除
            Instantiate(exposion,transform.position,transform.rotation);
            Destroy(gameObject);

        }
    }
}

