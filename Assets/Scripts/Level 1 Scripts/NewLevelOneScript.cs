using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewLevelOneScript : MonoBehaviour
{
    private float timer = 3f;
    private int subSequence = 0;
    private int rightSub = 0;
    private int wrongSubOne = 0;
    private int wrongSubTwo = 0;
    private int choiceSequence = 0;
    private bool isMiddleMovePoint;
    [SerializeField] private Text subtitle;
    [SerializeField] private Text congratulationsText;
    [SerializeField] private GameObject customerServiceMovePoint;
    [SerializeField] private GameObject tellersMovePoint;
    [SerializeField] private GameObject reciptionMovePoint;
    [SerializeField] private GameObject middleMovePoint;
    [SerializeField] private GameObject goToCustomerServiceChoice;
    [SerializeField] private GameObject goToTellersChoice;
    [SerializeField] private GameObject goToReciptionChoice;
    private AudioSource audioSource;
    private bool playAudio = true;

    //Audio Refrences
    [SerializeField] private AudioClip asisstant_1;
    [SerializeField] private AudioClip cs_1;
    [SerializeField] private AudioClip asisstant_2;
    [SerializeField] private AudioClip tellers_1;
    [SerializeField] private AudioClip asisstant_3;
    [SerializeField] private AudioClip reciption_1;
    [SerializeField] private AudioClip asisstant_4;
    [SerializeField] private AudioClip congratulations;


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
                    firstSubSequence();
                    break;

                case 1:
                    secondSubSequence();
                    break;

                case 2:
                    thirdSubSequence();
                    break;

                case 3:
                    fourthSubSequence();
                    break;

                case 4:
                    fifthSubSequence();
                    break;

                case 5:
                    sixthSubSequence();
                    break;

                case 6:
                    seventhSubSequence();
                    break;

                case 7:
                    eighthSubSequence();
                    break;

                case 8:
                    ninthSubSequence();
                    break;

                case 9:
                    tenthSubSequence();
                    break;

                case 10:
                    congratsSubSequence();
                    break;

                case 11:
                    nextLevelSequence();
                    break;
            }
        }

    }

    private void firstSubSequence()
    {
        subtitle.text = "Assistant: Welcome to VBank Portal!";
        subSequence++;
        timer = 2.5f;
        audioSource.PlayOneShot(asisstant_1);
    }
    private void secondSubSequence()
    {
        subtitle.text = "Assistant: I am going to be your assistant to help you learn\nabout banking and its investments.";
        subSequence++;
        timer = 5f;
    }

    private void thirdSubSequence()
    {
        subtitle.text = "Assistant: Let us explore the different departments that we can interact with.";
        subSequence++;
        timer = 4f;
    }

    private void fourthSubSequence()
    {
        if (Choices.getChoice() == 0)
        {
            subtitle.text = "Assistant: Please go to the Customer Service!";
            goToCustomerServiceChoice.SetActive(true);
        }
        else if (Choices.getChoice() == 1)
        {
            goToCustomerServiceChoice.SetActive(false);
            if (!isMiddleMovePoint)
            {
                MoveToPoint.moveTo(this.gameObject, middleMovePoint, 5f);
            }
            else if (isMiddleMovePoint)
            {
                MoveToPoint.moveTo(this.gameObject, customerServiceMovePoint, 5f);
            }

        }
        
        if (this.transform.position.x == middleMovePoint.transform.position.x && this.transform.position.z == middleMovePoint.transform.position.z)
        {
            isMiddleMovePoint = true;
        }

        if (this.transform.position.x == customerServiceMovePoint.transform.position.x && this.transform.position.z == customerServiceMovePoint.transform.position.z)
        {
            Choices.setChoice(0);
            subSequence++;
            isMiddleMovePoint = false;
        }
    }

    private void fifthSubSequence()
    {
        subtitle.text = "Customer Service: Hello sir, in here most of the bank's transactions are done from\n opening an account, inquiries and investments." +
                " I will be at your service whenever you want";
        subSequence++;
        timer = 11f;
        audioSource.PlayOneShot(cs_1);
    }

    private void sixthSubSequence()
    {
        if (Choices.getChoice() == 0)
        {
            if (playAudio)
            {
                audioSource.PlayOneShot(asisstant_2);
                playAudio = false;
            }
            subtitle.text = "Assistant: Now let us explore the tellers.";
            goToTellersChoice.SetActive(true);
        }
        else if (Choices.getChoice() == 1)
        {
            playAudio = true;
            goToTellersChoice.SetActive(false);

            if (!isMiddleMovePoint)
            {
                MoveToPoint.moveTo(this.gameObject, middleMovePoint, 5f);
            }
            else if (isMiddleMovePoint)
            {
                MoveToPoint.moveTo(this.gameObject, tellersMovePoint, 5f);
            }
        }
        if (this.transform.position.x == middleMovePoint.transform.position.x && this.transform.position.z == middleMovePoint.transform.position.z)
        {
            isMiddleMovePoint = true;
        }

        if (this.transform.position.x == tellersMovePoint.transform.position.x && this.transform.position.z == tellersMovePoint.transform.position.z)
        {
            Choices.setChoice(0);
            subSequence++;
            isMiddleMovePoint = false;
        }
    }

    private void seventhSubSequence()
    {
        subtitle.text = "Tellers: Hello sir, here you can withdraw and deposit into your account whenever you want.";
        audioSource.PlayOneShot(tellers_1);
        timer = 6f;
        subSequence++;
    }

    private void eighthSubSequence()
    {
        if (Choices.getChoice() == 0)
        {
            if (playAudio)
            {
                audioSource.PlayOneShot(asisstant_3);
                playAudio = false;
            }
            subtitle.text = "Assistant: Now let us explore the reciption.";
            goToReciptionChoice.SetActive(true);
        }
        else if (Choices.getChoice() == 1)
        {
            playAudio = true;
            goToReciptionChoice.SetActive(false);

            if (!isMiddleMovePoint)
            {
                MoveToPoint.moveTo(this.gameObject, middleMovePoint, 5f);
            }
            else if (isMiddleMovePoint)
            {
                MoveToPoint.moveTo(this.gameObject, reciptionMovePoint, 5f);
            }
        }

        if (this.transform.position.x == middleMovePoint.transform.position.x && this.transform.position.z == middleMovePoint.transform.position.z)
        {
            isMiddleMovePoint = true;
        }

        if (this.transform.position.x == reciptionMovePoint.transform.position.x && this.transform.position.z == reciptionMovePoint.transform.position.z)
        {
            Choices.setChoice(0);
            subSequence++;
            isMiddleMovePoint = false;
        }
    }

    private void ninthSubSequence()
    {
        subtitle.text = "Receptionist: Hello sir, here you can receive your cards\n and collect checks whenever you want.";
        audioSource.PlayOneShot(reciption_1);
        subSequence++;
        timer = 6f;
    }

    private void tenthSubSequence()
    {
        subtitle.text = "Assistant: Congratulations! You are now familiar with the different departments\n that we can deal with in the bank.";
        audioSource.PlayOneShot(asisstant_4);
        subSequence++;
        timer = 6f;
    }

    private void congratsSubSequence()
    {
        subtitle.gameObject.SetActive(false);
        congratulationsText.gameObject.SetActive(true);
        congratulationsText.text = "Congratulations Level 1 Complete";
        audioSource.PlayOneShot(congratulations);
        timer = 2f;
        subSequence++;
    }

    private void nextLevelSequence()
    {
        SceneLoader.setIsLevelCompleted(true);
    }
}
