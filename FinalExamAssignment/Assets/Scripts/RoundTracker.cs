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

    public TaskHoursManager taskHoursManager;

    public TextMeshProUGUI roundNumberTxt;
    public bool isVanessaTurn;
    public bool extraCam;

    // Start is called before the first frame update
    void Start()
    {
        roundNumber = 1;
        isVanessaTurn = true;
         extraCam = false;
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

    }
}