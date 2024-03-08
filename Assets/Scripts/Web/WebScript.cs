using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

// UnityWebRequest.Get example

// Access a website and use UnityWebRequest.Get to download a page.
// Also try to download a non-existing page. Display the error.

public class WebScript : MonoBehaviour
{
    void Start()
    {
        // A correct website page.
        // StartCoroutine(GetUsers("http://localhost/UnityBackend/GetUsers.php"));
        // StartCoroutine(Login("Marwan", "123456"));
        // StartCoroutine(RegisterUser("LoginUser1", "456789"));
    }

    public IEnumerator GetUsers(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            if (webRequest.isNetworkError || webRequest.isHttpError)
            {
                Debug.Log(webRequest.error);
            }
            else
            {
                Debug.Log(webRequest.downloadHandler.text);

                byte[] results = webRequest.downloadHandler.data;
            }
        }
    }

    public IEnumerator Login(string username, string password)
    {
        WWWForm form = new WWWForm();
        string deviceID = SystemInfo.deviceUniqueIdentifier;
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);
        form.AddField("loginID", deviceID);
        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/UnityBackend/Login.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }

    public IEnumerator RegisterUser(string username, string password)
    {
        WWWForm form = new WWWForm();
        string deviceID = SystemInfo.deviceUniqueIdentifier;
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);
        form.AddField("loginID", deviceID);
        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/UnityBackend/RegisterUser.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }
}
