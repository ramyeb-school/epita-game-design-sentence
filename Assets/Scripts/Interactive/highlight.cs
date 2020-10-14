using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highlight : MonoBehaviour
{
    // Fade the color from the orignial to yellow
    // back and forth over the defined duration

    Color colorStart;
    Color colorEnd = Color.yellow;
    void Awake()
    {
        colorStart = GetComponent<Renderer>().material.color;
    }
    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.Lerp(colorStart, colorEnd, 0.5f);
    }
    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = colorStart;
    }

}