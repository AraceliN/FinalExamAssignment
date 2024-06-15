using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject GameComponents;

    public RoundTracker roundTracker;
    public PowerMeterManager powerMeterManager;
    public TaskHoursManager taskHoursManager;
    public SwitchScreenManager switchScreenManager;

    public VaPlayerMovement VaPlayerMovement;
    public FoPlayerMovement FoPlayerMovement;
    public FrPlayerMovement FrPlayerMovement;
    public CPlayerMovement CPlayerMovement;

    void Start()
    {
        startScreen.SetActive(true);
        GameComponents.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        startScreen.SetActive(false);
        GameComponents.SetActive(true);
    }

    public void RestartGame()
    {

        VaPlayerMovement.ResetVanessa();
        FrPlayerMovement.ResetFreddy();
        FoPlayerMovement.ResetFoxy();
        CPlayerMovement.ResetChica();

        taskHoursManager.ResetHours();
        powerMeterManager.ResetPowerMeter();
        roundTracker.ResetRounds();

        switchScreenManager.ResetSwitchScreen();



    }

    public void Tutorial()
    {

    }
}
