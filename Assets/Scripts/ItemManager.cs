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

    //�����������̏������L�q
    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            //�X�R�A������ǉ�(�N���X���w��)
            FindObjectOfType<ScoreManager>().AddPoint(1);
            Destroy(gameObject);    //gameObject...���̃X�N���v�g�����Ă�I�u�W�F�N�g
        }
    }
}
