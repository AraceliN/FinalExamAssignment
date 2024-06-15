using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PowerMeterManager : MonoBehaviour
{
    public GameObject GuardActionsButtonsCanvas;
    public GameObject VanessaButtonCanvas;
    public GameObject LoseCanvas;
    public GameObject WinCanvas;
    public GameObject GuardActionButton;
    public GameObject PowerMeterCanvas;
    public GameObject EndVanessaTurnButton;
    public GameObject Vanessa;

    public GameObject CameraButtons;

    public PowerMeterScript PowerMeterScript;
    public GameObject SwitchScreen;
    public TaskHoursManager taskHoursManager;
    public RoundTracker roundTracker;
    public FlashlightAbility FlashLightAbility;

    public void Start()
    {
        CameraButtons.SetActive(false);
    }

    public void Update()
    {
        if (PowerMeterScript.PowerMeter <= -1)
        {
            GuardActionsButtonsCanvas.SetActive(false);
            PowerMeterCanvas.SetActive(false);
            LoseCanvas.SetActive(true);
            SwitchScreen.SetActive(false);

        }

        else if (PowerMeterScript.PowerMeter >= 1 && taskHoursManager.totalHours == 6)
        {
            GuardActionsButtonsCanvas.SetActive(false);
            PowerMeterCanvas.SetActive(false);
            WinCanvas.SetActive(true);
            SwitchScreen.SetActive(false);
        }
    }

    //for the different canvases
    public void GuardActionIsPressed()
    {
        GuardActionsButtonsCanvas.SetActive(true);
        GuardActionButton.SetActive(false);
        VanessaButtonCanvas.SetActive(true);
    }

    //when the button is pressed, it will call the text object and minus the specified number accordingly
    public void CameraButtonPressed()
    {
        if (roundTracker.extraCam)
        {
            PowerMeterScript.PowerMeter -= 0 ;
        }
        else
        {
        PowerMeterScript.PowerMeter -= 1;
        }
        roundTracker.extraCam = false;

        PowerMeterScript.powerMeterText.text = PowerMeterScript.PowerMeter.ToString("");
        GuardActionsButtonsCanvas.SetActive(false);
        CameraButtons.SetActive(true);
        EndVanessaTurnButton.SetActive(false);
        Vanessa.SetActive(false);
        return;

    }

    public void CloseDoorButtonPressed()
    {
        PowerMeterScript.PowerMeter -= 1;
        PowerMeterScript.powerMeterText.text = PowerMeterScript.PowerMeter.ToString("");
        GuardActionButton.SetActive(true);
        GuardActionsButtonsCanvas.SetActive(false);
        return;
    }

    public void UseFlashlightButtonPressed()
    {
        PowerMeterScript.PowerMeter -= 3;
        PowerMeterScript.powerMeterText.text = PowerMeterScript.PowerMeter.ToString("");
        GuardActionsButtonsCanvas.SetActive(false);
        EndVanessaTurnButton.SetActive(false);
        Vanessa.SetActive(false);
        FlashLightAbility.ActivateFlashLightButtons();
        return;
    }

    public void ProduceSoundButtonPressed()
    {
        PowerMeterScript.PowerMeter -= 3;
        PowerMeterScript.powerMeterText.text = PowerMeterScript.PowerMeter.ToString("");
        GuardActionsButtonsCanvas.SetActive(false);
        EndVanessaTurnButton.SetActive(false);
        Vanessa.SetActive(false);
        return;
    }

    public void ResetPowerMeter()
    {
        PowerMeterScript.PowerMeter = 20;
        PowerMeterScript.powerMeterText.text = PowerMeterScript.PowerMeter.ToString("");

    }

}

