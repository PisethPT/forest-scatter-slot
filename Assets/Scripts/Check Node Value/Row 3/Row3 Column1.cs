using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Row3Column1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("node")) Property._row3column1 = other.gameObject.GetComponent<Image>().sprite.name;
    }
}
