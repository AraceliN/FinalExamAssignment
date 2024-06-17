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
    public GameObject EndVTurnButton;
    public GameObject Vanessa;

    int numberofSelections;
    int maxSelections = 2;
    bool selected2 = false;

    public bool kitchen_left;
    public bool kitchen_top;
    public bool eastHall_right;
    public bool eastHall_left;
    public bool eastHall_top;
    public bool prizeCorner_right;
    public bool prizeCorner_left;
    public bool westHall_right;
    public bool westHall_left;
    public bool westHall_top;
    public bool supplyCloset_right;
    public bool pirateCove_right;
    public bool pirateCove_top;
    public bool backroom_right;
    public bool diningArea_left;
    public bool diningArea_bottom;
    public bool diningArea_right;
    public bool controlRoom_right;
    public bool controlRoom_bottom;
    public bool stage_top;
    public bool stage_bottom;
    public bool security_left;
    public bool security_top;
    public bool security_bottom;
    public bool security_right;
    public bool arcade_bottom;
    public bool arcade_top;
    public bool arcade_left;
    public bool entrance_bottom;
    public bool entrance_left;
    public bool restrooms_left;
    public bool restrooms_rightTop;
    public bool restrooms_rightBottom;
    public bool restrooms_top;
    public bool restrooms_bottom;
    public bool unisex_bottom;
    public bool girls_left;
    public bool boys_left;

    public int kitchenLeftInt;
    public int kitchenTopInt;
    public int eastHallRightInt;
    public int eastHallLeftInt;
    public int eastHallTopInt;
    public int prizeCornerRightInt;
    public int prizeCornerLeftInt;
    public int westHallRightInt;
    public int westHallLeftInt;
    public int westHallTopInt;
    public int supplyClosetRightInt;
    public int pirateCoveRightInt;
    public int pirateCoveTopInt;
    public int backroomRightInt;
    public int diningAreaLeftInt;
    public int diningAreaBottomInt;
    public int diningAreaRightInt;
    public int controlRoomRightInt;
    public int controlRoomBottomInt;
    public int stageTopInt;
    public int stageBottomInt;
    public int securityLeftInt;
    public int securityTopInt;
    public int securityBottomInt;
    public int securityRightInt;
    public int arcadeBottomInt;
    public int arcadeTopInt;
    public int arcadeLeftInt;
    public int entranceBottomInt;
    public int entranceLeftInt;
    public int restroomsLeftInt;
    public int restroomsRightTopInt;
    public int restroomsRightBottomInt;
    public int restroomsTopInt;
    public int restroomsBottomInt;
    public int unisexBottomInt;
    public int girlsLeftInt;
    public int boysLeftInt;

    public void Start()
    {
         kitchen_left = false;
         kitchen_top = false;
         eastHall_right = false;
         eastHall_left = false;
         eastHall_top = false;
         prizeCorner_right = false;
         prizeCorner_left = false;
         westHall_right = false;
         westHall_left = false;
         westHall_top = false;
         supplyCloset_right = false;
         pirateCove_right = false;
         pirateCove_top = false;
         backroom_right = false;
         diningArea_left = false;
         diningArea_bottom = false;
         diningArea_right = false;
         controlRoom_right = false;
         controlRoom_bottom = false;
         stage_top = false;
         stage_bottom = false;
         security_left = false;
         security_top = false;
         security_bottom = false;
         security_right = false;
         arcade_bottom = false;
         arcade_top = false;
         arcade_left = false;
         entrance_bottom = false;
         entrance_left = false;
         restrooms_left = false;
         restrooms_rightTop = false;
         restrooms_rightBottom = false;
         restrooms_top = false;
         restrooms_bottom = false;
         unisex_bottom = false;
         girls_left = false;
         boys_left = false;

         kitchenLeftInt = 0;
         kitchenTopInt =0;
         eastHallRightInt = 0;
         eastHallLeftInt = 0;
         eastHallTopInt = 0;
         prizeCornerRightInt = 0;
         prizeCornerLeftInt = 0;
         westHallRightInt = 0;
         westHallLeftInt = 0;
         westHallTopInt = 0;
         supplyClosetRightInt = 0;
         pirateCoveRightInt = 0;
         pirateCoveTopInt = 0;
         backroomRightInt = 0;
         diningAreaLeftInt = 0;
         diningAreaBottomInt = 0;
         diningAreaRightInt = 0;
         controlRoomRightInt = 0;
         controlRoomBottomInt = 0;
         stageTopInt = 0;
         stageBottomInt = 0;
         securityLeftInt = 0;
         securityTopInt = 0;
         securityBottomInt = 0;
         securityRightInt = 0;
         arcadeBottomInt = 0;
         arcadeTopInt = 0;
         arcadeLeftInt = 0;
         entranceBottomInt = 0;
         entranceLeftInt = 0;
         restroomsLeftInt = 0;
         restroomsRightTopInt = 0;
         restroomsRightBottomInt = 0;
         restroomsTopInt = 0;
         restroomsBottomInt = 0;
         unisexBottomInt = 0;
         girlsLeftInt = 0;
         boysLeftInt = 0;

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
            EndVTurnButton.SetActive(true);
            Vanessa.SetActive(true);
            numberofSelections = 0;
            selected2 = false;
        }
    }

    public void ActivateDoorSelector()
    {
        Dropdown.SetActive(true);
    }

    public void DoorChecker()
    {
        if (kitchen_left == true)
        { 

        }
        if (kitchen_top == true)
        {

        }
        if (eastHall_right == true)
        {

        }
        if (eastHall_left == true)
        {

        }
        if (eastHall_top == true)
        {

        }
        if (prizeCorner_right == true)
        {

        }
        if (prizeCorner_left == true)
        {

        }
        if (westHall_right == true)
        {

        }
        if (westHall_left == true)
        {

        }
        if (westHall_top == true)
        {

        }
        if (supplyCloset_right == true)
        {

        }
        if (pirateCove_right == true)
        {

        }
        if (pirateCove_top == true)
        {

        }
        if (backroom_right == true)
        {

        }
        if (diningArea_left == true)
        {

        }
        if (diningArea_bottom == true)
        {

        }
        if (diningArea_right == true)
        {

        }
        if (controlRoom_right == true)
        {

        }
        if (controlRoom_bottom == true)
        {

        }
        if (stage_top == true)
        {

        }
        if (stage_bottom == true)
        {

        }
        if (security_left == true)
        {

        }
        if (security_top == true)
        {

        }
        if (security_bottom == true)
        {

        }
        if (security_right == true)
        {

        }
        if (arcade_bottom == true)
        {

        }
        if (arcade_top == true)
        {

        }
        if (arcade_left == true)
        {

        }
        if (entrance_bottom == true)
        {

        }
        if (entrance_left == true)
        {

        }
        if (restrooms_left == true)
        {

        }
        if (restrooms_rightTop == true)
        {

        }
        if (restrooms_rightBottom == true)
        {

        }
        if (restrooms_top == true)
        {

        }

        if (restrooms_bottom == true)
        {

        }
        if (unisex_bottom == true)
        {

        }
        if (girls_left == true)
        {

        }
        if (boys_left == true)
        {

        }

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
                    kitchen_left = true;
                    Update();
                    Reset();

                }
                break;

            case 2:
                if (selected2 == false)
                {
                    numberofSelections++;
                    Kitchen_top.SetActive(true);
                    kitchen_top = true;
                    Update();
                    Reset();

                }
                break;

            case 3:
                if (selected2 == false)
                {
                    numberofSelections++;
                    EastHall_right.SetActive(true);
                    eastHall_right = true;
                    Update();
                    Reset();

                }
                break;

            case 4:
                if (selected2 == false)
                {
                    numberofSelections++;
                    EastHall_left.SetActive(true);
                    eastHall_left = true;
                    Update();
                    Reset();

                }
                break;

            case 5:
                if (selected2 == false)
                {
                    numberofSelections++;
                    EastHall_top.SetActive(true);
                    eastHall_top = true;
                    Update();
                    Reset();

                }
                break;

            case 6:
                if (selected2 == false)
                {
                    numberofSelections++;
                    PrizeCorner_right.SetActive(true);
                    prizeCorner_right = true;
                    Update();
                    Reset();

                }
                break;

            case 7:
                if (selected2 == false)
                {
                    numberofSelections++;
                    PrizeCorner_left.SetActive(true);
                    prizeCorner_left = true;
                    Update();
                    Reset();

                }
                break;

            case 8:
                if (selected2 == false)
                {
                    numberofSelections++;
                    WestHall_right.SetActive(true);
                    westHall_right = true;
                    Update();
                    Reset();

                }
                break;

            case 9:
                if (selected2 == false)
                {
                    numberofSelections++;
                    WestHall_left.SetActive(true);
                    westHall_left = true;
                    Update();
                    Reset();

                }
                break;

            case 10:
                if (selected2 == false)
                {
                    numberofSelections++;
                    WestHall_top.SetActive(true);
                    westHall_top = true;
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



    public void ResetDoorBools()
    {
        kitchen_left = false;
        kitchen_top = false;
        eastHall_right = false;
        eastHall_left = false;
        eastHall_top = false;
        prizeCorner_right = false;
        prizeCorner_left = false;
        westHall_right = false;
        westHall_left = false;
        westHall_top = false;
        supplyCloset_right = false;
        pirateCove_right = false;
        pirateCove_top = false;
        backroom_right = false;
        diningArea_left = false;
        diningArea_bottom = false;
        diningArea_right = false;
        controlRoom_right = false;
        controlRoom_bottom = false;
        stage_top = false;
        stage_bottom = false;
        security_left = false;
        security_top = false;
        security_bottom = false;
        security_right = false;
        arcade_bottom = false;
        arcade_top = false;
        arcade_left = false;
        entrance_bottom = false;
        entrance_left = false;
        restrooms_left = false;
        restrooms_rightTop = false;
        restrooms_rightBottom = false;
        restrooms_top = false;
        restrooms_bottom = false;
        unisex_bottom = false;
        girls_left = false;
        boys_left = false;


        
    }

    public void ResetDoors()
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

}
