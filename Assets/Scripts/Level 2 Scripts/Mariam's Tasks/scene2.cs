using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scene2 : MonoBehaviour
{
    public static Text subtitle;
// Place: inside the bank in front of the gate 
        public static string scene_4_P1(){
            string text = "Assistant: Hello, I knew you wanted to invest a sum of money. "; 
            return text;
            }

        public static string scene_4_P2(){
            string text = "Assistant: Our first task is to open an account, let's inquire about that."; 
            return text;
            }

         public static string scene_4_P3(){
            string text = "Where should we go?"; 
            return text;
            }
}