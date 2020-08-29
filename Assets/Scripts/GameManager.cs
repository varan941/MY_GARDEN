using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public void RestartLevel()
    {
        Debug.Log("Tut");
        StartCoroutine(LoadLevel());

    }

    IEnumerator LoadLevel()
    {
        Debug.Log("Tut1");
        UIController.Instance.RunAnimation();
        Debug.Log("Tut2");
        yield return new WaitForSeconds(0.95f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
