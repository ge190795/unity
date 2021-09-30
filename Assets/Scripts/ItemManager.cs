using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //当たった時の処理を記述
    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            //スコア処理を追加(クラスを指定)
            FindObjectOfType<ScoreManager>().AddPoint(1);
            Destroy(gameObject);    //gameObject...このスクリプトがついてるオブジェクト
        }
    }
}
