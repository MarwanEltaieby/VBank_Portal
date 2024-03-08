using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelFour : MonoBehaviour
{
    private bool playAudio1 = true;
    private bool playAudio2 = true;
    private bool playAudio3 = true;
    private bool playAudio4 = true;
    private bool isMiddleMovePoint;
    private float timer = 3f;
    private int subSequence = 0;
    private int rightSub = 0;
    private int wrongSubOne = 0;
    private int wrongSubTwo = 0;
    private int choiceSequence = 0;
    private AudioSource audioSource;
    [SerializeField] private GameObject customerServiceMovePoint;
    [SerializeField] private GameObject middleMovePoint;
    [SerializeField] private GameObject tellersMovePoint;
    [SerializeField] private Text subtitle;
    [SerializeField] private Text walletText;
    [SerializeField] private Text accountText;
    [SerializeField] private Text investmentText;
    [SerializeField] private Text congratulationText;
    [SerializeField] private GameObject firstRightChoiceOne;
    [SerializeField] private GameObject firstWrongChoiceOne;
    [SerializeField] private GameObject firstWrongChoiceTwo;
    [SerializeField] private GameObject secondChoiceOne;
    [SerializeField] private GameObject secondChoiceTwo;
    [SerializeField] private GameObject secondRightChoice;
    [SerializeField] private GameObject secondWrongChoice;
    [SerializeField] private GameObject thirdRightChoice;
    [SerializeField] private GameObject thirdWrongChoice;
    [SerializeField] private GameObject fourthRightChoice;
    [SerializeField] private GameObject fourthWrongChoice;

    //Audio Refrences
    [SerializeField] private AudioClip assistant_1;
    [SerializeField] private AudioClip assistant_2;
    [SerializeField] private AudioClip assistant_correct;
    [SerializeField] private AudioClip assistant_Q1;
    [SerializeField] private AudioClip assistant_thinkAgain;
    [SerializeField] private AudioClip assistant_treat;
    [SerializeField] private AudioClip assistant_wrongAns;
    [SerializeField] private AudioClip calc_1;
    [SerializeField] private AudioClip calc_2;
    [SerializeField] private AudioClip calc_correct;
    [SerializeField] private AudioClip calc_notRight;
    [SerializeField] private AudioClip congratulations;
    [SerializeField] private AudioClip cs_1;
    [SerializeField] private AudioClip cs_2;
    [SerializeField] private AudioClip cs_3;
    [SerializeField] private AudioClip teller_1;
    [SerializeField] private AudioClip teller_2;

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
            if (choiceSequence == 0)
            {
                switch(subSequence)
                {
                    case 0:
                        firstFirstSubtitleSequence();
                        break;

                    case 1:
                        firstSecondSubtitleSequence();
                        break;
                }
            }
            else if (choiceSequence == 1)
            {
                switch(subSequence)
                {
                    case 0:
                        secondFirstSubtitleSequence();
                        break;

                    case 1:
                        secondSecondSubtitleSequence();
                        break;

                    case 2:
                        secondThirdSubtitleSequence();
                        break;

                    case 3:
                        secondFourthSubtitleSequence();
                        break;

                    case 4:
                        secondFifthSubtitleSequence();
                        break;
                }
            }
            else if (choiceSequence == 2)
            {
                switch(subSequence)
                {
                    case 0:
                        thirdFirstSubtitleSequence();
                        break;

                    case 1:
                        thirdSecondSubtitleSequence();
                        break;

                    case 2:
                        thirdThirdSubtitleSequence();
                        break;

                    case 3:
                        thirdFourthSubtitleSequence();
                        break;
                }
            }
            else if (choiceSequence == 3)
            {
                switch(subSequence)
                {
                    case 0:
                        calcFirstSubtitle();
                        break;

                    case 1:
                        calcSecondSubtitle();
                        break;

                    case 2:
                        calcThirdSubtitle();
                        break;

                    case 3:
                        calcFourthSubtitle();
                        break;

                    case 4:
                        calcFifthSubtitle();
                        break;

                    case 5:
                        calcSixthSubtitle();
                        break;

                    case 6:
                        calcSeventhSubtitle();
                        break;

                    case 7:
                        calcEighthSubtitle();
                        break;

                    case 8:
                        calcNinthSubtitle();
                        break;

                    case 9:
                        calcTenthSubtitle();
                        break;

                    case 10:
                        congratulationsSequence();
                        break;
                }
            }
        }
    }

    private void resetAttributes()
    {
        playAudio1 = true;
        playAudio2 = true;
        playAudio3 = true;
        playAudio4 = true;
        isMiddleMovePoint = false;
        subSequence = 0;
        wrongSubOne = 0;
        wrongSubTwo = 0;
        rightSub = 0;
        Choices.setChoice(0);
    }

    private void firstFirstSubtitleSequence()
    {
        audioSource.PlayOneShot(assistant_1);
        subtitle.text = "Assistant: Welcome again, I knew about what happened to your wife and\nI am really sad to know that :(";
        subSequence++;
        timer = 6.3f;
    }

    private void firstSecondSubtitleSequence()
    {
        if (Choices.getChoice() == 0)
        {
            if (playAudio1)
            {
                audioSource.PlayOneShot(assistant_Q1);
                subtitle.text = "Assistant: Where do you think we need to go?";
                playAudio1 = false;
            }
            firstRightChoiceOne.SetActive(true);
            firstWrongChoiceOne.SetActive(true);
            firstWrongChoiceTwo.SetActive(true);
        }
        else if (Choices.getChoice() == 1)
        {
            goToCustomerServiceSequence();
        }
        else if (Choices.getChoice() == -1)
        {
            if (playAudio2)
            {
                audioSource.PlayOneShot(assistant_thinkAgain);
                subtitle.text = "Assistant: Think again!";
                playAudio2 = false;
            } 
        }
        else if (Choices.getChoice() == -2)
        {
            if (playAudio3)
            {
                audioSource.PlayOneShot(assistant_thinkAgain);
                subtitle.text = "Assistant: Think again!";
                playAudio3 = false;
            }
        }

        if (this.transform.position.x == middleMovePoint.transform.position.x && this.transform.position.z == middleMovePoint.transform.position.z)
        {
            isMiddleMovePoint = true;
        }

        if (this.transform.position.x == customerServiceMovePoint.transform.position.x && this.transform.position.z == customerServiceMovePoint.transform.position.z)
        {
            resetAttributes();
            choiceSequence++;
            audioSource.PlayOneShot(cs_1);
            subtitle.text = "Customer Service: Hello sir, How can I help you?";
        }
    }

    private void goToCustomerServiceSequence()
    {
        if (!isMiddleMovePoint)
        {
            MoveToPoint.moveTo(this.gameObject, middleMovePoint, 5f);
        }
        else if (isMiddleMovePoint)
        {
            MoveToPoint.moveTo(this.gameObject, customerServiceMovePoint, 5f);
        }

        if (playAudio4)
        {
            audioSource.PlayOneShot(assistant_correct);
            subtitle.text = "Assistant: Correct!";
            playAudio4 = false;
        }
        firstRightChoiceOne.SetActive(false);
        firstWrongChoiceOne.SetActive(false);
        firstWrongChoiceTwo.SetActive(false);
    }

    private void secondFirstSubtitleSequence()
    {
        secondChoiceOne.SetActive(true);
        if (Choices.getChoice() == 1)
        {
            secondChoiceOne.SetActive(false);
            Choices.setChoice(0);
            audioSource.PlayOneShot(cs_2);
            subtitle.text = "Customer Service: Sure, but before we proceed I need to tell you about\nyour penalty for breaking the certificate";
            subSequence++;
            timer = 6f;
        }
    }

    private void secondSecondSubtitleSequence()
    {
        subtitle.text = "Customer Service: Since your certificate was bonded for more than 6 months\nyou can break it before maturity";
        subSequence++;
        timer = 6f;
    }

    private void secondThirdSubtitleSequence()
    {
        subtitle.text = "Customer Service: But the money that was bonded with the certificate will be\ntreated as if it was in a saving account";
        subSequence++;
        timer = 6f;
    }

    private void secondFourthSubtitleSequence()
    {
        if (Choices.getChoice() == 0)
        {
            subtitle.text = "Customer Service: Are you sure you want to break it?";
            secondRightChoice.SetActive(true);
            secondWrongChoice.SetActive(true);
        }
        else if (Choices.getChoice() == 1)
        {
            secondRightChoiceSequence();
        }
        else if (Choices.getChoice() == -1)
        {
            secondWrongChoiceSequence();
        }
    }

    private void secondRightChoiceSequence()
    {
        secondRightChoice.SetActive(false);
        secondWrongChoice.SetActive(false);
        audioSource.PlayOneShot(cs_3);
        subtitle.text = "Customer Service: Okay then, I have transferred your money to your saving account.\ngo to the tellers in order to withdraw them";
        subSequence++;
        investmentText.text = "Investment: 0";
        accountText.text = "Account: 32,300";
        Choices.setChoice(0);
        timer = 4f;
    }

    private void secondWrongChoiceSequence()
    {
        switch (wrongSubOne)
        {
            case 0:
                secondRightChoice.SetActive(false);
                secondWrongChoice.SetActive(false);
                audioSource.PlayOneShot(assistant_treat);
                subtitle.text = "Assistant: Are You Kidding me?! You need the money to treat your wife!";
                timer = 3f;
                wrongSubOne++;
                break;

            case 1:
                subtitle.text = "Customer Service: Are you sure you want to break it?";
                secondRightChoice.SetActive(true);
                secondWrongChoice.SetActive(true);
                break;
        }
    }

    private void secondFifthSubtitleSequence()
    {
        secondChoiceTwo.SetActive(true);
        if (Choices.getChoice() == 1)
        {
            goToTellersSequence();
        }

        if (this.transform.position.x == middleMovePoint.transform.position.x && this.transform.position.z == middleMovePoint.transform.position.z)
        {
            isMiddleMovePoint = true;
        }

        if (this.transform.position. x == tellersMovePoint.transform.position.x && this.transform.position.z == tellersMovePoint.transform.position.z)
        {
            choiceSequence++;
            resetAttributes();
        }
    }

    private void goToTellersSequence()
    {
        if (!isMiddleMovePoint)
        {
            MoveToPoint.moveTo(this.gameObject, middleMovePoint, 5f);
        }
        else if (isMiddleMovePoint)
        {
            MoveToPoint.moveTo(this.gameObject, tellersMovePoint, 5f);
        }
        secondChoiceTwo.SetActive(false);
    }

    private void thirdFirstSubtitleSequence()
    {
        audioSource.PlayOneShot(teller_1);
        subtitle.text = "Teller: Hello, How can I help you today?";
        subSequence++;
        timer = 2.5f;
    }

    private void thirdSecondSubtitleSequence()
    {
        audioSource.PlayOneShot(assistant_2);
        subtitle.text = "Assistant: Wait before you answer, it is preferable to leave some money in the saving account\nto decrease its administrative costs and avoid the stopping of the account";
        timer = 10f;
        subSequence++;
    }
    
    private void thirdThirdSubtitleSequence()
    {
        if (Choices.getChoice() == 0)
        {
            subtitle.text = "Teller: Hello, How can I help you today?";
            thirdRightChoice.SetActive(true);
            thirdWrongChoice.SetActive(true);
        }
        else if (Choices.getChoice() == 1)
        {
            thirdRightChoice.SetActive(false);
            thirdWrongChoice.SetActive(false);
            subSequence++;
            Choices.setChoice(0);
        }
        else if (Choices.getChoice() == -1)
        {
            thirdWrongChoiceSequence();
        }

    }

    private void thirdWrongChoiceSequence()
    {
        switch(wrongSubOne)
        {
            case 0:
                thirdRightChoice.SetActive(false);
                thirdWrongChoice.SetActive(false);
                audioSource.PlayOneShot(assistant_wrongAns);
                subtitle.text = "Assistant: I don’t think this is a wise idea\nsince you can leave some money inside the saving account";
                timer = 6.5f;
                wrongSubOne++;
                break;

            case 1:
                subtitle.text = "Teller: How can I help you today?";
                thirdRightChoice.SetActive(true);
                thirdWrongChoice.SetActive(true);
                break;
        }
    }

    private void thirdFourthSubtitleSequence()
    {
        audioSource.PlayOneShot(teller_2);
        subtitle.text = "Teller: Right away sir!";
        walletText.text = "Wallet: 30,000";
        accountText.text = "Account: 2,300";
        timer = 2f;
        choiceSequence++;
        resetAttributes();
    }

    private void calcFirstSubtitle()
    {
        audioSource.PlayOneShot(calc_1);
        subtitle.text = "Assistant: Now let us make our calculations.";
        timer = 3.5f;
        subSequence++;
    }

    private void calcSecondSubtitle()
    {
        if (Choices.getChoice() == 0)
        {
            subtitle.text = "Assistant: First of all, do you know how much\nthe interest rate is in the saving account?";
            fourthRightChoice.SetActive(true);
            fourthWrongChoice.SetActive(true);
        }
        else if (Choices.getChoice() == 1)
        {
            audioSource.PlayOneShot(calc_correct);
            fourthRightChoice.SetActive(false);
            fourthWrongChoice.SetActive(false);
            subtitle.text = "Assistant: Correct, it is 5%";
            subSequence++;
            Choices.setChoice(0);
            timer = 3f;
        }
        else if (Choices.getChoice() == -1)
        {
            audioSource.PlayOneShot(calc_notRight);
            fourthRightChoice.SetActive(false);
            fourthWrongChoice.SetActive(false);
            subtitle.text = "Assistant: That is not right, it is 5%";
            subSequence++;
            Choices.setChoice(0);
            timer = 3.5f;
        }
    }

    private void calcThirdSubtitle()
    {
        audioSource.PlayOneShot(calc_2);
        subtitle.text = "Assistant: 1st let me tell you how you got the 5900 LE\nbefore you break the certificate";
        timer = 6f;
        subSequence++;
    }

    private void calcFourthSubtitle()
    {
        subtitle.text = "Assistant: It came from the interest you won from the certificate\nfor two years which was (30,000 X 11%) X 2 = 6,600 LE";
        timer = 14f;
        subSequence++;
    }

    private void calcFifthSubtitle()
    {
        subtitle.text = "Assistant: Then this amount subtracted by the saving account’s expenses which was\n(30 LE administrative expenses every 3 months + 45 LE account statement every 3 months +\n50 LE Debit card fees every year) X 2 = 700 LE";
        timer = 21f;
        subSequence++;
    }

    private void calcSixthSubtitle()
    {
        subtitle.text = "Assistant: So the remaining money in your account is 6,600 - 700 = 5,900 LE";
        timer = 10f;
        subSequence++;
    }

    private void calcSeventhSubtitle()
    {
        subtitle.text = "Assistant: Now since you broke the certificate we need to calculate the new revenue\nof 5% interest of the saving account which is 30,000 X 5% = 1,500 for each year,\ntherefore the new revenue is 1,500 X 2 = 3,000";
        timer = 20f;
        subSequence++;
    }

    private void calcEighthSubtitle()
    {
        subtitle.text = "Assistant: Then, all the previous revenue in your account will be removed and the new value\nwill be 30,000 + 3,000 = 33,000 LE and this value is added in the account";
        timer = 13.5f;
        subSequence++;
    }

    private void calcNinthSubtitle()
    {
        subtitle.text = "Assistant: Only one thing left to do is to subtract the saving account expenses again\nfor the new balance which will be 33,000 – 700 = 32,300 LE";
        timer = 13.5f;
        subSequence++;
    }

    private void calcTenthSubtitle()
    {
        subtitle.text = "Asisstant: Note, if you withdrew the money of the certificate, this money will be\ndeducted from the original deposit after calculating the new interest";
        timer = 9.5f;
        subSequence++;
    }

    private void congratulationsSequence()
    {
        audioSource.PlayOneShot(congratulations);
        congratulationText.gameObject.SetActive(true);
        subtitle.text = "";
        congratulationText.text = "Congratulations, Level 4 Complete!";
        timer = 3f;
        subSequence++;
    }
}
