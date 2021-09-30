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
        // 入力をxとzに代入
        float x = Input.GetAxis("Horizontal");  //矢印+asdw
        float z = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(x * xSpeed, 0.0f, z * xSpeed);    // 力を設定

        //転がす
        rb.AddForce(force, ForceMode.Force);
        //Debug.Log(rb.velocity.magnitude);

    }

    //摩擦（時間経過による速度低下が少ない）
    //ゴールに触れたことを子（inball）に伝える

    

    //二回呼ばれる
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
