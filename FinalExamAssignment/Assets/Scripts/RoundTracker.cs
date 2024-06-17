using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RoundTracker : MonoBehaviour
{
    public int roundNumber;

    public GameObject EndAnimatronicTurnButton;
    public GameObject AnimatronicTurnButton;
    public GameObject VanessaTurnButton;

    public GameObject ChicaAbilityButton;
    public GameObject FoxyAbilityButton;
    public GameObject FreddyAbilityButton;

    public TaskHoursManager taskHoursManager;

    public TextMeshProUGUI roundNumberTxt;
    public bool isVanessaTurn;
    public bool extraCam;

    public FoPlayerMovement foPlayerMovement;

    // Start is called before the first frame update
    void Start()
    {
        roundNumber = 1;
        isVanessaTurn = true;
         extraCam = false;
        FreddyAbilityButton.SetActive(false);
        ChicaAbilityButton.SetActive(false);

    }

    public void VanessaTurn()
    {
        isVanessaTurn = true;
    }

    public void AnimatronicTurn()
    {
        isVanessaTurn = false;
    }



    public void NextRound()
    {
        if (taskHoursManager.freecam == true)
        {
            extraCam = true;
        }
        roundNumber += 1;
        roundNumberTxt.text = roundNumber.ToString("");

        if (roundNumber % 3 == 1)
        {
            FoxyAbilityButton.SetActive(true);
            foPlayerMovement.DashAmount = foPlayerMovement.DashAmount + 4;
            FreddyAbilityButton.SetActive(false);
            ChicaAbilityButton.SetActive(false);
        }
        else if (roundNumber % 3 == 2)
        {
            ChicaAbilityButton.SetActive(true);
            FoxyAbilityButton.SetActive(false);
            FreddyAbilityButton.SetActive(false);
        }
        else
        {
            FreddyAbilityButton.SetActive(true);
            FoxyAbilityButton.SetActive(false);
            ChicaAbilityButton.SetActive(false);
        }

    }

    public void ResetRounds()
    {
        roundNumber = 1;
        isVanessaTurn = true;
        extraCam = false;
        FreddyAbilityButton.SetActive(false);
        ChicaAbilityButton.SetActive(false);
    }


}