using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEManager : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    GameObject[] tagObjects;
    private int objects = 0;
    private int pv_objects = 0;

    // Start is called before the first frame update
    void Start()
    {
        Check("Item");
        audioSource = GetComponent<AudioSource>();
        
    }

    //シーン上のBlockタグが付いたオブジェクトを数える
    void Check(string tagname)
    {
        tagObjects = GameObject.FindGameObjectsWithTag(tagname);
        if (tagObjects.Length == 0)
        {
            Debug.Log(tagname + "タグがついたオブジェクトはありません");
        }

        pv_objects = objects;
        objects = tagObjects.Length;
    }

    // Update is called once per frame
    void Update()
    {
        Check("Item");
        if (objects< pv_objects)
        {
            audioSource.PlayOneShot(sound1);
            pv_objects = objects;
        }
    }
}
