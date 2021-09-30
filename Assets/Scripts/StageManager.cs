using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    public static int index = 0;

    void Start()
    {
        Index();
    }

    void Index()
    {
        index = SceneManager.GetActiveScene().buildIndex;
    }

    public static int GetIndex()
    {
        return index;
    }
}