using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterVisibility : MonoBehaviour
{

    public GameObject character;
    public float transparency;

    public VanessaTileTracker VanessaTileTracker;
    public TileTracker Chicatiletracker;
    public TileTracker Foxytiletracker;
    public TileTracker Freddytiletracker;
    public TileTracker Tiletracker;


    public SpriteRenderer VanessaSprite;
    public SpriteRenderer ChicaSprite;
    public SpriteRenderer FoxySprite;
    public SpriteRenderer FreddySprite;
    public SpriteRenderer SpriteRenderer;


    public void Update()
    {
        checkAnimatronicTile();
        CheckHallways();
        
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

    public void CheckHallways()
    {
        if (Tiletracker.currentTile == "HallwayB-D-P" || Tiletracker.currentTile == "HallwayA-D" || Tiletracker.currentTile == "HallwayD-S" || Tiletracker.currentTile == "HallwayS-S" || Tiletracker.currentTile == "HallwayA-S" ||
            Tiletracker.currentTile == "HallwayC-S" || Tiletracker.currentTile == "HallwayC-E" || Tiletracker.currentTile == "HallwayE-S-R" || Tiletracker.currentTile == "HallwayR-U" || Tiletracker.currentTile == "HallwayG-R" || 
            Tiletracker.currentTile == "HallwayB-R" || Tiletracker.currentTile == "HallwayK-R"|| Tiletracker.currentTile == "HallwayE-K" || Tiletracker.currentTile == "HallwayA-E" || Tiletracker.currentTile == "HallwayE-P" ||
            Tiletracker.currentTile == "HallwayW-P" || Tiletracker.currentTile == "HallwayS-W")
        {
            MakeVisible(SpriteRenderer);
        }
    }
    public void checkAnimatronicTile()
    {
        if (VanessaTileTracker.currentTile == Freddytiletracker.currentTile)
        {
            MakeVisible(FreddySprite);
            MakeVisible(VanessaSprite);
        }

        if (VanessaTileTracker.currentTile == Foxytiletracker.currentTile)
        {
            MakeVisible(FoxySprite);
            MakeVisible(VanessaSprite);
        }

        if (VanessaTileTracker.currentTile == Chicatiletracker.currentTile)
        {
            MakeVisible(ChicaSprite);
            MakeVisible(VanessaSprite);
        }

    }


}


