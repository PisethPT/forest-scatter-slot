using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Property;
public class DestroyNodesRow2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("node"))
        {
            other.transform.position = property.targetObjectInstantRow2.position;
        //     Destroy(other.gameObject);
        //    property.nodeRow2Amount--;
        }
    }
}
