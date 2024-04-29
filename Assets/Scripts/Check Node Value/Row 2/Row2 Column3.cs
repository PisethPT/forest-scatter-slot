using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Row2Column3 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("node")) Property._row2column3 = other.gameObject.GetComponent<Image>().sprite.name;
    }
}
