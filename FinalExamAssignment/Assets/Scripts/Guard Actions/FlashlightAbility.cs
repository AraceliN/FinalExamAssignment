using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using static TileTypes;

public class FlashlightAbility : MonoBehaviour
{
    public VanessaTileTracker VanessaTileTracker;
    public TileTracker Chicatiletracker;
    public TileTracker Foxytiletracker;
    public TileTracker Freddytiletracker;


    public VaPlayerMovement VaPlayerMovement;
    public VanessaVisibility VanessaVisibility;
    public VanessaVenting VanessaVenting;
    public RoundTracker RoundTracker;

    public GameObject FlashlightButton;
    public GameObject GuardActionButton;
    public GameObject EndVanessaTurnButton;
    public GameObject Vanessa;
    public GameObject Chica;
    public GameObject Foxy;
    public GameObject Freddy;

    public GameObject GuardActionCanvas;
    public GameObject Sound;
    public GameObject Doors;
    public GameObject Cams;

    public GameObject Controlroom;
    public GameObject Stage;
    public GameObject SecurityOffice;
    public GameObject DiningArea;
    public GameObject Backroom;
    public GameObject Unisex;
    public GameObject Boys;
    public GameObject Girls;
    public GameObject Restrooms;
    public GameObject PirateCove;
    public GameObject SupplyCloset;
    public GameObject Arcade;
    public GameObject WestHall;
    public GameObject PrizeCorner;
    public GameObject EastHall;
    public GameObject Kitchen;
    public GameObject Entrance;


    public void Start()
    {
        FlashlightButton.SetActive(false);

        Controlroom.SetActive(false);
        Stage.SetActive(false);
        SecurityOffice.SetActive(false);
        DiningArea.SetActive(false);
        Backroom.SetActive(false);
        Unisex.SetActive(false);
        Boys.SetActive(false);
        Girls.SetActive(false);
        Restrooms.SetActive(false);
        PirateCove.SetActive(false);
        SupplyCloset.SetActive(false);
        Arcade.SetActive(false);
        WestHall.SetActive(false);
        PrizeCorner.SetActive(false);
        EastHall.SetActive(false);
        Kitchen.SetActive(false);
        Entrance.SetActive(false);
    }
    public void Update()
    {
        CanUseFlashlight();
    }


    public void CanUseFlashlight()
    {
        if (VanessaVisibility.CanUseFlashLight == true)
        {
            if(RoundTracker.isVanessaTurn == true)
            {
                FlashlightButton.SetActive(true);
                GuardActionButton.SetActive(false);
                EndVanessaTurnButton.SetActive(false);

                Cams.SetActive(false);
                Sound.SetActive(false);
                Doors.SetActive(false);
                GuardActionCanvas.SetActive(true);


                VaPlayerMovement.enabled = false;
}
            else
            {
                FlashlightButton.SetActive(false);

                Cams.SetActive(true);
                Sound.SetActive(true);
                Doors.SetActive(true);
                if (VanessaVenting.isVenting == false)
                {
                    if(RoundTracker.isVanessaTurn)
                    {
                        VaPlayerMovement.enabled = true;
                    }
                    else
                    {
                        VaPlayerMovement.enabled = false;
                    }
               
                }
                
            }

        }
        else 
        {
            FlashlightButton.SetActive (false);

            Cams.SetActive(true);
            Sound.SetActive(true);
            Doors.SetActive(true);
            if (VanessaVenting.isVenting == false)
            {
                if (RoundTracker.isVanessaTurn)
                {
                    VaPlayerMovement.enabled = true;
                }
                else
                {
                    VaPlayerMovement.enabled = false;
                }
            }
        }
    }

    public void ActivateFlashLightButtons()
    {
        if (VanessaTileTracker.currentTile == "Controlroom")
        {
            Stage.SetActive(true);
            Entrance.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "Stage")
        {
            SecurityOffice.SetActive(true);
            Controlroom.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "SecurityOffice")
        {
            Stage.SetActive(true);
            DiningArea.SetActive(true);
            Arcade.SetActive(true);
            Entrance.SetActive (true);
            Restrooms.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "DiningArea")
        {
            Arcade.SetActive(true);
            Backroom.SetActive(true);
            PirateCove.SetActive(true);
            SecurityOffice.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "Backroom")
        {
            DiningArea.SetActive (true);
            PirateCove.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "Unisex")
        {
            Restrooms.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "Boys")
        {
           Restrooms.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "Girls")
        {
           Restrooms.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "Restrooms")
        {
            Girls.SetActive(true);
            Boys.SetActive(true);
            Unisex.SetActive(true);
            Kitchen.SetActive(true);
            Entrance.SetActive(true);
            SecurityOffice.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "PirateCove")
        {
            DiningArea.SetActive(true);
            Backroom.SetActive(true);
            WestHall.SetActive(true);

        }

        else if (VanessaTileTracker.currentTile == "SupplyCloset")
        {
           WestHall.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "Arcade")
        {
            EastHall.SetActive(true);
            DiningArea.SetActive(true);
            SecurityOffice.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "WestHall")
        {
            PirateCove.SetActive(true);
            SupplyCloset.SetActive(true);
            PrizeCorner.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "PrizeCorner")
        {
            WestHall.SetActive(true);
            EastHall.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "EastHall")
        {
            PrizeCorner.SetActive(true);
            Arcade.SetActive(true);
            Kitchen.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "Kitchen")
        {
            Restrooms.SetActive(true);
            EastHall.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "Entrance")
        {
            Controlroom.SetActive(true);
            SecurityOffice.SetActive(true);
            Restrooms.SetActive(true);
        }

        //Hallways

        else if (VanessaTileTracker.currentTile == "HallwayB-D-P")
        {
            Backroom.SetActive(true);
            DiningArea.SetActive(true);
            PirateCove.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "HallwayA-D")
        {
            Arcade.SetActive(true);
            DiningArea.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "HallwayD-S")
        {
            DiningArea.SetActive(true);
            SecurityOffice.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "HallwayS-S")
        {
            SecurityOffice.SetActive(true);
            Stage.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "HallwayA-S")
        {
            Arcade.SetActive(true);
            SecurityOffice.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "HallwayC-S")
        {
            Controlroom.SetActive(true);
            Stage.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "HallwayC-E")
        {           
            Controlroom.SetActive(true);
            Entrance.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "HallwayE-S-R")
        {
            Entrance.SetActive(true);
            SecurityOffice.SetActive(true);
            Restrooms.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "HallwayR-U")
        {
            Restrooms.SetActive(true);
            Unisex.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "HallwayG-R")
        {
            Girls.SetActive(true);
            Restrooms.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "HallwayB-R")
        {
            Boys.SetActive(true);
            Restrooms.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "HallwayK-R")
        {
            Restrooms.SetActive(true);
            Kitchen.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "HallwayE-K")
        {
            Kitchen.SetActive(true);
            EastHall.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "HallwayA-E")
        {
            EastHall.SetActive(true);
            Arcade.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "HallwayE-P")
        {
            EastHall.SetActive(true);
            PrizeCorner.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "HallwayP-W")
        {
            WestHall.SetActive(true);
            PrizeCorner.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "HallwayW-P")
        {
            WestHall.SetActive(true);
            PirateCove.SetActive(true);
        }

        else if (VanessaTileTracker.currentTile == "HallwayS-W")
        {
            SupplyCloset.SetActive(true);
            WestHall.SetActive(true);
        }
    }
    public void UseFlashLight()
    {
        string ClickedRoomName = EventSystem.current.currentSelectedGameObject.name;
        ClickedRoomName = ClickedRoomName + "Blue";
        Controlroom.SetActive(false);
        Stage.SetActive(false);
        SecurityOffice.SetActive(false);
        DiningArea.SetActive(false);
        Backroom.SetActive(false);
        Unisex.SetActive(false);
        Boys.SetActive(false);
        Girls.SetActive(false);
        Restrooms.SetActive(false);
        PirateCove.SetActive(false);
        SupplyCloset.SetActive(false);
        Arcade.SetActive(false);
        WestHall.SetActive(false);
        PrizeCorner.SetActive(false);
        EastHall.SetActive(false);
        Kitchen.SetActive(false);
        Entrance.SetActive(false);

        if (VanessaTileTracker.currentTile == Freddytiletracker.currentTile)
        {
            Freddy.transform.position = GameObject.Find(ClickedRoomName).transform.position;
        }

        if (VanessaTileTracker.currentTile == Foxytiletracker.currentTile)
        {
            Foxy.transform.position = GameObject.Find(ClickedRoomName).transform.position;
        }

        if (VanessaTileTracker.currentTile == Chicatiletracker.currentTile)
        {
            Chica.transform.position = GameObject.Find(ClickedRoomName).transform.position;
        }

        VanessaVisibility.CanUseFlashLight = false;
        GuardActionButton.SetActive(true);
        EndVanessaTurnButton.SetActive(true);
        Vanessa.SetActive(true);

       
    }


}
