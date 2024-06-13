using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RoundTracker : MonoBehaviour
{
    public int roundNumber;

    public GameObject EndAnimatronicTurnButton;
    public TextMeshProUGUI roundNumberTxt;
    public bool isVanessaTurn;

    // Start is called before the first frame update
    void Start()
    {
        roundNumber = 1;
        isVanessaTurn = true;
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
        roundNumber += 1;
        roundNumberTxt.text = roundNumber.ToString("");

    }
}
