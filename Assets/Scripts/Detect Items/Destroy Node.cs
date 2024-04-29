using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyNode : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("node")){
         Destroy(other.gameObject);   
        }
    }
}
