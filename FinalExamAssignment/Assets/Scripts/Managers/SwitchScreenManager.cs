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

    public GameObject Foxy;
    public GameObject Chica;
    public GameObject Freddy;
    public GameObject Vanessa;

    // Start is called before the first frame update
    private void Start()
    {
        Foxy.GetComponent<FoPlayerMovement>().enabled = false;
        Chica.GetComponent<CPlayerMovement>().enabled = false;
        Freddy.GetComponent<FrPlayerMovement>().enabled = false;
        Vanessa.GetComponent<VPlayerMovement>().enabled = false;

        EndVanessaTurnButton.SetActive(false);
        StartVanessaTurnButton.SetActive(true);

        EndAnimatronicTurnButton.SetActive(false);
        StartAnimatronicTurnButton.SetActive(false);
        GameView.SetActive(false);

        VanessaButtons.SetActive(false);
        AnimatronicButtons.SetActive(false);
    }

    public void StartVanessaTurn()
    {
        Vanessa.GetComponent<VPlayerMovement>().enabled = true;

        StartVanessaTurnButton.SetActive(false);

        GameView.SetActive(true);
        VanessaButtons.SetActive(true);

        EndVanessaTurnButton.SetActive(true);
    }

    public void EndVanessaTurn()
    {
        Foxy.GetComponent<FoPlayerMovement>().enabled = false;
        Chica.GetComponent<CPlayerMovement>().enabled = false;
        Freddy.GetComponent<FrPlayerMovement>().enabled = false;
        Vanessa.GetComponent<VPlayerMovement>().enabled = false;

        EndVanessaTurnButton.SetActive(false);

        VanessaButtons.SetActive(false);
        GameView.SetActive(false);

        StartAnimatronicTurnButton.SetActive(true);
    }

    public void StartAnimatronicTurn()
    {
        StartAnimatronicTurnButton.SetActive(false);

        GameView.SetActive(true);
        AnimatronicButtons.SetActive(true);

        EndAnimatronicTurnButton.SetActive(true);
    }

    public void EndAnimatronicTurn()
    {
        Foxy.GetComponent<FoPlayerMovement>().enabled = false;
        Chica.GetComponent<CPlayerMovement>().enabled = false;
        Freddy.GetComponent<FrPlayerMovement>().enabled = false;
        Vanessa.GetComponent<VPlayerMovement>().enabled = false;

        EndAnimatronicTurnButton.SetActive(false);

        AnimatronicButtons.SetActive(false);
        GameView.SetActive(false);

        StartVanessaTurnButton.SetActive(true);
    }





    //Animatronic Turn

    public void ChicaToMove()
    {
        Foxy.GetComponent<FoPlayerMovement>().enabled = false;
        Chica.GetComponent<CPlayerMovement>().enabled = true;
        Freddy.GetComponent<FrPlayerMovement>().enabled = false;
    }

    public void FoxyToMove()
    {
        Foxy.GetComponent<FoPlayerMovement>().enabled = true;
        Chica.GetComponent<CPlayerMovement>().enabled = false;
        Freddy.GetComponent<FrPlayerMovement>().enabled = false;
    }

    public void FreddyToMove()
    {
        Foxy.GetComponent<FoPlayerMovement>().enabled = false;
        Chica.GetComponent<CPlayerMovement>().enabled = false;
        Freddy.GetComponent<FrPlayerMovement>().enabled = true;
    }

}
