using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangingPages : MonoBehaviour
{

    [SerializeField] float SceneDelay = 5f;

    public void Play()
    {
        SceneManager.LoadScene("Play");
        //FindObjectOfType<GameSession>().Reset();
    }
    public void MainMeneu()
    {
        SceneManager.LoadScene(0);
        //FindObjectOfType<GameSession>().Reset();
    }
    public void Panel()
    {
        SceneManager.LoadScene("Panel");
        //FindObjectOfType<GameSession>().Reset();
    }
    public void Store()
    {
        SceneManager.LoadScene("Store");
        //FindObjectOfType<GameSession>().Reset();
    }
    public void GameOver()
    {
        StartCoroutine(Delay());


    }

    public void Exit()
    {
        Application.Quit();
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(SceneDelay);
        SceneManager.LoadScene("GameOver");

    }
}
