using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Property;
using Unity.VisualScripting;
using static Audios;

public class CheckWin : MonoBehaviour
{
    private IEnumerator GetNodeWin(Transform node1, Transform node2, Transform node3)
    {
        yield return new WaitForSeconds(2f);
        node1.gameObject.SetActive(false);
        node2.gameObject.SetActive(false);
        node3.gameObject.SetActive(false);

        node1.transform.position = property.targetObjectInstantRow1.position;
        node2.transform.position = property.targetObjectInstantRow2.position;
        node3.transform.position = property.targetObjectInstantRow3.position;
        yield return new WaitForSeconds(1f);

        node1.gameObject.SetActive(true);
        node2.gameObject.SetActive(true);
        node3.gameObject.SetActive(true);
        EnableAnimation(property.row1);
        EnableAnimation(property.row2);
        EnableAnimation(property.row3);

    }

    protected void GetNodeFromRows(string node1Name, string node2Name, string node3Name)
    {
        Transform node1 = CheckNodeBySpriteName(node1Name, property.row1);
        Transform node2 = CheckNodeBySpriteName(node2Name, property.row2);
        Transform node3 = CheckNodeBySpriteName(node3Name, property.row3);
        InstantEffect(node1);
        InstantEffect(node2);
        InstantEffect(node3);
        StartCoroutine(GetNodeWin(node1, node2, node3));
    }

    private void InstantEffect(Transform node)
    {
        Instantiate(property.effect, node);
    }

    private Transform CheckNodeBySpriteName(string nodesName, Transform[] rows)
    {
        Transform node = null;
        for (int i = 0; i < rows.Length; i++)
        {
            if (string.Compare(nodesName, rows[i].GetComponent<Image>().sprite.name) == 0)
            {
                node = rows[i].transform;
                if (node.GetComponent<BlinkEffect>() == null)
                    node.AddComponent<BlinkEffect>();
                
            }
        }
        return node;
    }

    private void EnableAnimation(Transform[] rows)
    {
        for (int i = 0; i < rows.Length; i++)
        {
            if (rows[i].GetComponent<BlinkEffect>() != null)
            {
                Destroy(rows[i].GetComponent<BlinkEffect>());
            }
            if (rows[i].childCount > 0)
            {
                Destroy(rows[i].GetChild(0).gameObject);
                print(rows[i].GetChild(0).gameObject.name);
            }
        }
    }

// 1.144409e-05
// 
}
