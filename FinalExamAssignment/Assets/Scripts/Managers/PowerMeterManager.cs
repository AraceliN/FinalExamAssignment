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
    public PowerMeterScript PowerMeterScript;
    public GameObject SwitchScreen;
    public TaskHoursManager taskHoursManager;
    public GameObject DoorsDropdown;

    private void Start()
    {
        DoorsDropdown.SetActive(false);
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
        PowerMeterScript.PowerMeter -= 1;
        PowerMeterScript.powerMeterText.text = PowerMeterScript.PowerMeter.ToString("");
        GuardActionButton.SetActive(true);
        GuardActionsButtonsCanvas.SetActive(false);
        return;

    }

    public void CloseDoorButtonPressed()
    {
        PowerMeterScript.PowerMeter -= 1;
        PowerMeterScript.powerMeterText.text = PowerMeterScript.PowerMeter.ToString("");
        //GuardActionButton.SetActive(true); //instead the dropdown where the player will enable only two doors will be set active,after that the guard actions button will then be enabled. 
        DoorsDropdown.SetActive(true);
        GuardActionsButtonsCanvas.SetActive(false);
        return;
    }

    public void UseFlashlightButtonPressed()
    {
        PowerMeterScript.PowerMeter -= 3;
        PowerMeterScript.powerMeterText.text = PowerMeterScript.PowerMeter.ToString("");
        GuardActionButton.SetActive(true);
        GuardActionsButtonsCanvas.SetActive(false);
        return;
    }

    public void ProduceSoundButtonPressed()
    {
        PowerMeterScript.PowerMeter -= 3;
        PowerMeterScript.powerMeterText.text = PowerMeterScript.PowerMeter.ToString("");
        GuardActionButton.SetActive(true);
        GuardActionsButtonsCanvas.SetActive(false);
        return;
    }

}

