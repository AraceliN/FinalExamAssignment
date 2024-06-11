using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPanelSwitch : MonoBehaviour
{
    public GameObject panel0;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public GameObject panel6;
    public GameObject VanessaStartTurnButton;
 
    
    void Start()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);    
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(false);
    }

    public void ToPage1()
    {
        panel0.SetActive(false);
        panel1.SetActive(true);
    }

    public void ToPage2()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }

    public void ToPage3()
    {
        panel2.SetActive(false);
        panel3.SetActive(true);
    }

    public void ToPage4()
    {
        panel3.SetActive(false);
        panel4.SetActive(true);
    }

    public void ToPage5()
    {
        panel4.SetActive(false);
        panel5.SetActive(true);
    }

    public void ToPage6()
    {
        panel5.SetActive(false);
        panel6.SetActive(true);
    }

    public void StartPlaying()
    {
        panel6.SetActive(false);
        VanessaStartTurnButton.SetActive(true);
    }

    
}
