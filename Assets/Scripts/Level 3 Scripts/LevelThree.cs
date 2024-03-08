using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelThree : MonoBehaviour
{
    private bool playAudio1 = true;
    private bool playAudio2 = true;
    private bool playAudio3 = true; 
    private AudioSource audioSource;
    private float timer = 3f;
    [SerializeField] private Text subtitle;
    [SerializeField] private Text walletText;
    [SerializeField] private Text accountText;
    [SerializeField] private Text investmentText;
    [SerializeField] private Text congratulationText;
    [SerializeField] private GameObject firstRightChoiceOne;
    [SerializeField] private GameObject firstWrongChoiceOne;
    [SerializeField] private GameObject firstWrongChoiceTwo;
    [SerializeField] private GameObject customerServiceMovePoint;
    [SerializeField] private GameObject middleMovePoint;
    [SerializeField] private GameObject tellersMovePoint;
    [SerializeField] private GameObject secondChoiceOne;
    [SerializeField] private GameObject secondChoiceTwo;
    [SerializeField] private GameObject secondChoiceThree;
    [SerializeField] private GameObject secondRightChoice;
    [SerializeField] private GameObject secondWrongChoice;
    [SerializeField] private GameObject thirdChoiceOne;
    [SerializeField] private GameObject thirdChoiceTwo;
    [SerializeField] private GameObject thirdChoiceThree;
    [SerializeField] private GameObject thirdRightChoice;
    [SerializeField] private GameObject thirdWrongChoiceOne;
    [SerializeField] private GameObject thirdWrongChoiceTwo;
    [SerializeField] private GameObject thirdChoiceFour;
    [SerializeField] private GameObject fourthChoiceOne;
    private bool isMiddleMovePoint;
    private int subSequence = 0;
    private int rightSub = 0;
    private int wrongSubOne = 0;
    private int wrongSubTwo = 0;
    private int choiceSequence = 0;

    // Audio Refrences
    [SerializeField] private AudioClip assistant_1;
    [SerializeField] private AudioClip assistant_correct;
    [SerializeField] private AudioClip assistant_rightPlan;
    [SerializeField] private AudioClip assistant_thinkAgain;
    [SerializeField] private AudioClip assistant_TRC;
    [SerializeField] private AudioClip assistant_TWC1;
    [SerializeField] private AudioClip assistant_TWC2;
    [SerializeField] private AudioClip assistant_wrongPlan;
    [SerializeField] private AudioClip congratulations;
    [SerializeField] private AudioClip cs_1;
    [SerializeField] private AudioClip cs_2;
    [SerializeField] private AudioClip cs_3;
    [SerializeField] private AudioClip cs_4;
    [SerializeField] private AudioClip cs_5;
    [SerializeField] private AudioClip cs_6;
    [SerializeField] private AudioClip cs_7;
    [SerializeField] private AudioClip cs_8;
    [SerializeField] private AudioClip cs_9;
    [SerializeField] private AudioClip cs_10;
    [SerializeField] private AudioClip teller_1;
    [SerializeField] private AudioClip teller_2;
    [SerializeField] private AudioClip calculations;

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
               switch (subSequence)
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
               switch (subSequence)
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

                    case 5:
                        secondSixthSubtitleSequence();
                        break;

                    case 6:
                        secondSeventhSubtitleSequence();
                        break;        

                    case 7:
                        secondEighthSubtitleSequence();
                        break;

                    case 8:
                        secondNinthSubtitleSequence();
                        break;       
                    
                    case 9:
                        secondTenthSubtitleSequence();    
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

                    case 4:
                        thirdFifthSubtitleSequence();
                        break;

                    case 5:
                        thirdSixthSubtitleSequence();
                        break;

                    case 6:
                        thirdSeventhSubtitleSequence();
                        break;    

                    case 7:
                        thirdEighthSubtitleSequence();
                        break;

                    case 8:
                        thirdNinthSubtitleSequence();
                        break;      
                }
           }
           else if (choiceSequence == 3)
           {
               fourthFirstSubtitleSequence();
           }
           else if (choiceSequence == 4)
           {
               switch(subSequence)
               {
                    case 0:
                        calcFirstSubtitleSequence();
                        break;

                    case 1:
                        calcSecondSubtitleSequence();
                        break;

                    case 2:
                        calcThirdSubtitleSequence();
                        break;

                    case 3:
                        calcFourthSubtitleSequence();
                        break;

                    case 4:
                        calcFifthSubtitleSequence();
                        break;

                    case 5:
                        congratulationsSequence();
                        break;    

                    case 6:
                        nextScene();
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
        isMiddleMovePoint = false;
        subSequence = 0;
        wrongSubOne = 0;
        wrongSubTwo = 0;
        rightSub = 0;
        Choices.setChoice(0);
    }

    private void firstFirstSubtitleSequence()
    {
        subtitle.text = "Assistant: Welcome!, I knew you wanted to invest your money for a\nlong period of time.";
        audioSource.PlayOneShot(assistant_1);
        timer = 5.5f;
        subSequence++;
    }

    private void firstSecondSubtitleSequence()
    {
        if (Choices.getChoice() == 0)
        {
        subtitle.text = "Assistant: Where do you think we need to go?";
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
            subtitle.text = "Assistant: Think again!";
            if (playAudio2)
            {
                audioSource.PlayOneShot(assistant_thinkAgain);
                playAudio2 = false;
            }
        }
        else if (Choices.getChoice() == -2)
        {
            subtitle.text = "Assistant: Think again!";
            if (playAudio3)
            {
                audioSource.PlayOneShot(assistant_thinkAgain);
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
            subtitle.text = "Customer Service: Hello sir, How can I help you?";
            audioSource.PlayOneShot(cs_1);
        }
    }

    private void goToCustomerServiceSequence()
    {
        subtitle.text = "Assistant: Correct!";
        firstRightChoiceOne.SetActive(false);
        firstWrongChoiceOne.SetActive(false);
        firstWrongChoiceTwo.SetActive(false);
        if (isMiddleMovePoint)
        {
            MoveToPoint.moveTo(this.gameObject, customerServiceMovePoint, 5f);
        }
        else if (!isMiddleMovePoint)
        {
            MoveToPoint.moveTo(this.gameObject, middleMovePoint, 5f);
        }
        if (playAudio1)
        {
            audioSource.PlayOneShot(assistant_correct);
            playAudio1 = false;
        }
    }

    private void secondFirstSubtitleSequence()
    {
        secondChoiceOne.SetActive(true);
        if (Choices.getChoice() == 1)
        {
            subtitle.text = "Customer Service: Investment plans differ from saving accounts, As putting money in saving accounts\nguarantees you a certain percentage of interest, usually at lower rates than investment plans";
            audioSource.PlayOneShot(cs_2);
            timer = 11f;
            subSequence++;
            Choices.setChoice(0);
            secondChoiceOne.SetActive(false);
        }
    }

    private void secondSecondSubtitleSequence()
    {
        subtitle.text = "Customer Service: and allows you to be able to withdraw it at any time.";
        timer = 4f;
        subSequence++;
    }

    private void secondThirdSubtitleSequence()
    {
        subtitle.text = "Customer Service: While investment in plans, you usually freeze a certain amount of money that you\ncannot take control of, but you are guaranteed a higher rate of interest in return";
        timer = 10f;
        subSequence++;
    }

    private void secondFourthSubtitleSequence()
    {
        subtitle.text = "Customer Service: There are investment plans that starts from 1 year up to 10 years.";
        timer = 4.5f;
        subSequence++;
    }

    private void secondFifthSubtitleSequence()
    {
        subtitle.text = "Customer Service: So would you like to have an investment plan?";
        secondChoiceTwo.SetActive(true);
        if (Choices.getChoice() == 1)
        {
            subtitle.text = "Customer Service: Kindly, our bank supports multiple investment plans,\nfor average users they usually go for the saving certificates and term deposits";
            audioSource.PlayOneShot(cs_3);
            timer = 9f;
            subSequence++;
            Choices.setChoice(0);
            secondChoiceTwo.SetActive(false);
        }
    }

    private void secondSixthSubtitleSequence()
    {
        secondChoiceThree.SetActive(true);
        if (Choices.getChoice() == 1)
        {
            subtitle.text = "Customer Service: They are mostly alike, but they differ in some scenarios, the deposits can be used for both\nshort and long period of times, and it can be broken down (Withdrawal) at any time";
            audioSource.PlayOneShot(cs_4);
            timer = 11f;
            subSequence++;
            Choices.setChoice(0);
            secondChoiceThree.SetActive(false);
        }
    }

    private void secondSeventhSubtitleSequence()
    {
        subtitle.text = "Customer Service: While Saving certificates have some constraints";
        timer = 4f;
        subSequence++;
    }

    private void secondEighthSubtitleSequence()
    {
        subtitle.text = "Customer Service: that it can't be broken unless it was bonded for at least 6 months.\n And if broken, the money you deposited will be treated as if it was in a saving account";
        timer = 10f;
        subSequence++;
    }

    private void secondNinthSubtitleSequence()
    {
        subtitle.text = "Customer Service: Also saving certificate have much higher interest rate than the term deposit.";
        timer = 5f;
        subSequence++;
    }

    private void secondTenthSubtitleSequence()
    {
        if (Choices.getChoice() == 0)
        {
        subtitle.text = "Customer Service: So which type of investment plan do you want?";
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
        subtitle.text = "Assistant: Correct!, this suit your situation well since you don't need the money now\nand you want to invest it for long duration with higher interest rate.";
        audioSource.PlayOneShot(assistant_rightPlan);
        choiceSequence++;
        timer = 10f;
        Choices.setChoice(0);
        resetAttributes();
    }

    private void secondWrongChoiceSequence()
    {
        switch(wrongSubOne)
        {
            case 0:
                secondRightChoice.SetActive(false);
                secondWrongChoice.SetActive(false);
                subtitle.text = "Assistant: Maybe its not the best choice for your situation.";
                audioSource.PlayOneShot(assistant_wrongPlan);
                timer = 4f;
                wrongSubOne++;
                break;

            case 1:
                secondRightChoice.SetActive(true);
                secondWrongChoice.SetActive(true);
                subtitle.text = "Assistant: Please Choose Again.";
                break;    
        }
    }

    private void thirdFirstSubtitleSequence()
    {
        subtitle.text = "Customer Service: Ok sir, there are many saving certificate plans, but the most common 3 are\nThe platinum certificate with a variable return, The monthly platinum\ncertificate, and the five year saving certificate.";
        audioSource.PlayOneShot(cs_5);
        timer = 14f;
        subSequence++;
    }

    private void thirdSecondSubtitleSequence()
    {
        thirdChoiceOne.SetActive(true);
        if (Choices.getChoice() == 1)
        {
            thirdChoiceOne.SetActive(false);
            Choices.setChoice(0);
            subtitle.text = "Customer Service: This certificate expires after 3 years, the revenue is acquired quarter annually,\ndoesn't have a fixed interest rate and it depends on the interest rate\n of the central bank";
            audioSource.PlayOneShot(cs_6);
            timer = 11.5f;
            subSequence++;
        }
    }

    private void thirdThirdSubtitleSequence()
    {
        subtitle.text = "Customer Service: If the central bank's interest rate changed while the certificate is bonded, then\na change will occur in the interest rate after one day.";
        timer = 10f;
        subSequence++;
    }

    private void thirdFourthSubtitleSequence()
    {
        subtitle.text = "Customer Service: Today's interest rate of this certificate is 11.5%\nbut it may change so it has some risks";
        timer = 6f;
        subSequence++;
    }

    private void thirdFifthSubtitleSequence()
    {
        thirdChoiceTwo.SetActive(true);
        if (Choices.getChoice() == 1)
        {
            thirdChoiceTwo.SetActive(false);
            Choices.setChoice(0);
            subtitle.text = "Customer Service: This certificate has fixed interest rate of 11%,\n expires after 3 years and the revenue is acquired monthly";
            audioSource.PlayOneShot(cs_7);
            timer = 8f;
            subSequence++;
        }
    }

    private void thirdSixthSubtitleSequence()
    {
        thirdChoiceThree.SetActive(true);
        if (Choices.getChoice() == 1)
        {
            thirdChoiceThree.SetActive(false);
            Choices.setChoice(0);
            subtitle.text = "Customer Service: This certificate has a fixed interest rate of 10.25%,\nit starts after a month of bonding it, expires after 5 years\nand the revenue is acquired monthly.";
            audioSource.PlayOneShot(cs_8);
            timer = 12f;
            subSequence++;
        }
    }

    private void thirdSeventhSubtitleSequence()
    {
        if (Choices.getChoice() == 0)
        {
            subtitle.text = "Customer Service: Which one will you choose?";
            if (playAudio1)
            {
                audioSource.PlayOneShot(cs_9);
                playAudio1 = false;
            }
            thirdRightChoice.SetActive(true);
            thirdWrongChoiceOne.SetActive(true);
            thirdWrongChoiceTwo.SetActive(true);
        }
        else if (Choices.getChoice() == 1)
        {
            thirdRightChoiceSequence();
        }
        else if (Choices.getChoice() == -1)
        {
            thirdWrongChoiceOneSequence();
        }
        else if (Choices.getChoice() == -2)
        {
            thirdWrongChoiceTwoSequence();
        }
    }
    
    private void thirdRightChoiceSequence()
    {
        thirdRightChoice.SetActive(false);
        thirdWrongChoiceOne.SetActive(false);
        thirdWrongChoiceTwo.SetActive(false);
        Choices.setChoice(0);
        subtitle.text = "Assistant: I think this maybe the best choice for your situation.\nGreat Choice";
        audioSource.PlayOneShot(assistant_TRC);
        timer = 5f;
        subSequence++;
    }

    private void thirdWrongChoiceOneSequence()
    {
        switch(wrongSubOne)
        {
            case 0:
                 thirdRightChoice.SetActive(false);
                thirdWrongChoiceOne.SetActive(false);
                thirdWrongChoiceTwo.SetActive(false);
                subtitle.text = "Assistant: This may not be the best choice for you, and it has some risks,\nI think there is a better choice than that";
                audioSource.PlayOneShot(assistant_TWC1);
                timer = 7f;
                wrongSubOne++;
                break;

            case 1:
                subtitle.text = "";
                thirdRightChoice.SetActive(true);
                thirdWrongChoiceOne.SetActive(true);
                thirdWrongChoiceTwo.SetActive(true);
                break;
        }
    }

    private void thirdWrongChoiceTwoSequence()
    {
        switch(wrongSubTwo)
        {
            case 0:
                thirdRightChoice.SetActive(false);
                thirdWrongChoiceOne.SetActive(false);
                thirdWrongChoiceTwo.SetActive(false);
                subtitle.text = "Assistant: I don't think this will be the best solution for your situation\nsince you need an investment plan for 3 years only";
                audioSource.PlayOneShot(assistant_TWC2);
                timer = 7f;
                wrongSubTwo++;
                break;

            case 1:
                subtitle.text = "Assistant: I think there is a better choice than that.";
                timer = 3f;
                wrongSubTwo++;
                break;

            case 2:
                subtitle.text = "";
                thirdRightChoice.SetActive(true);
                thirdWrongChoiceOne.SetActive(true);
                thirdWrongChoiceTwo.SetActive(true);
                break;
        }
    }

    private void thirdEighthSubtitleSequence()
    {
        subtitle.text = "Customer Service: Okay then, the certificate has been bonded.";
        audioSource.PlayOneShot(cs_10);
        timer = 3f;
        subSequence++;
    }

    private void thirdNinthSubtitleSequence()
    {
        subtitle.text = "Customer Service: Now, go to the tellers to deposit your desired amount";
        thirdChoiceFour.SetActive(true);
        if (Choices.getChoice() == 1)
        {
            goToTellersSequence();
        }

        if (this.transform.position.x == middleMovePoint.transform.position.x && this.transform.position.z == middleMovePoint.transform.position.z)
        {
            isMiddleMovePoint = true;
        }
        if (this.transform.position.x == tellersMovePoint.transform.position.x && this.transform.position.z == tellersMovePoint.transform.position.z)
        {
            choiceSequence++;
            resetAttributes();
            subtitle.text = "Teller: Hello, how can I help you sir?";
            audioSource.PlayOneShot(teller_1);
        }
    }

    private void goToTellersSequence()
    {
        if (isMiddleMovePoint)
            {
                MoveToPoint.moveTo(this.gameObject, tellersMovePoint, 5f);
            }
            else if (!isMiddleMovePoint)
            {
                MoveToPoint.moveTo(this.gameObject, middleMovePoint, 5f);
            }
        thirdChoiceFour.SetActive(false);
    }

    private void fourthFirstSubtitleSequence()
    {
        fourthChoiceOne.SetActive(true);
        if (Choices.getChoice() == 1)
        {
            fourthChoiceOne.SetActive(false);
            Choices.setChoice(0);
            subtitle.text = "Okay sir, Thank you for banking with us";
            audioSource.PlayOneShot(teller_2);
            walletText.text = "Wallet: 0";
            investmentText.text = "Monthly platinum certificate: 30,000";
            timer = 5f;
            choiceSequence++;
            resetAttributes();
        }
    }

    private void calcFirstSubtitleSequence()
    {
        subtitle.text = "Assistant: Now, let us make our calculations for our monthly revenue";
        audioSource.PlayOneShot(calculations);
        timer = 4f;
        subSequence++;
    }

    private void calcSecondSubtitleSequence()
    {
        subtitle.text = "Assistant: The original deposited amount is 30,000\nand the interest rate = 11%";
        timer = 7f;
        subSequence++;
    }

    private void calcThirdSubtitleSequence()
    {
        subtitle.text = "Assistant: Which means that the annual revenue will be 30,000 X 11% = 3,300";
        timer = 9f;
        subSequence++;
    }

    private void calcFourthSubtitleSequence()
    {
        subtitle.text = "Assistant: To calculate your monthly revenue, you need to divide the annual revenue over 12,\n which equals 3,300 / 12 = 275 LE for each month";
        timer = 15f;
        subSequence++;
    }

    private void calcFifthSubtitleSequence()
    {
        subtitle.text = "Assistant: And the total revenue after the 3 years if the bond was not broken will be\n3,300 X 3 = 9,900 LE";
        timer = 13f;
        subSequence++;
    }

    private void congratulationsSequence()
    {
        congratulationText.gameObject.SetActive(true);
        subtitle.text = "";
        congratulationText.text = "Congratulations, Level 3 Complete!";
        audioSource.PlayOneShot(congratulations);
        timer = 2f;
        subSequence++;
    }

    private void nextScene()
    {
        SceneLoader.setIsLevelCompleted(true);
    }
}
