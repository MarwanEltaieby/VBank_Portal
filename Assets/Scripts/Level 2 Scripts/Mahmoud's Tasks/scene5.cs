using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scene5 : MonoBehaviour
{
    public static Text subtitles;
// Place: screen choices , Choose between: scene_5_Choice_1() & scene_5_Choice_2()
    //CHOICE ONE (correct choice)
        // public static string scene_5_Choice_1(){
        //     return "Assistant: I want to open a saving account";
        // }
            //Place:good choice screen
            //Result of choosing choice one
            public static string scene_5_Choice_1_Result_P1(){
                return "Assistant: Good choice";
            }
            public static string scene_5_Choice_1_Result_P2(){
                return "Assistant: You're now aware of the type of bank accounts and how it's employed ";
            }
            public static string scene_5_Choice_1_Result_P3(){
                return "Assistant: But always remember that there's costs that'll be subtracted from your gains";
            }
            public static string scene_5_Choice_1_Result_P4(){
                return "Assistant: and we'll come to it in time but first let's return to customer service\nto finish the necessary procedures";
                // Go to Customer service, scene six 
            }
    //CHOICE TWO (wrong choice)
        // public static string scene_5_Choice_2(){
        //     return "Assistant: I want to open a current account";
        // }
            //Place:Bad choice screen
            //Result of choosing choice two
            public static string scene_5_Choice_2_Result_P1(){
                return "Assistant: Maybe this is not the best choice accourding to your situation";
            }
            public static string scene_5_Choice_2_Result_P2(){
                return "Assistant: Because it deducts the account's cost from you without giving you interest";
            }
            public static string scene_5_Choice_2_Result_P3(){
                return "Assistant: and you in this case don't need quick withdrawals but the most apppropriate\nin this case is a saving account because it will give you benifites";
            }
            public static string scene_5_Choice_2_Result_P4(){
                return "Assistant: Let's choose again";
                //Repeat scene 5 again 
            }
}       