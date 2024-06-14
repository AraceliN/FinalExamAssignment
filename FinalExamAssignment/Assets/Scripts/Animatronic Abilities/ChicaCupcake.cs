using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChicaCupcake : MonoBehaviour
{
    public VanessaTileTracker VanessaTileTracker;

    public SpriteRenderer VanessaSprite;
   
    public VanessaVisibility VanessaVisibility;

    public GameObject CupcakeButtons;
    public GameObject gameObject;
    public GameObject EndAnimatronicTurnButton;
    public GameObject AnimatronicAbilityCanvas;

    public GameObject Chica;
    public GameObject Foxy;
    public GameObject Freddy;

    public void PlaceCupcake()
    {

        if (gameObject.name == VanessaTileTracker.VcurrentTile)
        {
            VanessaVisibility.MakeVisible(VanessaSprite);
        }

       
        CupcakeButtons.SetActive(false);
        EndAnimatronicTurnButton.SetActive(true);
        AnimatronicAbilityCanvas.SetActive(true);

        Foxy.SetActive(true);
        Freddy.SetActive(true);
        Chica.SetActive(true);
    }

}
