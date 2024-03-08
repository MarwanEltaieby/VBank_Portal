using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scene3 : MonoBehaviour
{
    public static Text subtitle;
// Place: screen choices , Choose between: scene_4() & scene_4_Choice_2() & scene_4_Choice_3()
        
            //Place:screen choices
            //Result of screen choices
            public static string scene_4_Result_P1(){
                return "Unsuccessful selection";
            }
            public static string scene_4_Result_P2(){
                return "The function of Tthe teller is summarized in withdrawals and deposits";
            }
            public static string scene_4_Result_P3(){
                return "Please select again";
            }
            
                // Go to action 3
            
    //CHOICE TWO (Right choice)
        public static string scene_4_Choice_2(){
            return "Good choice.\nLet's go to customer service";
        }
        
            //Movement avatar move towards the customer secvice
            //Update gamestatus (level =2, score = 100*(1/2), the wallet = 20000, the account = 0, investment = 0) 
        


            //Result of choosing choice three(bad choice)
            
            public static string scene_4_Choice_3_Result_P1(){
                return"Unsuccessful selection";
            }
            public static string scene_4_Choice_3_Result_P2(){
                return"The function of the receptionist Summarized in Receive Your cards and collecting checks";
            }
            public static string scene_4_Choice_3_Result_P3(){
                return"Please select again";
            }
            
                //Go to action 3
            
}   