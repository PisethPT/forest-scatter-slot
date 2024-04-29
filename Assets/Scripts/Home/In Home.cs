using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InHome : MonoBehaviour
{
    public AudioSource click;
    public void GoGamePlay()
    {
        click.Play();
        SceneManager.LoadScene("slot");
    }
    public void ExitGame()
    {
        click.Play();
        Application.Quit();
    }
}
