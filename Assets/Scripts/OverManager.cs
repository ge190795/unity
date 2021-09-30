using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverManager : MonoBehaviour
{
    private int index = 0;

    void Start()
    {
        index = StageManager.GetIndex();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            TitleScene();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RetryScene();
        }
    }

    void RetryScene()
    {
        SceneManager.LoadScene(index);
    }

    void TitleScene()
    {
        SceneManager.LoadScene(0);
    }
}
