using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private static bool isLevelCompleted = false;
    public Animator transition;

    // Update is called once per frame
    void Update()
    {
        if (isLevelCompleted) 
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(levelIndex);
        isLevelCompleted = false;
    }

    public static void setIsLevelCompleted(bool isCompleted)
    {
        isLevelCompleted = isCompleted;
    }

    public static bool getIsLevelCompleted()
    {
        return isLevelCompleted;
    }
    
}
