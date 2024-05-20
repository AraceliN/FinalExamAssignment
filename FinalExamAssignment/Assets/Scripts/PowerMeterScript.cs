using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PowerMeterScript : MonoBehaviour
{
    public TextMeshProUGUI powerMeterText;
    public int PowerMeter;

    public void Start()
    {
        powerMeterText = GetComponent<TextMeshProUGUI>();
        PowerMeter = 20;
    }

}
