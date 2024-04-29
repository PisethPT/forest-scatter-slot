using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Row1Column3 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("node")) Property._row1column3 = other.gameObject.GetComponent<Image>().sprite.name;
    }
}
