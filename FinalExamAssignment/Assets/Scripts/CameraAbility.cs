using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAbility : MonoBehaviour
{
    public VanessaTileTracker VanessaTileTracker;
    public TileTracker Chicatiletracker;
    public TileTracker Foxytiletracker;
    public TileTracker Freddytiletracker;

    public SpriteRenderer VanessaSprite;
    public SpriteRenderer ChicaSprite;
    public SpriteRenderer FoxySprite;
    public SpriteRenderer FreddySprite;

    public VanessaVisibility VanessaVisibility;

    public GameObject CameraButtons;
    public GameObject gameObject;
    public GameObject GuardActionButton;
    public GameObject EndVanessaTurnButton;

    public void checkCamera()
    {
        if (gameObject.name == Freddytiletracker.currentTile)
        {
            VanessaVisibility.MakeVisible(FreddySprite);
            
        }

        if (gameObject.name == Foxytiletracker.currentTile)
        {
            VanessaVisibility.MakeVisible(FoxySprite);
        }

        if (gameObject.name == Chicatiletracker.currentTile)
        {
            VanessaVisibility.MakeVisible(ChicaSprite);
        }

        if (gameObject.name == VanessaTileTracker.VcurrentTile)
        {
            VanessaVisibility.MakeVisible(VanessaSprite);
        }

        GuardActionButton.SetActive(true);
        CameraButtons.SetActive(false);
        EndVanessaTurnButton.SetActive(true);
    }

    
}
