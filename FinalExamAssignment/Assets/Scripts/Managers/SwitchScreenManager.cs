using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScreenManager : MonoBehaviour
{

    public GameObject EndVanessaTurnButton;
    public GameObject StartVanessaTurnButton;
    public GameObject EndAnimatronicTurnButton;
    public GameObject StartAnimatronicTurnButton;

    public GameObject VanessaButtons;
    public GameObject AnimatronicButtons;

    public GameObject GameView;

    // Start is called before the first frame update
    private void Start()
    {
        GameObject.Find("FoxySprite").GetComponent<FoPlayerMovement>().enabled = false;
        GameObject.Find("ChicaSprite").GetComponent<CPlayerMovement>().enabled = false;
        GameObject.Find("FreddySprite").GetComponent<FrPlayerMovement>().enabled = false;
        GameObject.Find("VanessaSprite").GetComponent<VPlayerMovement>().enabled = false;

        EndVanessaTurnButton.SetActive(false);
        StartVanessaTurnButton.SetActive(true);

        EndAnimatronicTurnButton.SetActive(false);
        StartAnimatronicTurnButton.SetActive(false);
        GameView.SetActive(false);
    }

    public void StartVanessaTurn()
    {
        GameObject.Find("VanessaSprite").GetComponent<VPlayerMovement>().enabled = true;

        StartVanessaTurnButton.SetActive(false);

        GameView.SetActive(true);

        EndVanessaTurnButton.SetActive(true);
    }

    public void EndVanessaTurn()
    {
        GameObject.Find("FoxySprite").GetComponent<FoPlayerMovement>().enabled = false;
        GameObject.Find("ChicaSprite").GetComponent<CPlayerMovement>().enabled = false;
        GameObject.Find("FreddySprite").GetComponent<FrPlayerMovement>().enabled = false;
        GameObject.Find("VanessaSprite").GetComponent<VPlayerMovement>().enabled = false;

        EndVanessaTurnButton.SetActive(false);

        GameView.SetActive(false);

        StartAnimatronicTurnButton.SetActive(true);
    }

    public void StartAnimatronicTurn()
    {
        StartAnimatronicTurnButton.SetActive(false);

        GameView.SetActive(true);

        EndAnimatronicTurnButton.SetActive(true);
    }

    public void EndAnimatronicTurn()
    {
        GameObject.Find("FoxySprite").GetComponent<FoPlayerMovement>().enabled = false;
        GameObject.Find("ChicaSprite").GetComponent<CPlayerMovement>().enabled = false;
        GameObject.Find("FreddySprite").GetComponent<FrPlayerMovement>().enabled = false;
        GameObject.Find("VanessaSprite").GetComponent<VPlayerMovement>().enabled = false;

        EndAnimatronicTurnButton.SetActive(false);

        GameView.SetActive(true);

        StartVanessaTurnButton.SetActive(true);
    }
}
