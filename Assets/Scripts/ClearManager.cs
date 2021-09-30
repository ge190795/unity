using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearManager : MonoBehaviour
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
            NextScene();
        }
    }

    void NextScene()
    {
        SceneManager.LoadScene(index + 1);
    }

    void TitleScene()
    {
        SceneManager.LoadScene(0);
    }
}