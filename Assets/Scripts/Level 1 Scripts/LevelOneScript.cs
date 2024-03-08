using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelOneScript : MonoBehaviour
{
    public GameObject tellerNodeOne;
    public GameObject tellerNodeTwo;
    public GameObject customerServiceNode;
    public GameObject reciptionNode;
    public GameObject stratingNode;
    public GameObject officeDoorNode;
    private float timeToChange = 5f;
    private bool timePassed = false;
    public Text subtitle;
    private bool secondSubtitle = false;
    private bool thirdSubtitle = false;
    private bool teller = false;
    private float timeAfterTeller = 12f;
    private bool reciption = false;
    private float timeAfterReciption = 12f;
    private bool customerService = false;
    private float timeAfterCustomerService = 12f;
    private bool fourthSubtitle = false;
    private bool customerServiceTimer = false;
    private bool tellerTimer = false;
    private bool ReciptionTimer = false;
    private float afterFinishTimer = 6f;
    public Text endText;
    public static bool isLevelCompleted = false;

    private void Start()
    {
        
    }
    async void Update()
    {
        timeToChange -= Time.deltaTime;
        if(timeToChange <= 0 && !timePassed) {
            timePassed = true;
            if (!secondSubtitle) {
                subtitle.text = "Assistant: I am going to be your assistant to help you learn\nabout banking and its investments.";
                secondSubtitle = true;
                timePassed = false;
                timeToChange = 7f;
            } else if (secondSubtitle && !thirdSubtitle && timePassed) {
                subtitle.text = "Assistant: Let us explore the different departments that we can interact with.";
                thirdSubtitle = true;
                timePassed = false;
                timeToChange = 7f;
            } else if (secondSubtitle && thirdSubtitle && !fourthSubtitle && timePassed) {
                subtitle.text = "Assistant: Please go to the Customer Service!";
                fourthSubtitle = true;
                timePassed = false;
            }
        }
        if (fourthSubtitle && !customerService && (this.transform.position.z == customerServiceNode.transform.position.z && this.transform.position.x == customerServiceNode.transform.position.x)) {
            subtitle.text = "Customer Service: Hello sir, in here most of the bank's transactions are done from\n opening an account, inquiries and investments."+
                " I will be at your service whenever you want";
            customerService = true;
        } else if (fourthSubtitle && !customerService && ((this.transform.position.z == tellerNodeOne.transform.position.z && this.transform.position.x == tellerNodeOne.transform.position.x)
            || (this.transform.position.z == tellerNodeTwo.transform.position.z && this.transform.position.x == tellerNodeTwo.transform.position.x)
            || (this.transform.position.z == reciptionNode.transform.position.z && this.transform.position.x == reciptionNode.transform.position.x))) {
            subtitle.text = "Assistant: This is not the Customer Service!";
        }


        if (customerService) {
            timeAfterCustomerService -= Time.deltaTime;
            if (timeAfterCustomerService <= 0 && !customerServiceTimer) {
                subtitle.text = "Assistant: Now lets explore the tellers. Go to the Tellers!";
                if (timeAfterCustomerService <= -6f){
                    customerServiceTimer = true;
                }
            }
        }

        if (customerServiceTimer && !teller && ((this.transform.position.z == tellerNodeTwo.transform.position.z && this.transform.position.x == tellerNodeTwo.transform.position.x)
            || (this.transform.position.z == tellerNodeOne.transform.position.z && this.transform.position.x == tellerNodeOne.transform.position.x))) {
                subtitle.text = "Tellers: Hello sir, here you can withdraw and deposit into your account whenever you want.";
                teller = true;
        } else if (customerServiceTimer && !teller && ((this.transform.position.z == customerServiceNode.transform.position.z && this.transform.position.x == customerServiceNode.transform.position.x)
            || (this.transform.position.z == reciptionNode.transform.position.z && this.transform.position.x == reciptionNode.transform.position.x))) {
                subtitle.text = "Assistant: Those are not the Tellers!";
        }

        if (teller) {
            timeAfterTeller -= Time.deltaTime;
            if (timeAfterTeller <= 0 && !tellerTimer) {
                subtitle.text = "Assistant: Now lets explore the reciption, Go to the Reciption!";
                if (timeAfterTeller <= -6f) {
                    tellerTimer = true;
                }
            }
        }

        if (tellerTimer && !reciption && (this.transform.position.z == reciptionNode.transform.position.z && this.transform.position.x == reciptionNode.transform.position.x)) {
            subtitle.text = "Receptionist: Hello sir, here you can receive your cards\n and collect checks whenever you want.";
            reciption = true;
        } else if (tellerTimer && !reciption && ((this.transform.position.z == customerServiceNode.transform.position.z && this.transform.position.x == customerServiceNode.transform.position.x)
            || (this.transform.position.z == tellerNodeTwo.transform.position.z && this.transform.position.x == tellerNodeTwo.transform.position.x)
            || (this.transform.position.z == tellerNodeOne.transform.position.z && this.transform.position.x == tellerNodeOne.transform.position.x))) {
                subtitle.text = "Assistant: This is not the Reciption!";
        }

        if (reciption) {
            timeAfterReciption -= Time.deltaTime;
            if (timeAfterReciption <= 0 && !ReciptionTimer) {
                subtitle.text = "Assistant: Congratulations! You are now familiar with the different departments\n that we can deal with in the bank.";
            } if (timeAfterReciption <= -6f) {
                ReciptionTimer = true;
            }
        }

        if (ReciptionTimer) {
            subtitle.text = "You can now explore the departments of the bank again if you want\n And when you are ready to leave go to the start position.";
            afterFinishTimer -= Time.deltaTime;
            if (afterFinishTimer <= 0) {
                if (this.transform.position.z == customerServiceNode.transform.position.z && this.transform.position.x == customerServiceNode.transform.position.x) {
                    subtitle.text = "Customer Service Employee: Hello sir, in here most of the bank's transactions are done from\n opening an account, inquiries and investments."+
                        " I will be at your service whenever you want";
                } else if ((this.transform.position.z == tellerNodeOne.transform.position.z && this.transform.position.x == tellerNodeOne.transform.position.x) 
                    || (this.transform.position.z == tellerNodeTwo.transform.position.z && this.transform.position.x == tellerNodeTwo.transform.position.x)) {
                        subtitle.text = "Tellers: Hello sir, here you can withdraw and deposit into your account whenever you want.";
                } else if (this.transform.position.z == reciptionNode.transform.position.z && this.transform.position.x == reciptionNode.transform.position.x) {
                    subtitle.text = "Receptionist: Hello sir, here you can receive your cards and\n collect checks whenever you want.";
                } else if (this.transform.position.z == stratingNode.transform.position.z && this.transform.position.x == stratingNode.transform.position.x) {
                    Vector3 endPoint = new Vector3();
                    endPoint.z = stratingNode.transform.position.z;
                    endPoint.x = stratingNode.transform.position.x;
                    endPoint.y = this.transform.position.y;
                    this.transform.position = endPoint;
                    subtitle.text = "";
                    endText.gameObject.SetActive(true);
                    endText.text = "Congratulations Level 1 Complete";
                    isLevelCompleted = true;
                    SceneLoader.setIsLevelCompleted(isLevelCompleted);
                }
            }
        }
        if (this.transform.position.z == officeDoorNode.transform.position.z && this.transform.position.x == officeDoorNode.transform.position.x) {
            subtitle.text = "Assistan: This is the manager office door, you are not suppose to be here today.\nPlease go back!";
        }    
    }   
}