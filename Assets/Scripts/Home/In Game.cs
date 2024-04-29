using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Audios;
public class InGame : MonoBehaviour
{
    public void GoHome()
    {
        audios.click.Play();
        SceneManager.LoadScene("home");
    }
}
