using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterVisibility : MonoBehaviour
{

    public GameObject character;
    public float transparency;

    public VanessaTileTracker tileTracker;
    public TileTracker Chicatiletracker;
    public TileTracker Foxytiletracker;
    public TileTracker Freddytiletracker;

    public SpriteRenderer ChicaSprite;
    public SpriteRenderer FoxySprite;
    public SpriteRenderer FreddySprite;

    public void Update()
    {
        checkAnimatronicTile();
    }

    public void MakeVisible(SpriteRenderer spriteRenderer)
    {
       Color col = spriteRenderer.color;
        col.a = 255;
        spriteRenderer.color = col;
    }
    public void MakeInVisible(SpriteRenderer spriteRenderer)
    {
        Color col = spriteRenderer.color;
        col.a = 0;
        spriteRenderer.color = col;
    }

    public void checkAnimatronicTile()
    {
        if (tileTracker.VcurrentTile == Freddytiletracker.currentTile)
        {
            MakeVisible(FreddySprite);
        }

        if (tileTracker.VcurrentTile == Foxytiletracker.currentTile)
        {
            MakeVisible(FoxySprite);
        }

        if (tileTracker.VcurrentTile == Chicatiletracker.currentTile)
        {
            MakeVisible(ChicaSprite);
        }

    }
}


