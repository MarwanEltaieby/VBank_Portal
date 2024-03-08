using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTwoProlouge : MonoBehaviour
{
    [SerializeField] private Text subtitle;
    private float timer = 3f;
    private bool firstSubtitle = false;
    private bool secondSubtitle = false;
    private bool thirdSubtitle = false;
    private bool fourthSubtitle = false;
    private AudioSource audioSource;
    [SerializeField] AudioClip prologue;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        // Timer countdown
        timer -= Time.deltaTime;
        // Condition for timer when it reaches 0    
        if (timer <= 0)
        {
            // Checking if the second subtitle was up or not
            if (!firstSubtitle)
            {
                firstSubtitleSequence();
            }
            else if (!secondSubtitle)
            {
                secondSubtitleSequence();
            } 
            else if (!thirdSubtitle)
            {
                thirdSubtitleSequence();
            } 
            else if (!fourthSubtitle) 
            {
                fourthSubtitleSequence();
            }
        }
    }

    private void firstSubtitleSequence()
    {
        subtitle.text = "Congratulations on passing level 1 and welcome to your 1st adventure.";
        firstSubtitle = true;
        audioSource.PlayOneShot(prologue);
        timer = 5f;
    }

    private void secondSubtitleSequence()
    {
        subtitle.text = "You are a university student, you have been working\nas a part timer and you got some decent amount of money";
        secondSubtitle = true;
        timer = 7f;
    }

    private void thirdSubtitleSequence()
    {
        subtitle.text = "You now want to keep this amount of money in the bank";
        thirdSubtitle = true;
        timer = 3.5f;
    }

    private void fourthSubtitleSequence()
    {
        subtitle.text = "Let's see what we can do now.";
        SceneLoader.setIsLevelCompleted(true);
    }
}
