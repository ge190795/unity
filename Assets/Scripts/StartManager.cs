using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public int index = 3;
    public int stage = 2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (index < stage + 2)
            {
                index = index + 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (index > 3)
            {
                index = index - 1;
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CangeScene();
        }
    }

    void CangeScene()
    {
        SceneManager.LoadScene(index);
    }

    public int GetIndex()
    {
        return index;
    }
}