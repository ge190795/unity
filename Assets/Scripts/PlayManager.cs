using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayManager : MonoBehaviour
{
    public float xSpeed = 5.0f;
    Rigidbody rb;

    void Start()
    {
        //GameObject lt = transform.Find("Inlight").gameObject;
        this.rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // ���͂�x��z�ɑ��
        float x = Input.GetAxis("Horizontal");  //���+asdw
        float z = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(x * xSpeed, 0.0f, z * xSpeed);    // �͂�ݒ�

        //�]����
        rb.AddForce(force, ForceMode.Force);
        //Debug.Log(rb.velocity.magnitude);

    }

    //���C�i���Ԍo�߂ɂ�鑬�x�ቺ�����Ȃ��j
    //�S�[���ɐG�ꂽ���Ƃ��q�iinball�j�ɓ`����

    

    //���Ă΂��
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            Debug.Log(other.gameObject.name);
        }

        if (other.gameObject.tag == "Block")
        {
            Debug.Log(other.gameObject.name);
        }

        if (other.gameObject.tag == "Goal")
        {
            Debug.Log(other.gameObject.name);
            SceneManager.LoadScene("ClearScene");
        }
    }

    void OnCollisionEnter(Collision c)
    {

        if (c.gameObject.tag == "Block")
        {
            Debug.Log(c.gameObject.name);
        }
    }
}
