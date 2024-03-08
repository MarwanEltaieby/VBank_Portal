using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scene7 : MonoBehaviour
{
        public static Text subtitles;
//Place: Teller
    //Conversation between teller and assistant
    public static string scene_7_tellerQuestionAssistant(){
        return "Teller: Welcome, how can i help you?";
    }
    public static string scene_7_assistantAnswerTeller (){
        return "Assistant: I want to deposit 2000$ in my account";
    }
    public static string scene_7_tellerReplyToAssistant(){
        return "Teller: Ok Sir.\nIt has been deposited in your account";
    }
/*game states:
*-the level = 2
*-score = (2 / 2 )*100
*-the wallet = 0
*-the account = 19888
*-investment = 0
*/

}
