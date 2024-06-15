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
        if (VanessaTileTracker.VcurrentTile == "HallwayB-D-P" || VanessaTileTracker.VcurrentTile == "HallwayA-D" || VanessaTileTracker.VcurrentTile == "HallwayD-S" || VanessaTileTracker.VcurrentTile == "HallwayS-S" || 
            VanessaTileTracker.VcurrentTile == "HallwayA-S" ||  VanessaTileTracker.VcurrentTile == "HallwayC-S" || VanessaTileTracker.VcurrentTile == "HallwayC-E" || VanessaTileTracker.VcurrentTile == "HallwayE-S-R" ||
            VanessaTileTracker.VcurrentTile == "HallwayR-U" || VanessaTileTracker.VcurrentTile == "HallwayG-R" ||  VanessaTileTracker.VcurrentTile == "HallwayB-R" || VanessaTileTracker.VcurrentTile == "HallwayK-R" || 
            VanessaTileTracker.VcurrentTile == "HallwayE-K" || VanessaTileTracker.VcurrentTile == "HallwayA-E" || VanessaTileTracker.VcurrentTile == "HallwayE-P" ||
            VanessaTileTracker.VcurrentTile == "HallwayW-P" || VanessaTileTracker.VcurrentTile == "HallwayS-W")
        {
            MakeVisible(SpriteRenderer);
        }
    }
    public void checkAnimatronicTile()
    {
        if (VanessaTileTracker.VcurrentTile == Freddytiletracker.currentTile)
        {
            MakeVisible(FreddySprite);
            MakeVisible(VanessaSprite);
            CanUseFlashLight = true;
        }

        if (VanessaTileTracker.VcurrentTile == Foxytiletracker.currentTile)
        {
            MakeVisible(FoxySprite);
            MakeVisible(VanessaSprite);
            CanUseFlashLight = true;
        }

        if (VanessaTileTracker.VcurrentTile == Chicatiletracker.currentTile)
        {
            MakeVisible(ChicaSprite);
            MakeVisible(VanessaSprite);
            CanUseFlashLight = true;
        }

        if (VanessaTileTracker.VcurrentTile != Chicatiletracker.currentTile && VanessaTileTracker.VcurrentTile != Foxytiletracker.currentTile && VanessaTileTracker.VcurrentTile != Freddytiletracker.currentTile)
        {
            CanUseFlashLight = false;

        }

    }
}
