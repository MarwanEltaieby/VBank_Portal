using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Authentication : MonoBehaviour
{
    [SerializeField] private InputField usernameInput;
    [SerializeField] private InputField passwordInput;
    
    public void startLogin()
    {
        WebScript webScript = new WebScript();
        StartCoroutine(webScript.Login(usernameInput.text, passwordInput.text));
    }

    public void startSignUp()
    {
        WebScript webScript = new WebScript();
        StartCoroutine(webScript.RegisterUser(usernameInput.text, passwordInput.text));
        StartCoroutine(webScript.Login(usernameInput.text, passwordInput.text));
    }

}
