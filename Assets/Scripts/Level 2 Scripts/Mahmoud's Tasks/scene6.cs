using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scene6 : MonoBehaviour
{
    public static Text subtitles;
//Place: Customer service
    public static string scene_6_Question(){
        return "Customer service: To open an account, you must have an ID and a proof of income.\nAre they available with you?";
    }
// Place: screen choices , Choose between: scene_6_Choice_1() & scene_6_Choice_2()
    //CHOICE ONE (correct choice)
        public static string scene_6_Choice_1(){
            return "Assistant: Yes, i have them";
        }
            //Result of choosing choice one
            public static string scene_6_Choice_1_Result_P1(){
                return "Customer service: Good, we'll now learn Procedure of opening an account";
            }
            public static string scene_6_Choice_1_Result_P2(){
                return "Customer service: We'll receive your ID and proof of income \n then you'll sign the necessary papers for opening your account\nthen you will go to deposit your money through the tellers";
                // Go to Teller, scene seven 
            }

    //CHOICE TWO (wrong choice)
        public static string scene_6_Choice_2(){
            return "Assistant: No, i don't have them";
        }
            //Result of choosing choice two
            public static string scene_6_Choice_2_Result_P1(){
                return "Customer service: You'll not be able to open your account for lack of required paper \n but we'll ignore that for now";
            }
            public static string scene_6_Choice_2_Result_P2(){
                return "Customer service: and we'll now learn Procedure of opening an account";
            }
            public static string scene_6_Choice_2_Result_P3(){
                return "Customer service: We'll receive your ID and proof of income \n then you'll sign the necessary papers for opening your account \n then you will go to deposit your money";
            }
            public static string scene_6_Question_2(){
                return "Assistant: Do you know where to deposit your money?";
            }

            //if tellers
            public static string scene_6_Choice2_Result1_P1(){
                return "Assistant: Correct!";
                //Go to the teller
            }

            public static string scene6_Choice2_Result2_P1(){
                return "Assistant: Think Again!";
            }
            
}
