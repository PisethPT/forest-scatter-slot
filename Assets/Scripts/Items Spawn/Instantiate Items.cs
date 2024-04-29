using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Property;

public class InstantiateItems : MonoBehaviour
{
    private float timeSpawn = .3f, timer = 10f;
    private void FixedUpdate()
    {
        if (!property.boxCollider2Ds[0].enabled &&property.nodeRow1Amount < 10)
        {
            InstantNode(property.targetObjectInstantRow1, property.nodeRow1Amount);
        }
        if (!property.boxCollider2Ds[1].enabled && property.nodeRow2Amount < 10)
        {
            InstantNode(property.targetObjectInstantRow2, property.nodeRow2Amount);
        }
        if (!property.boxCollider2Ds[2].enabled && property.nodeRow3Amount < 10)
        {
            InstantNode(property.targetObjectInstantRow3, property.nodeRow3Amount);
        }
    }
    private void InstantNode(Transform transformTarget, int amount)
    {
        timeSpawn -= Time.deltaTime;
        if (timeSpawn <= 0)
        {
            int nodeSpritesIndex = Random.Range(0, property.nodeSprites.Length);
            var node = Instantiate(property.nodeObject, transformTarget);
            node.GetComponent<Image>().sprite = property.nodeSprites[nodeSpritesIndex];
            node.transform.SetParent(property.nodeParent);
            timeSpawn = .3f;
            amount++;
        }
    }
}
