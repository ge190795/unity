using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform sphere;        //位置情報を球オブジェクトで参照

    // Update is called once per frame
    void Update()
    {
        //取得した位置情報から指定分カメラを離す
        var adjustment = new Vector3(0.0f, 3.0f, -3.0f);
        GetComponent<Transform>().position = sphere.position + adjustment;
    }
}
