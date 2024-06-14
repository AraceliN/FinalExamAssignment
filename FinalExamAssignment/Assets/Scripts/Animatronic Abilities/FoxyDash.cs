using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxyDash : MonoBehaviour
{
    public VanessaTileTracker VanessaTileTracker;
    public TileTracker Foxytiletracker;

    public SpriteRenderer VanessaSprite;
    public SpriteRenderer FoxySprite;

    public VanessaVisibility VanessaVisibility;

    public GameObject gameObject;
    public GameObject FoxyAbilityButton;
    public GameObject EndAnimatronicTurnButton;

    public void Dash()
    {

        FoxyAbilityButton.SetActive(false);
        EndAnimatronicTurnButton.SetActive(true);
    }


}