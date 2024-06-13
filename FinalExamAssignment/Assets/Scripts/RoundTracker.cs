using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RoundTracker : MonoBehaviour
{
    public int roundNumber;

    public GameObject EndAnimatronicTurnButton;
    public TextMeshProUGUI roundNumberTxt;

    // Start is called before the first frame update
    void Start()
    {
        roundNumber = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextRound()
    {
        roundNumber += 1;
        roundNumberTxt.text = roundNumber.ToString("");

    }
}
