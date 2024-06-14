using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatronicAbility : MonoBehaviour
{

    public GameObject ChicaAbilityButton;
    public GameObject FoxyAbilityButton;
    public GameObject FreddyAbilityButton;
    public GameObject CupcakeButtons;
    public GameObject EndAnimatronicTurn;

    public RoundTracker RoundTracker;

    public void Start()
    {
        CupcakeButtons.SetActive(false);
    }
    public void AnimatronicAbilityUsage()
    {
        
        if (RoundTracker.roundNumber % 3 == 1)
        {
            FoxyAbilityButton.SetActive(false);
        }
        else if (RoundTracker.roundNumber % 3 == 2)
        {
            ChicaAbilityButton.SetActive(false);
            CupcakeButtons.SetActive(true);
            EndAnimatronicTurn.SetActive(false);
        }
        else
        {
            FreddyAbilityButton.SetActive(false);
        }
        
    }
}