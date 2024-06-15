using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FreddyTeleport : MonoBehaviour
{
 
    public TileTracker FreddyTileTracker;

    public RoundTracker RoundTracker;

    public GameObject TeleportButtons;
    public GameObject AnimatronicAbilityButton;
    public GameObject EndAnimatronicTurnButton;
    public GameObject Freddy;
    public FrPlayerMovement FrPlayerMovement;

    public GameObject Chica;
    public GameObject Foxy;


    public GameObject AnimatronicCanvas;

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
   

    public void ActivateTeleportButtons()
    {
        if (FreddyTileTracker.currentTile == "Controlroom")
        {
            Stage.SetActive(true);
            Entrance.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "Stage")
        {
            SecurityOffice.SetActive(true);
            Controlroom.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "SecurityOffice")
        {
            Stage.SetActive(true);
            DiningArea.SetActive(true);
            Arcade.SetActive(true);
            Entrance.SetActive(true);
            Restrooms.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "DiningArea")
        {
            Arcade.SetActive(true);
            Backroom.SetActive(true);
            PirateCove.SetActive(true);
            SecurityOffice.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "Backroom")
        {
            DiningArea.SetActive(true);
            PirateCove.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "Unisex")
        {
            Restrooms.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "Boys")
        {
            Restrooms.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "Girls")
        {
            Restrooms.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "Restrooms")
        {
            Girls.SetActive(true);
            Boys.SetActive(true);
            Unisex.SetActive(true);
            Kitchen.SetActive(true);
            Entrance.SetActive(true);
            SecurityOffice.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "PirateCove")
        {
            DiningArea.SetActive(true);
            Backroom.SetActive(true);
            WestHall.SetActive(true);

        }

        else if (FreddyTileTracker.currentTile == "SupplyCloset")
        {
            WestHall.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "Arcade")
        {
            EastHall.SetActive(true);
            DiningArea.SetActive(true);
            SecurityOffice.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "WestHall")
        {
            PirateCove.SetActive(true);
            SupplyCloset.SetActive(true);
            PrizeCorner.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "PrizeCorner")
        {
            WestHall.SetActive(true);
            EastHall.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "EastHall")
        {
            PrizeCorner.SetActive(true);
            Arcade.SetActive(true);
            Kitchen.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "Kitchen")
        {
            Restrooms.SetActive(true);
            EastHall.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "Entrance")
        {
            Controlroom.SetActive(true);
            SecurityOffice.SetActive(true);
            Restrooms.SetActive(true);
        }

        //Hallways

        else if (FreddyTileTracker.currentTile == "HallwayB-D-P")
        {
            Backroom.SetActive(true);
            DiningArea.SetActive(true);
            PirateCove.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "HallwayA-D")
        {
            Arcade.SetActive(true);
            DiningArea.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "HallwayD-S")
        {
            DiningArea.SetActive(true);
            SecurityOffice.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "HallwayS-S")
        {
            SecurityOffice.SetActive(true);
            Stage.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "HallwayA-S")
        {
            Arcade.SetActive(true);
            SecurityOffice.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "HallwayC-S")
        {
            Controlroom.SetActive(true);
            Stage.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "HallwayC-E")
        {
            Controlroom.SetActive(true);
            Entrance.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "HallwayE-S-R")
        {
            Entrance.SetActive(true);
            SecurityOffice.SetActive(true);
            Restrooms.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "HallwayR-U")
        {
            Restrooms.SetActive(true);
            Unisex.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "HallwayG-R")
        {
            Girls.SetActive(true);
            Restrooms.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "HallwayB-R")
        {
            Boys.SetActive(true);
            Restrooms.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "HallwayK-R")
        {
            Restrooms.SetActive(true);
            Kitchen.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "HallwayE-K")
        {
            Kitchen.SetActive(true);
            EastHall.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "HallwayA-E")
        {
            EastHall.SetActive(true);
            Arcade.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "HallwayE-P")
        {
            EastHall.SetActive(true);
            PrizeCorner.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "HallwayP-W")
        {
            WestHall.SetActive(true);
            PrizeCorner.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "HallwayW-P")
        {
            WestHall.SetActive(true);
            PirateCove.SetActive(true);
        }

        else if (FreddyTileTracker.currentTile == "HallwayS-W")
        {
            SupplyCloset.SetActive(true);
            WestHall.SetActive(true);
        }


    }
    public void UseTeleport()
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

        Foxy.SetActive(true);
        Chica.SetActive(true);

        Freddy.transform.position = GameObject.Find(ClickedRoomName).transform.position;

        AnimatronicCanvas.SetActive(true);
        EndAnimatronicTurnButton.SetActive(true);
    }
}