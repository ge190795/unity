using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    GameObject[] tagObjects;
    // スコアを表示する
    public Text scoreText;
    // ハイスコアを表示する
    public Text fullScoreText;

    // スコア
    protected static int score = 0;

    // ハイスコア
    protected static int fullScore = 0;

    void Start()
    {
        Initialize();
    }

    void Update()
    {
        // スコア・ハイスコアを表示する
        scoreText.text = score.ToString();
        fullScoreText.text = fullScore.ToString();
    }

    //シーン上のItemタグが付いたオブジェクトを数える
    void Check(string tagname)
    {
        tagObjects = GameObject.FindGameObjectsWithTag(tagname);
        if (tagObjects.Length == 0)
        {
            Debug.Log(tagname + "タグがついたオブジェクトはありません");
        }

        fullScore = tagObjects.Length;
    }

    // ゲーム開始前の状態に戻す
    private void Initialize()
    {
        // スコアを0に戻す
        score = 0;

        Check("Item");
    }

    // ポイントの追加
    public void AddPoint(int point)
    {
        score = score + point;
    }

    // ハイスコアの保存
    public void Save()
    {
        // ゲーム開始前の状態に戻す
        Initialize();
    }

    public static int GetScore()
    {
        score = score - 1;
        return score;
    }

    public static int GetFullScore()
    {
        return fullScore;
    }
}