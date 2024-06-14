using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChicaCupcake : MonoBehaviour
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
    public GameObject ChicaAbilityButton;
    public GameObject EndAnimatronicTurnButton;

    public void PlaceCupcake()
    {

        if (gameObject.name == VanessaTileTracker.VcurrentTile)
        {
            VanessaVisibility.MakeVisible(VanessaSprite);
        }

        ChicaAbilityButton.SetActive(false);
        CameraButtons.SetActive(false);
        EndAnimatronicTurnButton.SetActive(true);
    }


}
