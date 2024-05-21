using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablePanels : MonoBehaviour
{
    public GameObject Panel;

    public void PanelEnable()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;


            Panel.SetActive(!isActive);
        }
    }
}
