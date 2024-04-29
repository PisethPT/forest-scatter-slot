using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkEffectFont : MonoBehaviour
{
    private Color startColor = Color.yellow;
    private Color endColor = Color.white;
    [Range(1,10)]
    public float duration = 5;
    private Text render;

    void Awake()
    {
        render = GetComponent<Text>();
    }

    void Update()
    {
        render.color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time * duration,1));
    }
}
