using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatronicVisibility : MonoBehaviour
{

    public GameObject character;
    public SpriteRenderer spriteRenderer;
    public float transparency;
    
    public void MakeVisible()
    {
       Color col = spriteRenderer.color;
        col.a = 255;
        spriteRenderer.color = col;
    }
    public void MakeInVisible()
    {
        Color col = spriteRenderer.color;
        col.a = 0;
        spriteRenderer.color = col;
    }

}


