using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Row1Column2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("node")) Property._row1column2 = other.gameObject.GetComponent<Image>().sprite.name;
    }
}
