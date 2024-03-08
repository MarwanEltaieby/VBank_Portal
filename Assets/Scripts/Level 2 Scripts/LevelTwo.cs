using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTwo : MonoBehaviour
{
    private float timer = 3f;
    [SerializeField] private Text subtitle;
    [SerializeField] private GameObject firstChoiceOne;
    [SerializeField] private GameObject firstWrongChoiceOne;
    [SerializeField] private GameObject firstWrongChoiceTwo;
    [SerializeField] private GameObject SecondChoiceOne;
    [SerializeField] private GameObject currentAccountChoice;
    [SerializeField] private GameObject savingAccountChoice;
    [SerializeField] private GameObject yesChoice;
    [SerializeField] private GameObject noChoice;
    [SerializeField] private GameObject tellersChoice;
    [SerializeField] private GameObject reciptionChoice;
    [SerializeField] private GameObject tellersMovePoint;
    [SerializeField] private GameObject depositChoice;
    private int subSequence = 0;
    [SerializeField] private GameObject customerServiceMovePoint;
    [SerializeField] private Text wallet;
    [SerializeField] private Text account;
    [SerializeField] private Text congratulationText;
    [SerializeField] private GameObject middleMovePoint;
    private bool isMiddleMovePoint;
    private int rightSub = 0;
    private int wrongSubOne = 0;
    private int wrongSubTwo = 0;
    private int choiceSequence = 0;
    private AudioSource audioSource;
    private bool playAudio = true;
    private bool playAudio2 = true;

    //Audio Refrences
    [SerializeField] private AudioClip assistant_1;
    [SerializeField] private AudioClip assistant_CAChoice;
    [SerializeField] private AudioClip assistant_congrats;
    [SerializeField] private AudioClip assistant_csChoice;
    [SerializeField] private AudioClip assistant_reciptionChoice;
    [SerializeField] private AudioClip assistant_SAChoice;
    [SerializeField] private AudioClip assistant_TellerChoice;
    [SerializeField] private AudioClip calculations;
    [SerializeField] private AudioClip congratulations;
    [SerializeField] private AudioClip cs_1;
    [SerializeField] private AudioClip cs_2;
    [SerializeField] private AudioClip cs_3;
    [SerializeField] private AudioClip cs_yesChoice;
    [SerializeField] private AudioClip cs_noChoice;
    [SerializeField] private AudioClip teller_1;
    [SerializeField] private AudioClip teller_2;
    [SerializeField] private AudioClip assistant_depositQuestion;
    [SerializeField] private AudioClip assistant_correct;
    [SerializeField] private AudioClip assistant_thinkAgain;

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
                        audioSource.PlayOneShot(assistant_1);
                        subtitle.text = scene2.scene_4_P1();
                        subSequence++;
                        timer = 4f;
                        break;

                    case 1:
                        firstSecondSubtitleSequence();
                        break;

                    case 2:
                        firstThirdSubtitleSequence();
                        break;
                }
            }
            else if (choiceSequence == 1)
            {
                switch (subSequence)
                {
                    case 0:
                        secondSecondSubtitleSequence();
                        break;

                    case 1:
                        secondThirdSubtitleSequence();
                        break; 

                    case 2:
                        secondFourthSubtitleSequence();
                        break;

                    case 3:
                        secondFifthSubtitleSequence();
                        break;

                    case 4:
                        secondSixthSubtitleSequence();
                        break;

                    case 5:
                        secondSeventhSubtitleSequence();
                        break;

                    case 6:
                        secondEighthSubtitleSequence();
                        break;

                    case 7:
                        secondNinthSubtitleSequence();
                        break;

                    case 8:
                        secondTenthSubtitleSequence();
                        break;

                    case 9:
                        secondEleventhSubtitleSequence();
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

                }
            }
            else if (choiceSequence == 3)
            {
                switch(subSequence)
                {
                    case 0:
                        fourthFirstSubtitleSequence();
                        break;
                }
                
            }
            else if (choiceSequence == 4)
            {
                switch(subSequence)
                {
                    case 0:
                        fifthFirstSubtitleSequence();
                        break;

                    case 1:
                        fifthSecondSubtitleSequence();
                        break;    
                }
            }
            else if (choiceSequence == 5)
            {
                switch(subSequence)
                {
                    case 0:
                        calculationsSubtitleOne();
                        break;
                    
                    case 1:
                        calculationsSubtitleTwo();
                        break;

                    case 2:
                        calculationsSubtitleThree();
                        break;

                    case 3:
                        calculationsSubtitleFour();
                        break;

                    case 4:
                        calculationsSubtitleFive();
                        break;

                    case 5:
                        calculationsSubtitleSix();
                        break;

                    case 6:
                        congratulationsSubtitles();
                        break;                    
                }
            }
        }    
          
    }

    //Resets all the cached attributes in order to reuse it in other sequences
    private void resetAttributes()
    {
        playAudio = true;
        playAudio2 = true;
        subSequence = 0;
        wrongSubOne = 0;
        wrongSubTwo = 0;
        rightSub = 0;
        Choices.setChoice(0);
        isMiddleMovePoint = false;
    }

  
    //Accessing the second subtitle and resetting the timer in the 1st sequence
    private void firstSecondSubtitleSequence()
    {
        subtitle.text = scene2.scene_4_P2();
        timer = 5f;
        subSequence++;
    }
  
    //Accessing the third subtitle and going to the 2nd sequence if he made the right choice 
    private void firstThirdSubtitleSequence()
    {
        if (wrongSubOne == 0 && wrongSubTwo == 0)
        {
            subtitle.text = scene2.scene_4_P3();
            firstChoiceOne.SetActive(true);
            firstWrongChoiceOne.SetActive(true);
            firstWrongChoiceTwo.SetActive(true);
        }
        int choice = Choices.getChoice();
        if (choice == 1)
        {
            if (isMiddleMovePoint)
            {
                MoveToPoint.moveTo(this.gameObject, customerServiceMovePoint, 5f);
            }
            else if (!isMiddleMovePoint)
            {
                MoveToPoint.moveTo(this.gameObject, middleMovePoint, 5f);
            }
            if (playAudio)
            {
                audioSource.PlayOneShot(assistant_csChoice);
                playAudio = false;
            }
            subtitle.text = "Good Choice!";
            firstChoiceOne.SetActive(false);
            firstWrongChoiceOne.SetActive(false);
            firstWrongChoiceTwo.SetActive(false);
        }
        else if (choice == -1) 
        {
            firstWrongChoiceOneSequence();
        }
        else if (choice == -2)
        {
            firstWrongChoiceSequenceTwo();
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
            subtitle.text = scene4.scene_4_1();
        }
    }
 
    //Accessing the 1st wrong subtitles of the firstThirdSubtitleSequence method and resetting choice in the 1st sequence
    private void firstWrongChoiceOneSequence()
    {
        if (wrongSubOne == 0)
        {
            firstChoiceOne.SetActive(false);
            firstWrongChoiceOne.SetActive(false);
            firstWrongChoiceTwo.SetActive(false);
            subtitle.text = scene3.scene_4_Result_P1();
            audioSource.PlayOneShot(assistant_TellerChoice);
            wrongSubOne++;
            timer = 2f;
        }
        else if (wrongSubOne == 1)
        {
           subtitle.text = scene3.scene_4_Result_P2();
           wrongSubOne++;
           timer = 4f;
        }
        else if (wrongSubOne == 2)
        {
            subtitle.text = scene3.scene_4_Result_P3();
            firstChoiceOne.SetActive(true);
            firstWrongChoiceOne.SetActive(true);
            firstWrongChoiceTwo.SetActive(true);
        }
    }
  
    //Accessing the 2nd wrong subtitles of the firstThirdSubtitleSequence method and resetting choice in the 1st sequence
    private void firstWrongChoiceSequenceTwo()
    {
        if (wrongSubTwo == 0)
        {
            audioSource.PlayOneShot(assistant_reciptionChoice);
            firstChoiceOne.SetActive(false);
            firstWrongChoiceOne.SetActive(false);
            firstWrongChoiceTwo.SetActive(false);
            subtitle.text = scene3.scene_4_Choice_3_Result_P1();
            timer = 2f;
            wrongSubTwo++;
        }
        else if (wrongSubTwo == 1)
        {
            subtitle.text = scene3.scene_4_Choice_3_Result_P2();
            timer = 5f;
            wrongSubTwo++;
        }
        else if (wrongSubTwo == 2)
        {
            subtitle.text = scene3.scene_4_Choice_3_Result_P3();
            wrongSubTwo++;
            firstChoiceOne.SetActive(true);
            firstWrongChoiceOne.SetActive(true);
            firstWrongChoiceTwo.SetActive(true);
        }
    }

    //Accessing second subtitle and resetting the timer in the 2nd sequence
    private void secondSecondSubtitleSequence()
    {
        SecondChoiceOne.SetActive(true);
        int choice = Choices.getChoice();
        if (choice == 1)
        {
            audioSource.PlayOneShot(cs_2);
            subtitle.text = scene4.scene_4_3_1();
            timer = 4f;
            Choices.setChoice(0);
            SecondChoiceOne.SetActive(false);
            subSequence++;
        }
    }

    //Accessing third subtitle and resetting the timer in the 2nd sequence if he triggers the question
    private void secondThirdSubtitleSequence()
    {
        subtitle.text = scene4.scene_4_3_2();
        timer = 3f;
        subSequence++;
    }

    //Accessing fourth subtitle and resetting the timer in the 2nd sequence
    private void secondFourthSubtitleSequence()
    {
        subtitle.text = scene4.scene_4_3_3();
        timer = 2f;
        subSequence++;
    }

    //Accessing fifth subtitle and resetting the timer in the 2nd sequence
    private void secondFifthSubtitleSequence()
    {
        subtitle.text = scene4.scene_4_3_4();
        timer = 6f;
        subSequence++;
    }

    //Accessing sixth subtitle and resetting the timer in the 2nd sequence
    private void secondSixthSubtitleSequence()
    {
        subtitle.text = scene4.scene_4_3_5();
        timer = 10f;
        subSequence++;
    }

    //Accessing seventh subtitle and resetting the timer in the 2nd sequence
    private void secondSeventhSubtitleSequence()
    {
        subtitle.text = scene4.scene_4_3_6();
        timer = 4f;
        subSequence++;
    }

    //Accessing eighth subtitle and resetting the timer in the 2nd sequence
    private void secondEighthSubtitleSequence()
    {
        subtitle.text = scene4.scene_4_3_7();
        timer = 5f;
        subSequence++;
    }

    //Accessing ninth subtitle and resetting the timer in the 2nd sequence
    private void secondNinthSubtitleSequence()
    {
        subtitle.text = scene4.scene_4_3_8();
        timer = 7f;
        subSequence++;
    }

    //Accessing tenth subtitle and resetting the timer in the 2nd sequence
    private void secondTenthSubtitleSequence()
    {
        subtitle.text = scene4.scene_4_3_9();
        timer = 5f;
        subSequence++;
    }

    //Accessing the third subtitle and going to the 3rd sequence if he made the right choice 
    private void secondEleventhSubtitleSequence()
    {
        if (Choices.getChoice() == 0)
        {
            subtitle.text = scene4.scene_4_3_10();
            currentAccountChoice.SetActive(true);
            savingAccountChoice.SetActive(true);
        }
        int choice = Choices.getChoice();
        if (choice == 1)
        {
            savingAccountSequence();
        }
        else if (choice == -1)
        {
            currentAccountSequence();
        }
    }

    //the sequence that will be excuted when the saving account is chosen
    private void savingAccountSequence()
    {
        currentAccountChoice.SetActive(false);
        savingAccountChoice.SetActive(false);
        switch (rightSub)
        {
            case 0 :
                audioSource.PlayOneShot(assistant_SAChoice);
                subtitle.text = scene5.scene_5_Choice_1_Result_P1();
                rightSub++;
                timer = 2f;
                break;
            
            case 1 :
                subtitle.text = scene5.scene_5_Choice_1_Result_P2();
                rightSub++;
                timer = 3f;
                break;

            case 2 :
                subtitle.text = scene5.scene_5_Choice_1_Result_P3();
                rightSub++;
                timer = 5f;        
                break;

            case 3 :
                subtitle.text = scene5.scene_5_Choice_1_Result_P4();
                resetAttributes();
                choiceSequence++;
                timer = 8f;   
                break;
        }
    }

    //the sequence that will be excuted when the current account is chosen
    private void currentAccountSequence()
    {
        switch (wrongSubOne)
        {
            case 0 :
                audioSource.PlayOneShot(assistant_CAChoice);
                currentAccountChoice.SetActive(false);
                savingAccountChoice.SetActive(false);
                subtitle.text = scene5.scene_5_Choice_2_Result_P1();
                wrongSubOne++;
                timer = 4f;
                break;

            case 1 :
                subtitle.text = scene5.scene_5_Choice_2_Result_P2();
                wrongSubOne++;
                timer = 5f;    
                break;

            case 2 :
                subtitle.text = scene5.scene_5_Choice_2_Result_P3();
                wrongSubOne++;
                timer = 11f; 
                break;

            case 3 :
                subtitle.text = scene5.scene_5_Choice_2_Result_P4();
                wrongSubOne++;
                currentAccountChoice.SetActive(true);
                savingAccountChoice.SetActive(true);
                break; 
        }
    }

    //Accessing the first subtitle in the 3rd sequence and giving the player 2 choices
    private void thirdFirstSubtitleSequence()
    {
        int choice = Choices.getChoice();
        if (Choices.getChoice() == 0)
        {
            if (playAudio)
            {
                timer = 5f;
                audioSource.PlayOneShot(cs_3);
                playAudio = false;
            }
            subtitle.text = scene6.scene_6_Question();
            if (timer <= 0)
            {
                yesChoice.SetActive(true);
                noChoice.SetActive(true);
            }
        }
        if(choice == 1)
        {
            yesChoiceSubtitleSequence();
        }
        else if (choice == -1)
        {
            noChoiceSubtitleSequence();
        }
    }
    
    private void thirdSecondSubtitleSequence()
    {
        if (Choices.getChoice() == 0)
        {
            wrongSubOne = 0;
            wrongSubTwo = 0;
            rightSub = 0;
            if (playAudio)
            {
                audioSource.PlayOneShot(assistant_depositQuestion);
                playAudio = false;
            }
            subtitle.text = scene6.scene_6_Question_2();
            tellersChoice.SetActive(true);
            reciptionChoice.SetActive(true);
        }
        int choice = Choices.getChoice();
        if (choice == 1)
        {
            rightSequance();
        }
        else if (choice == -1)
        {
            wrongSequence();
        }

        if (this.transform.position.x == middleMovePoint.transform.position.x && this.transform.position.z == middleMovePoint.transform.position.z)
        {
            isMiddleMovePoint = true;
        }

        if (this.transform.position.x == tellersMovePoint.transform.position.x && this.transform.position.z == tellersMovePoint.transform.position.z)   
        {
            choiceSequence++;
            resetAttributes();
        }     
    }

    //Yes Choice Sequence 
    private void yesChoiceSubtitleSequence()
    {
        switch (rightSub)
        {
            case 0:
                playAudio = true;
                audioSource.PlayOneShot(cs_yesChoice);
                subtitle.text = scene6.scene_6_Choice_1_Result_P1();
                rightSub++;
                timer = 3f;
                yesChoice.SetActive(false);
                noChoice.SetActive(false);
                break;
                
            case 1:
                subtitle.text = scene6.scene_6_Choice_1_Result_P2();
                subSequence++;
                Choices.setChoice(0);
                playAudio = true;
                rightSub = 0;
                timer = 12f;
                break;
        }
    }

    //No Choice Sequence
    private void noChoiceSubtitleSequence()
    {
        switch (wrongSubOne)
        {
            case 0:
                yesChoice.SetActive(false);
                noChoice.SetActive(false);
                wrongSubOne++;
                audioSource.PlayOneShot(cs_noChoice);
                subtitle.text = scene6.scene_6_Choice_2_Result_P1();
                timer = 5f;
                break;

            case 1:
                subtitle.text = scene6.scene_6_Choice_2_Result_P2();
                wrongSubOne++;
                timer = 4f;
                break;

            case 2:
                subtitle.text = scene6.scene_6_Choice_2_Result_P3();
                subSequence++;
                wrongSubOne = 0;
                Choices.setChoice(0);
                playAudio = true;
                timer = 12f;
                break;
        }
    }

    private void rightSequance()
    {
        if (playAudio)
        {
            audioSource.PlayOneShot(assistant_correct);
            playAudio = false;
        }
        subtitle.text = scene6.scene_6_Choice2_Result1_P1();
        if (isMiddleMovePoint)
        {
            MoveToPoint.moveTo(this.gameObject, tellersMovePoint, 4.5f);
        }
        else if (!isMiddleMovePoint)
        {
            MoveToPoint.moveTo(this.gameObject, middleMovePoint, 4.5f);
        }
        tellersChoice.SetActive(false);
        reciptionChoice.SetActive(false);
    } 

    private void wrongSequence()
    {
        if (playAudio2)
        {
            audioSource.PlayOneShot(assistant_thinkAgain);
            playAudio2 = false;
        }
        subtitle.text = scene6.scene6_Choice2_Result2_P1();
    }

    private void fourthFirstSubtitleSequence()
    {
        if (playAudio)
        {
            audioSource.PlayOneShot(teller_1);
            playAudio = false;
        }
        subtitle.text = scene7.scene_7_tellerQuestionAssistant();
        depositChoice.SetActive(true);
        int choice = Choices.getChoice();
        if (choice == 1)
        {
            audioSource.PlayOneShot(teller_2);
            subtitle.text = scene7.scene_7_tellerReplyToAssistant();
            timer = 4.5f;
            wallet.text = "Wallet: 0";
            account.text = "Account: 19,888";
            resetAttributes();
            choiceSequence++;
            depositChoice.SetActive(false);
        }
    }
    private void fifthFirstSubtitleSequence()
    {
        audioSource.PlayOneShot(assistant_congrats);
        subtitle.text = "Asisstant: Congratulations, Now your interest after one year will be 1000 LE\nand the expenses of the account in the same year will be 472 LE";
        timer = 10f;
        subSequence++;
    }

    private void fifthSecondSubtitleSequence()
    {
        subtitle.text = "Asisstant: after adding the interest and deducting the expenses,\nthe total amount after this year will be 20,528 LE.";
        timer = 10f;
        resetAttributes();
        choiceSequence++;
    }

    private void calculationsSubtitleOne()
    {
        audioSource.PlayOneShot(calculations);
        subtitle.text = "Asisstant: Let us calculate our profit";
        timer = 2f;
        subSequence++;
    }

    private void calculationsSubtitleTwo()
    {
        subtitle.text = "Asisstant: When opening a savings account, you get a revenue of 5% of the deposited amount,\n so we calculate the revenue by multiplying the amount in the account by\n5% and add it again to the original amount so the revenue will be 1,000";
        timer = 17f;
        subSequence++;
    }

    private void calculationsSubtitleThree()
    {
        subtitle.text = "Asisstant: Now we will calculate the account expenditures";
        timer = 4f;
        subSequence++;
    }

    private void calculationsSubtitleFour()
    {
        subtitle.text = "Asisstant: 50 LE for opening the account at the beginning, 50 LE VISA card,\n12 LE Stamp, 45 LE every 3 months administrative expenditures";
        timer = 11f;
        subSequence++;
    }

    private void calculationsSubtitleFive()
    {
        subtitle.text = "Asisstant: To sum it up all the expenditures for this year is 472 LE";
        timer = 6f;
        subSequence++;
    }

    private void calculationsSubtitleSix()
    {
        subtitle.text = "Asisstant: So, your bank account after 1 year will be\n20,000 + 10,000 - 472 = 20,528";
        timer = 12f;
        playAudio = true;
        subSequence++;
    }

    private void congratulationsSubtitles()
    {
        if (playAudio)
        {
            playAudio = false;
            audioSource.PlayOneShot(congratulations);
        }
        subtitle.text = "";
        congratulationText.gameObject.SetActive(true);
        SceneLoader.setIsLevelCompleted(true);
    }
}
