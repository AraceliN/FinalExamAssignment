using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Gamestate State;

    public static event Action<Gamestate> OnGameStateChanged;

    public void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateGameState(Gamestate.StartMenu);
    }

    public void UpdateGameState(Gamestate newstate)
    {
        State = newstate;

        switch (newstate)
        {
            case Gamestate.StartMenu:
                HandleStartMenu();
                break;
            case Gamestate.VanessaTurn:
                HandleVanessaTurn();
                break;
            case Gamestate.SwitchScreen:
                HandleSwitchScreen();
                break;
            case Gamestate.AnimatronicTurn:
                HandleAnimatronicTurn();
                break;
            case Gamestate.VanessaVictory:
                HandleVanessaVictory();
                break;
            case Gamestate.VanessaLoss:
                HandleVanessaLoss();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newstate), newstate, null);
        }

        OnGameStateChanged?.Invoke(newstate);
    }


    public void HandleStartMenu()
    {

    }

    public void HandleVanessaTurn()
    {

    }

    public void HandleSwitchScreen()
    {

    }

    public void HandleAnimatronicTurn()
    {

    }

    public void HandleVanessaVictory()
    {

    }

    public void HandleVanessaLoss()
    {

    }

}



public enum Gamestate
{
    StartMenu,
    VanessaTurn,
    SwitchScreen,
    AnimatronicTurn,
    VanessaVictory,
    VanessaLoss
}
