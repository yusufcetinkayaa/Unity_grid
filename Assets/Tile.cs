using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] public GameObject control;
    [SerializeField] public SpriteRenderer renderer;
    public void OnMouseDown()
    {
        control.SetActive(true);
        renderer.color = Color.black;
    }
}

