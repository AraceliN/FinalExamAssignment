using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorAbility : MonoBehaviour
{
    public GameObject Kitchen_left;
    public GameObject Kitchen_top;
    public GameObject EastHall_right;
    public GameObject EastHall_left;
    public GameObject EastHall_top;
    public GameObject PrizeCorner_right;
    public GameObject PrizeCorner_left;
    public GameObject WestHall_right;
    public GameObject WestHall_left;
    public GameObject WestHall_top;
    public GameObject SupplyCloset_right;
    public GameObject PirateCove_right;
    public GameObject PirateCove_top;
    public GameObject Backroom_right;
    public GameObject DiningArea_left;
    public GameObject DiningArea_bottom;
    public GameObject DiningArea_right;
    public GameObject ControlRoom_right;
    public GameObject ControlRoom_bottom;
    public GameObject Stage_top;
    public GameObject Stage_bottom;
    public GameObject Security_left;
    public GameObject Security_top;
    public GameObject Security_bottom;
    public GameObject Security_right;
    public GameObject Arcade_bottom;
    public GameObject Arcade_top;
    public GameObject Arcade_left;
    public GameObject Entrance_bottom;
    public GameObject Entrance_left;
    public GameObject Restrooms_left;
    public GameObject Restrooms_rightTop;
    public GameObject Restrooms_rightBottom;
    public GameObject Restrooms_top;
    public GameObject Restrooms_bottom;
    public GameObject Unisex_bottom;
    public GameObject Girls_left;
    public GameObject Boys_left;
    public GameObject Dropdown;
    public GameObject GuardActionsButton;

    int numberofSelections;
    int maxSelections = 2;
    bool selected2 = false;


    private void Update()
    {
        if (maxSelections == numberofSelections)
        {
            selected2 = true;
        }
    }

    public void Reset()
    {
        if (selected2 == true)
        {
            Dropdown.SetActive(false);
            GuardActionsButton.SetActive(true);
            numberofSelections = 0;
            selected2 = false;
        }
    }


    private void Start()
    {
        Kitchen_left.SetActive(false);
        Kitchen_top.SetActive(false);
        EastHall_right.SetActive(false);
        EastHall_left.SetActive(false);
        EastHall_top.SetActive(false);
        PrizeCorner_right.SetActive(false);
        PrizeCorner_left.SetActive(false);
        WestHall_right.SetActive(false);
        WestHall_left.SetActive(false);
        WestHall_top.SetActive(false);
        SupplyCloset_right.SetActive(false);
        PirateCove_right.SetActive(false);
        PirateCove_top.SetActive(false);
        Backroom_right.SetActive(false);
        DiningArea_bottom.SetActive(false);
        DiningArea_left.SetActive(false);
        DiningArea_right.SetActive(false);
        ControlRoom_bottom.SetActive(false);
        ControlRoom_right.SetActive(false);
        Stage_bottom.SetActive(false);
        Stage_top.SetActive(false);
        Security_bottom.SetActive(false);
        Security_left.SetActive(false);
        Security_right.SetActive(false);
        Security_top.SetActive(false);
        Arcade_bottom.SetActive(false);
        Arcade_left.SetActive(false);
        Arcade_top.SetActive(false);
        Entrance_bottom.SetActive(false);
        Entrance_left.SetActive(false);
        Restrooms_bottom.SetActive(false);
        Restrooms_left.SetActive(false);
        Restrooms_rightTop.SetActive(false);
        Restrooms_rightBottom.SetActive(false);
        Restrooms_top.SetActive(false);
        Unisex_bottom.SetActive(false);
        Girls_left.SetActive(false);
        Boys_left.SetActive(false);
    }

    public void Selectdoors(int index)
    {
        switch (index)
        {
            case 0:


            case 1:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Kitchen_left.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 2:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Kitchen_top.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 3:
                if (selected2 == false)
                {
                    numberofSelections++;
                    EastHall_right.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 4:
                if (selected2 == false)
                {
                    numberofSelections++;
                    EastHall_left.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 5:
                if (selected2 == false)
                {
                    numberofSelections++;
                    EastHall_top.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 6:
                if (selected2 == false)
                {
                    numberofSelections++;
                    PrizeCorner_right.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 7:
                if (selected2 == false)
                {
                    numberofSelections++;
                    PrizeCorner_left.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 8:
                if (selected2 == false)
                {
                    numberofSelections++;
                    WestHall_right.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 9:
                if (selected2 == false)
                {
                    numberofSelections++;
                    WestHall_left.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 10:
                if (selected2 == false)
                {
                    numberofSelections++;
                    WestHall_top.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 11:
                if (selected2 == false)
                {
                    numberofSelections++;
                    SupplyCloset_right.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 12:
                if (selected2 == false)
                {
                    numberofSelections++;
                    PirateCove_right.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 13:
                if (selected2 == false)
                {
                    numberofSelections++;
                    PirateCove_top.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 14:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Backroom_right.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 15:
                if (selected2 == false)
                {
                    numberofSelections++;
                    DiningArea_left.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 16:
                if (selected2 == false)
                {
                    numberofSelections++;
                    DiningArea_bottom.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 17:
                if (selected2 == false)
                {
                    numberofSelections++;
                    DiningArea_right.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 18:
                if (selected2 == false)
                {
                    numberofSelections++;
                    ControlRoom_right.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 19:
                if (selected2 == false)
                {
                    numberofSelections++;
                    ControlRoom_bottom.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 20:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Stage_top.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 21:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Stage_bottom.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 22:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Security_left.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 23:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Security_top.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 24:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Security_bottom.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 25:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Security_right.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 26:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Arcade_bottom.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 27:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Arcade_top.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 28:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Arcade_left.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 29:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Entrance_bottom.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 30:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Entrance_left.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 31:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Restrooms_bottom.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 32:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Restrooms_left.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 33:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Restrooms_rightTop.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 34:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Restrooms_rightBottom.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 35:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Restrooms_top.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 36:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Unisex_bottom.SetActive(true);
                    Update();
                    Reset();

                }
                break;

            case 37:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Girls_left.SetActive(true);
                    Update();
                    Reset();

                }
                break;


            case 38:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Boys_left.SetActive(true);
                    Update();
                    Reset();

                }
                break;
        }
    }



}
