using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangingPages : MonoBehaviour
{

    [SerializeField] float SceneDelay = 5f;
    [SerializeField] GameObject Settingmeneu;
    [SerializeField] AudioClip Bubble;
    [Range(0f, 1f)] [SerializeField] float Volume = 0.1f;
    [SerializeField] GameObject music;
    //public string X;

    public void mute()
    {
      /*if (music.SetActive(false))
        {
            music.SetActive(true);
        }
        else
        {
            music.SetActive(false);
        }*/
        AudioSource.PlayClipAtPoint(Bubble, Camera.main.transform.position, Volume);
    }
    public void popup()
    {
        Settingmeneu.SetActive(true);
        AudioSource.PlayClipAtPoint(Bubble, Camera.main.transform.position, Volume);
    }
    public void Play()
    {
        StartCoroutine(Delay());
        //string X = "Play";
        SceneManager.LoadScene("Play");
        //FindObjectOfType<GameSession>().Reset();
    }
    public void MainMeneu()
    {
        StartCoroutine(Delay());
        //string X = "Start";
        SceneManager.LoadScene("Start");
        //FindObjectOfType<GameSession>().Reset();
    }
    public void Panel()
    {
        StartCoroutine(Delay());
        //string X = "Panel1";
        SceneManager.LoadScene("Panel1");
        //FindObjectOfType<GameSession>().Reset();
    }
    public void Store()
    {
        StartCoroutine(Delay());
        //string X = "Store";
        SceneManager.LoadScene("Store1");
        //FindObjectOfType<GameSession>().Reset();
    }
    public void GameOver()
    {
        StartCoroutine(Delay());
    }
    public void Exit()
    {
        StartCoroutine(Delay());
        Application.Quit();
    }
    IEnumerator Delay()
    {
        AudioSource.PlayClipAtPoint(Bubble, Camera.main.transform.position, Volume);
        //SceneManager.LoadScene(X);
        yield return new WaitForSeconds(SceneDelay);
        
    }
}
