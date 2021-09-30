using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearSEManager : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2;
    AudioSource audioSource;

    private int score = 0;
    private int fullscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = ScoreManager.GetScore();
        fullscore = ScoreManager.GetFullScore();

        audioSource = GetComponent<AudioSource>();

        if (fullscore == score)
        {
            audioSource.PlayOneShot(sound1);
        }
        else
        {
            audioSource.PlayOneShot(sound2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}