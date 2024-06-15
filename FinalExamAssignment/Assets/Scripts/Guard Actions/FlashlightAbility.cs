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
                    VaPlayerMovement.enabled = true;
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
                VaPlayerMovement.enabled = true;
            }
        }
    }

    public void ActivateFlashLightButtons()
    {
        if (VanessaTileTracker.VcurrentTile == "Controlroom")
        {
            Stage.SetActive(true);
            Entrance.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "Stage")
        {
            SecurityOffice.SetActive(true);
            Controlroom.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "SecurityOffice")
        {
            Stage.SetActive(true);
            DiningArea.SetActive(true);
            Arcade.SetActive(true);
            Entrance.SetActive (true);
            Restrooms.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "DiningArea")
        {
            Arcade.SetActive(true);
            Backroom.SetActive(true);
            PirateCove.SetActive(true);
            SecurityOffice.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "Backroom")
        {
            DiningArea.SetActive (true);
            PirateCove.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "Unisex")
        {
            Restrooms.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "Boys")
        {
           Restrooms.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "Girls")
        {
           Restrooms.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "Restrooms")
        {
            Girls.SetActive(true);
            Boys.SetActive(true);
            Unisex.SetActive(true);
            Kitchen.SetActive(true);
            Entrance.SetActive(true);
            SecurityOffice.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "PirateCove")
        {
            DiningArea.SetActive(true);
            Backroom.SetActive(true);
            WestHall.SetActive(true);

        }

        else if (VanessaTileTracker.VcurrentTile == "SupplyCloset")
        {
           WestHall.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "Arcade")
        {
            EastHall.SetActive(true);
            DiningArea.SetActive(true);
            SecurityOffice.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "WestHall")
        {
            PirateCove.SetActive(true);
            SupplyCloset.SetActive(true);
            PrizeCorner.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "PrizeCorner")
        {
            WestHall.SetActive(true);
            EastHall.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "EastHall")
        {
            PrizeCorner.SetActive(true);
            Arcade.SetActive(true);
            Kitchen.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "Kitchen")
        {
            Restrooms.SetActive(true);
            EastHall.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "Entrance")
        {
            Controlroom.SetActive(true);
            SecurityOffice.SetActive(true);
            Restrooms.SetActive(true);
        }

        //Hallways

        else if (VanessaTileTracker.VcurrentTile == "HallwayB-D-P")
        {
            Backroom.SetActive(true);
            DiningArea.SetActive(true);
            PirateCove.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "HallwayA-D")
        {
            Arcade.SetActive(true);
            DiningArea.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "HallwayD-S")
        {
            DiningArea.SetActive(true);
            SecurityOffice.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "HallwayS-S")
        {
            SecurityOffice.SetActive(true);
            Stage.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "HallwayA-S")
        {
            Arcade.SetActive(true);
            SecurityOffice.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "HallwayC-S")
        {
            Controlroom.SetActive(true);
            Stage.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "HallwayC-E")
        {           
            Controlroom.SetActive(true);
            Entrance.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "HallwayE-S-R")
        {
            Entrance.SetActive(true);
            SecurityOffice.SetActive(true);
            Restrooms.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "HallwayR-U")
        {
            Restrooms.SetActive(true);
            Unisex.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "HallwayG-R")
        {
            Girls.SetActive(true);
            Restrooms.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "HallwayB-R")
        {
            Boys.SetActive(true);
            Restrooms.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "HallwayK-R")
        {
            Restrooms.SetActive(true);
            Kitchen.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "HallwayE-K")
        {
            Kitchen.SetActive(true);
            EastHall.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "HallwayA-E")
        {
            EastHall.SetActive(true);
            Arcade.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "HallwayE-P")
        {
            EastHall.SetActive(true);
            PrizeCorner.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "HallwayP-W")
        {
            WestHall.SetActive(true);
            PrizeCorner.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "HallwayW-P")
        {
            WestHall.SetActive(true);
            PirateCove.SetActive(true);
        }

        else if (VanessaTileTracker.VcurrentTile == "HallwayS-W")
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

        if (VanessaTileTracker.VcurrentTile == Freddytiletracker.currentTile)
        {
            Freddy.transform.position = GameObject.Find(ClickedRoomName).transform.position;
        }

        if (VanessaTileTracker.VcurrentTile == Foxytiletracker.currentTile)
        {
            Foxy.transform.position = GameObject.Find(ClickedRoomName).transform.position;
        }

        if (VanessaTileTracker.VcurrentTile == Chicatiletracker.currentTile)
        {
            Chica.transform.position = GameObject.Find(ClickedRoomName).transform.position;
        }

        VanessaVisibility.CanUseFlashLight = false;
        GuardActionButton.SetActive(true);
        EndVanessaTurnButton.SetActive(true);
        Vanessa.SetActive(true);

       
    }


}
