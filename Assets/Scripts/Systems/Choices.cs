using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choices : MonoBehaviour
{
    private bool timerActive = false;
    private float timeRequired = 1f;
    public GameObject player;
    public static int choice = 0;

    // Method for turning the object cyan on gaze
    public void toCyan()
    {
        this.GetComponent<Renderer>().material.color = Color.cyan;
        // Boolean value that starts the timer
        timerActive = true;
    }

    //Method for turning the color to white when stop gazing
    public void toWhite()
    {
        this.GetComponent<Renderer>().material.color = Color.white;
        //Switching the boolean value that starts the timer back to false
        timerActive = false;
        //Revalue the timer to its original value
        timeRequired = 1f;
    }

    private void Update() 
    {
        // A condition to start the timer
        if (timerActive == true)
        {
            timeRequired = timeRequired - Time.deltaTime;
            // A condition to check if the timer is less than 0
            if (timeRequired <= 0) // put whatever you want to happen under this if statement
            {
                // I will check the Tag if it is a right choice or a wrong choice
                switch (gameObject.tag)
                {
                    case "Right Choice":
                        this.GetComponent<Renderer>().material.color = Color.green;
                        choice = 1;
                        break;

                    case "Wrong Choice":
                        this.GetComponent<Renderer>().material.color = Color.red;
                        choice = -1;
                        toWhite();
                        break;

                    case "Wrong Choice Two":
                        this.GetComponent<Renderer>().material.color = Color.red;
                        choice = -2;
                        toWhite();
                        break;    
                }
            }
        }
    }

    public static void setChoice(int newChoice)
    {
        choice = newChoice;
    }

    public static int getChoice()
    {
        return choice;
    }
}
