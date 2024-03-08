using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelThreePrologue : MonoBehaviour
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
            switch (subSequence)
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
        audioSource.PlayOneShot(prologue);
        subtitle.text = "Welcome to your second adventure";
        timer = 2f;
        subSequence++;
    }

    private void secondSubtitle()
    {
        subtitle.text = "You have made a wonderful performance in the 2nd level.";
        timer = 3f;
        subSequence++;
    }

    private void thirdSubtitle()
    {
        subtitle.text = "This level is about investments in banks,\nand you will be given some amount of money to invest with it.";
        timer = 7f;
        subSequence++;
    }

    private void fourthSubtitle()
    {
        subtitle.text = "Mission: You have a newborn child, and your objective is to invest this amount of money for 3 years\nwith 0 risk to, fulfill some of the future school fees.";
        timer = 12f;
        subSequence++;
    }

    private void nextScene()
    {
        SceneLoader.setIsLevelCompleted(true);
    }
}
