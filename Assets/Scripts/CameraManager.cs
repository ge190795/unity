using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform sphere;        //�ʒu�������I�u�W�F�N�g�ŎQ��

    // Update is called once per frame
    void Update()
    {
        //�擾�����ʒu��񂩂�w�蕪�J�����𗣂�
        var adjustment = new Vector3(0.0f, 3.0f, -3.0f);
        GetComponent<Transform>().position = sphere.position + adjustment;
    }
}
