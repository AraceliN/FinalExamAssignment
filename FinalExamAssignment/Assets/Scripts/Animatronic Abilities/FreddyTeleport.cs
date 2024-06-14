using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreddyTeleport : MonoBehaviour
{
    public VanessaTileTracker VanessaTileTracker;
    public TileTracker Freddytiletracker;

    public SpriteRenderer VanessaSprite;
    public SpriteRenderer FreddySprite;

    public VanessaVisibility VanessaVisibility;

    public GameObject TeleportButtons;
    public GameObject gameObject;
    public GameObject FreddyAbilityButton;
    public GameObject EndAnimatronicTurnButton;

    public void Teleportation()
    {

        

        FreddyAbilityButton.SetActive(false);
        TeleportButtons.SetActive(false);
        EndAnimatronicTurnButton.SetActive(true);
    }


}