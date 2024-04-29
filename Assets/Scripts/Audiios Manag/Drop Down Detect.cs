using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Audios;

public class DropDownDetect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("node"))
        audios.dropDown.Play();
    }
}
