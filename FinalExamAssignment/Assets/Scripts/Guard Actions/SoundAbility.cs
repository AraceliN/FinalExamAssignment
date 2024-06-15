using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SoundAbility : MonoBehaviour
{

    public RoundTracker RoundTracker;

    public GameObject Freddy;

    public GameObject Chica;
    public GameObject Foxy;

    public VanessaTileTracker VanessaTileTracker;
    public TileTracker ChicaTileTracker;
    public TileTracker FoxyTileTracker;
    public TileTracker FreddyTileTracker;

    public SpriteRenderer VanessaSprite;
    public SpriteRenderer ChicaSprite;
    public SpriteRenderer FoxySprite;
    public SpriteRenderer FreddySprite;

    public VanessaVisibility VanessaVisibility;

    public GameObject SoundButtons;
    public GameObject GuardActionButton;
    public GameObject EndVanessaTurnButton;
    public GameObject Vanessa;

    


    public void Start()
    {
        SoundButtons.SetActive(false);
       
    }


    public void ActivateSoundButtons()
    {
        SoundButtons.SetActive(true);
    }

    public void UseSound()
    {
        string ClickedRoomName = EventSystem.current.currentSelectedGameObject.name;
        string BlueSquare = ClickedRoomName + "Blue";

        if (ClickedRoomName == "Controlroom")
        {
            if (FreddyTileTracker.currentTile == "Entrance" || FreddyTileTracker.currentTile == "Stage" || FreddyTileTracker.currentTile == "HallwayC-S" || FreddyTileTracker.currentTile == "HallwayC-E")
            {
                Freddy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (FoxyTileTracker.currentTile == "Entrance" || FoxyTileTracker.currentTile == "Stage" || FoxyTileTracker.currentTile == "HallwayC-S" || FoxyTileTracker.currentTile == "HallwayC-E")
            {
                Foxy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (ChicaTileTracker.currentTile == "Entrance" || ChicaTileTracker.currentTile == "Stage" || ChicaTileTracker.currentTile == "HallwayC-S" || ChicaTileTracker.currentTile == "HallwayC-E")
            {
                Chica.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
        }
       

        else if (ClickedRoomName == "Stage")
        {
            if (FreddyTileTracker.currentTile == "Controlroom" || FreddyTileTracker.currentTile == "SecurityOffice" || FreddyTileTracker.currentTile == "HallwayS-S" || FreddyTileTracker.currentTile == "HallwayC-S")
            {
                Freddy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (FoxyTileTracker.currentTile == "Controlroom" || FoxyTileTracker.currentTile == "SecurityOffice" || FoxyTileTracker.currentTile == "HallwayS-S" || FoxyTileTracker.currentTile == "HallwayC-S")
            {
                Foxy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (ChicaTileTracker.currentTile == "Controlroom" || ChicaTileTracker.currentTile == "SecurityOffice" || ChicaTileTracker.currentTile == "HallwayS-S" || ChicaTileTracker.currentTile == "HallwayC-S")
            {
                Chica.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
        }

        else if (ClickedRoomName == "SecurityOffice")
        {
            if (FreddyTileTracker.currentTile == "Stage" || FreddyTileTracker.currentTile == "DiningArea" || FreddyTileTracker.currentTile == "Arcade" || FreddyTileTracker.currentTile == "Entrance" || FreddyTileTracker.currentTile == "Resrooms" || 
                FreddyTileTracker.currentTile == "HallwayS-S" || FreddyTileTracker.currentTile == "HallwayA-S" || FreddyTileTracker.currentTile == "HallwayD-S" || FreddyTileTracker.currentTile == "HallwayE-S-R")
            {
                Freddy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (FoxyTileTracker.currentTile == "Stage" || FoxyTileTracker.currentTile == "DiningArea" || FoxyTileTracker.currentTile == "Arcade" || FoxyTileTracker.currentTile == "Entrance" || FoxyTileTracker.currentTile == "Resrooms" ||
                FoxyTileTracker.currentTile == "HallwayS-S" || FoxyTileTracker.currentTile == "HallwayA-S" || FoxyTileTracker.currentTile == "HallwayD-S" || FoxyTileTracker.currentTile == "HallwayE-S-R")
            {
                Foxy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (ChicaTileTracker.currentTile == "Stage" || ChicaTileTracker.currentTile == "DiningArea" || ChicaTileTracker.currentTile == "Arcade" || ChicaTileTracker.currentTile == "Entrance" || ChicaTileTracker.currentTile == "Resrooms" ||
                ChicaTileTracker.currentTile == "HallwayS-S" || ChicaTileTracker.currentTile == "HallwayA-S" || ChicaTileTracker.currentTile == "HallwayD-S" || ChicaTileTracker.currentTile == "HallwayE-S-R")
            {
                Chica.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
        }

        else if (ClickedRoomName == "DiningArea")
        {
            if (FreddyTileTracker.currentTile == "Backroom" || FreddyTileTracker.currentTile == "PirateCove" || FreddyTileTracker.currentTile == "Arcade" || FreddyTileTracker.currentTile == "SecurityOffice" ||
                FreddyTileTracker.currentTile == "HallwayD-S" || FreddyTileTracker.currentTile == "HallwayA-D"  || FreddyTileTracker.currentTile == "HallwayB-D-P")
            {
                Freddy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (FoxyTileTracker.currentTile == "Backroom" || FoxyTileTracker.currentTile == "PirateCove" || FoxyTileTracker.currentTile == "Arcade" || FoxyTileTracker.currentTile == "SecurityOffice" ||
               FoxyTileTracker.currentTile == "HallwayD-S" || FoxyTileTracker.currentTile == "HallwayA-D" || FoxyTileTracker.currentTile == "HallwayB-D-P")
            {
                Foxy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (ChicaTileTracker.currentTile == "Backroom" || ChicaTileTracker.currentTile == "PirateCove" || ChicaTileTracker.currentTile == "Arcade" || ChicaTileTracker.currentTile == "SecurityOffice" ||
               ChicaTileTracker.currentTile == "HallwayD-S" || ChicaTileTracker.currentTile == "HallwayA-D" || ChicaTileTracker.currentTile == "HallwayB-D-P")
            {
                Chica.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
        }

        else if (ClickedRoomName == "Backroom")
        {
            if (FreddyTileTracker.currentTile == "PirateCove" || FreddyTileTracker.currentTile == "DiningArea" || FreddyTileTracker.currentTile == "HallwayB-D-P")
            {
                Freddy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (FoxyTileTracker.currentTile == "PirateCove" || FoxyTileTracker.currentTile == "DiningArea" || FoxyTileTracker.currentTile == "HallwayB-D-P")
            {
                Foxy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (ChicaTileTracker.currentTile == "PirateCove" || ChicaTileTracker.currentTile == "DiningArea" || ChicaTileTracker.currentTile == "HallwayB-D-P")
            {
                Chica.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
        }

        else if (ClickedRoomName == "Unisex")
        {
            if (FreddyTileTracker.currentTile == "Restrooms" || FreddyTileTracker.currentTile == "HallwayR-U")
            {
                Freddy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (FoxyTileTracker.currentTile == "Restrooms" || FoxyTileTracker.currentTile == "HallwayR-U")
            {
                Foxy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (ChicaTileTracker.currentTile == "Restrooms" || ChicaTileTracker.currentTile == "HallwayR-U")
            {
                Chica.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
        }

        else if (ClickedRoomName == "Boys")
        {
            if (FreddyTileTracker.currentTile == "Restrooms" || FreddyTileTracker.currentTile == "HallwayB-R")
            {
                Freddy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (FoxyTileTracker.currentTile == "Restrooms" || FoxyTileTracker.currentTile == "HallwayB-R")
            {
                Foxy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (ChicaTileTracker.currentTile == "Restrooms" || ChicaTileTracker.currentTile == "HallwayB-R")
            {
                Chica.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
        }

        else if (ClickedRoomName == "Girls")
        {
            if (FreddyTileTracker.currentTile == "Restrooms" || FreddyTileTracker.currentTile == "HallwayG-R")
            {
                Freddy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (FoxyTileTracker.currentTile == "Restrooms" || FoxyTileTracker.currentTile == "HallwayG-R")
            {
                Foxy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (ChicaTileTracker.currentTile == "Restrooms" || ChicaTileTracker.currentTile == "HallwayG-R")
            {
                Chica.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
        }

        else if (ClickedRoomName == "Restrooms")
        {

        }

        else if (ClickedRoomName == "PirateCove")
        {


        }

        else if (ClickedRoomName == "SupplyCloset")
        {
            if (FreddyTileTracker.currentTile == "WestHall" || FreddyTileTracker.currentTile == "HallwayS-W")
            {
                Freddy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (FoxyTileTracker.currentTile == "WestHall" || FoxyTileTracker.currentTile == "HallwayS-W")
            {
                Foxy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (ChicaTileTracker.currentTile == "WestHall" || ChicaTileTracker.currentTile == "HallwayS-W")
            {
                Chica.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
        }

        else if (ClickedRoomName == "Arcade")
        {
            if (FreddyTileTracker.currentTile == "EastHall" || FreddyTileTracker.currentTile == "DiningArea" || FreddyTileTracker.currentTile == "SecurityOffice" ||
              FreddyTileTracker.currentTile == "HallwayA-S" || FreddyTileTracker.currentTile == "HallwayA-D" || FreddyTileTracker.currentTile == "HallwayA-E")
            {
                Freddy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (FoxyTileTracker.currentTile == "EastHall" || FoxyTileTracker.currentTile == "DiningArea" || FoxyTileTracker.currentTile == "SecurityOffice" ||
            FoxyTileTracker.currentTile == "HallwayA-S" || FoxyTileTracker.currentTile == "HallwayA-D" || FoxyTileTracker.currentTile == "HallwayA-E")
            {
                Foxy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (ChicaTileTracker.currentTile == "EastHall" || ChicaTileTracker.currentTile == "DiningArea" || ChicaTileTracker.currentTile == "SecurityOffice" ||
            ChicaTileTracker.currentTile == "HallwayA-S" || ChicaTileTracker.currentTile == "HallwayA-D" || ChicaTileTracker.currentTile == "HallwayA-E")
            {
                Chica.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
        }

        else if (ClickedRoomName == "WestHall")
        {
            if (FreddyTileTracker.currentTile == "SupplyCloset" || FreddyTileTracker.currentTile == "PirateCove" || FreddyTileTracker.currentTile == "PrizeCorner" ||
               FreddyTileTracker.currentTile == "HallwayW-P" || FreddyTileTracker.currentTile == "HallwayP-W" || FreddyTileTracker.currentTile == "HallwayS-W")
            {
                Freddy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (FoxyTileTracker.currentTile == "SupplyCloset" || FoxyTileTracker.currentTile == "PirateCove" || FoxyTileTracker.currentTile == "PrizeCorner" ||
              FoxyTileTracker.currentTile == "HallwayW-P" || FoxyTileTracker.currentTile == "HallwayP-W" || FoxyTileTracker.currentTile == "HallwayS-W")
            {
                Foxy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (ChicaTileTracker.currentTile == "SupplyCloset" || ChicaTileTracker.currentTile == "PirateCove" || ChicaTileTracker.currentTile == "PrizeCorner" ||
              ChicaTileTracker.currentTile == "HallwayW-P" || ChicaTileTracker.currentTile == "HallwayP-W" || ChicaTileTracker.currentTile == "HallwayS-W")
            {
                Chica.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
        }

        else if (ClickedRoomName == "PrizeCorner")
        {
            if (FreddyTileTracker.currentTile == "WestHall" || FreddyTileTracker.currentTile == "EastHall" || FreddyTileTracker.currentTile == "HallwayE-P" || FreddyTileTracker.currentTile == "HallwayP-W")
            {
                Freddy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (FoxyTileTracker.currentTile == "WestHall" || FoxyTileTracker.currentTile == "EastHall" || FoxyTileTracker.currentTile == "HallwayE-P" || FoxyTileTracker.currentTile == "HallwayP-W")
            {
                Foxy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (ChicaTileTracker.currentTile == "WestHall" || ChicaTileTracker.currentTile == "EastHall" || ChicaTileTracker.currentTile == "HallwayE-P" || ChicaTileTracker.currentTile == "HallwayP-W")
            {
                Chica.transform.position = GameObject.Find(BlueSquare).transform.position;
            }

        }

        else if (ClickedRoomName == "EastHall")
        {
            if (FreddyTileTracker.currentTile == "Arcade" || FreddyTileTracker.currentTile == "Kitchen" || FreddyTileTracker.currentTile == "PrizeCorner" ||
              FreddyTileTracker.currentTile == "HallwayA-E" || FreddyTileTracker.currentTile == "HallwayP-W" || FreddyTileTracker.currentTile == "HallwayE-K")
            {
                Freddy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (FoxyTileTracker.currentTile == "Arcade" || FoxyTileTracker.currentTile == "Kitchen" || FoxyTileTracker.currentTile == "PrizeCorner" ||
              FoxyTileTracker.currentTile == "HallwayA-E" || FoxyTileTracker.currentTile == "HallwayP-W" || FoxyTileTracker.currentTile == "HallwayE-K")
            {
                Foxy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (ChicaTileTracker.currentTile == "Arcade" || ChicaTileTracker.currentTile == "Kitchen" || ChicaTileTracker.currentTile == "PrizeCorner" ||
              ChicaTileTracker.currentTile == "HallwayA-E" || ChicaTileTracker.currentTile == "HallwayP-W" || ChicaTileTracker.currentTile == "HallwayE-K")
            {
                Chica.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
        }

        else if (ClickedRoomName == "Kitchen")
        {
            if (FreddyTileTracker.currentTile == "Restrooms" || FreddyTileTracker.currentTile == "EastHall" || FreddyTileTracker.currentTile == "HallwayE-K" || FreddyTileTracker.currentTile == "HallwayK-R")
            {
                Freddy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (FoxyTileTracker.currentTile == "Restrooms" || FoxyTileTracker.currentTile == "EastHall" || FoxyTileTracker.currentTile == "HallwayE-K" || FoxyTileTracker.currentTile == "HallwayK-R")
            {
                Foxy.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
            if (ChicaTileTracker.currentTile == "Restrooms" || ChicaTileTracker.currentTile == "EastHall" || ChicaTileTracker.currentTile == "HallwayE-K" || ChicaTileTracker.currentTile == "HallwayK-R")
            {
                Chica.transform.position = GameObject.Find(BlueSquare).transform.position;
            }
        }

        else if (ClickedRoomName == "Entrance")
        {

        }



        GuardActionButton.SetActive(true);
        SoundButtons.SetActive(false);
        EndVanessaTurnButton.SetActive(true);
        Vanessa.SetActive(true);
    }
}
