using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPanelSwitch : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public GameObject panel6;
 
    
    void Start()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);    
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(false);
    }

    
}
