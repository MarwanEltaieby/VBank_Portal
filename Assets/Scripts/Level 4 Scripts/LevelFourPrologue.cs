using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelFourPrologue : MonoBehaviour
{
    [SerializeField] private Text subtitle;
    private float timer = 3f;
    private int subSequence;
    private AudioSource audioSource;
    [SerializeField] private AudioClip prologue;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            switch(subSequence)
            {
                case 0:
                    firstSubtitle();
                    break;

                case 1:
                    secondSubtitle();
                    break;

                case 2:
                    thirdSubtitle();
                    break;

                case 3:
                    fourthSubtitle();
                    break;

                case 4:
                    nextScene();
                    break;                
            }
        }
    }

    private void firstSubtitle()
    {
        //prologue
        audioSource.PlayOneShot(prologue);
        subtitle.text = "Hello and welcome again.";
        subSequence++;
        timer = 2f;
    }

    private void secondSubtitle()
    {
        subtitle.text = "2 years have passed since you bonded your certificate\nand you made quite some money in your account.";
        subSequence++;
        timer = 5f;
    }

    private void thirdSubtitle()
    {
        subtitle.text = "Unfortunately, your wife made a car accident,\nand you need to restore your money to treat her!";
        subSequence++;
        timer = 7f;
    }

    private void fourthSubtitle()
    {
        subtitle.text = "Mission: Break the certificate and withdraw 30,000 LE to treat your wife!";
        subSequence++;
        timer = 5f;
    }

    private void nextScene()
    {
        SceneLoader.setIsLevelCompleted(true);
    }
}
