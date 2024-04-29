using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audios : MonoBehaviour
{
    public static Audios audios;
    public AudioSource music, click, spin, dropDown, win;
    public Sprite[] musicSprits;
    public Image musicImage;
    private bool musicSpritsLoaded = true;

    void Awake()
    {
        audios = this;
    }
    public void MusicPlay()
    {
        musicSpritsLoaded = !musicSpritsLoaded;
        if (musicSpritsLoaded)
        {
            music.mute = false;
            musicImage.sprite = musicSprits[0];
        }
        else if (!musicSpritsLoaded)
        {
            music.mute = true;
            musicImage.sprite = musicSprits[1];
        }
    }
}
