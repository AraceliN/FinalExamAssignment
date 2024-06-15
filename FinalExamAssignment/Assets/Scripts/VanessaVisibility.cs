using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanessaVisibility : MonoBehaviour
{
    public GameObject character;
    public float transparency;

    public VanessaTileTracker VanessaTileTracker;
    public TileTracker Chicatiletracker;
    public TileTracker Foxytiletracker;
    public TileTracker Freddytiletracker;



    public SpriteRenderer VanessaSprite;
    public SpriteRenderer ChicaSprite;
    public SpriteRenderer FoxySprite;
    public SpriteRenderer FreddySprite;
    public SpriteRenderer SpriteRenderer;
    public bool CanUseFlashLight;

    public void Start()
    {
        CanUseFlashLight = false;
    }

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
        if (VanessaTileTracker.currentTile == "HallwayB-D-P" || VanessaTileTracker.currentTile == "HallwayA-D" || VanessaTileTracker.currentTile == "HallwayD-S" || VanessaTileTracker.currentTile == "HallwayS-S" || 
            VanessaTileTracker.currentTile == "HallwayA-S" ||  VanessaTileTracker.currentTile == "HallwayC-S" || VanessaTileTracker.currentTile == "HallwayC-E" || VanessaTileTracker.currentTile == "HallwayE-S-R" ||
            VanessaTileTracker.currentTile == "HallwayR-U" || VanessaTileTracker.currentTile == "HallwayG-R" ||  VanessaTileTracker.currentTile == "HallwayB-R" || VanessaTileTracker.currentTile == "HallwayK-R" || 
            VanessaTileTracker.currentTile == "HallwayE-K" || VanessaTileTracker.currentTile == "HallwayA-E" || VanessaTileTracker.currentTile == "HallwayE-P" ||
            VanessaTileTracker.currentTile == "HallwayW-P" || VanessaTileTracker.currentTile == "HallwayS-W")
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
            CanUseFlashLight = true;
        }

        if (VanessaTileTracker.currentTile == Foxytiletracker.currentTile)
        {
            MakeVisible(FoxySprite);
            MakeVisible(VanessaSprite);
            CanUseFlashLight = true;
        }

        if (VanessaTileTracker.currentTile == Chicatiletracker.currentTile)
        {
            MakeVisible(ChicaSprite);
            MakeVisible(VanessaSprite);
            CanUseFlashLight = true;
        }

        if (VanessaTileTracker.currentTile != Chicatiletracker.currentTile && VanessaTileTracker.currentTile != Foxytiletracker.currentTile && VanessaTileTracker.currentTile != Freddytiletracker.currentTile)
        {
            CanUseFlashLight = false;

        }

    }
}
