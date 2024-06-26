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
    public GameObject PowerMeterCanvas;
    public PowerMeterScript PowerMeterScript;

    public void Update()
    {
        if (PowerMeterScript.PowerMeter <= 0)
        {
            GuardActionsButtonsCanvas.SetActive(false);
            PowerMeterCanvas.SetActive(false);
            LoseCanvas.SetActive(true);
        }
    }

    //for the different canvases
    public void GuardActionIsPressed()
    {
        GuardActionsButtonsCanvas.SetActive(true);
        VanessaButtonCanvas.SetActive(false);
    }

    //when the button is pressed, it will call the text object and minus the specified number accordingly
    public void CameraButtonPressed()
    {
        PowerMeterScript.PowerMeter -= 1;
        PowerMeterScript.powerMeterText.text = PowerMeterScript.PowerMeter.ToString("");
        return;
    }

    public void CloseDoorButtonPressed()
    {
        PowerMeterScript.PowerMeter -= 1;
        PowerMeterScript.powerMeterText.text = PowerMeterScript.PowerMeter.ToString("");
        return;
    }

    public void UseFlashlightButtonPressed()
    {
        PowerMeterScript.PowerMeter -= 3;
        PowerMeterScript.powerMeterText.text = PowerMeterScript.PowerMeter.ToString("");
        return;
    }

    public void ProduceSoundButtonPressed()
    {
        PowerMeterScript.PowerMeter -= 3;
        PowerMeterScript.powerMeterText.text = PowerMeterScript.PowerMeter.ToString("");
        return;
    }

}

