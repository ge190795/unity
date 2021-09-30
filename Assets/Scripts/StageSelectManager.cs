using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSelectManager : MonoBehaviour
{
    public StartManager startmanager;
    // スコアを表示する
    public Text stageText;

    private int stage = 0;

    void Start()
    {
        Initialize();
    }

    void Update()
    {

        stage = startmanager.GetIndex() - 2;

        // スコア・ハイスコアを表示する
        stageText.text = stage.ToString();
    }


    // ゲーム開始前の状態に戻す
    private void Initialize()
    {
        // 1に戻す
        stage = 1;
    }


}
