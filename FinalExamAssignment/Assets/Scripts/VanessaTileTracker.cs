using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TileTypes;
using System.Linq;
using Unity.VisualScripting;

public class VanessaTileTracker : MonoBehaviour
{

    public string currentTile;
    List<string> Vtiles = new List<string>();
    // List<TileInfo> TravelledTiles = new List<TileInfo>();

    GameObject RoomCollider;
    GameObject character;
    Vector2 characterPos;

    

    private CharacterVisibility characterVisibility;


    GameObject Kitchenvent;

    public Transform Vanessa;
    public Transform GirlsBlue;


    public void Update()
    {
       
    }

    public void OnTriggerEnter2D(Collider2D room)
    {
        if (room.tag == "Controlroom")
        {
            currentTile = "Controlroom";
        }

        else if (room.tag == "ControlroomVent") //Vent
        {
            currentTile = "East Hall";
        }

        else if (room.tag == "Stage")
        {
            currentTile = "Stage";
        }

        else if (room.tag == "SecurityOffice")
        {
            currentTile = "SecurityOffice";
        }

        else if (room.tag == "DiningArea")
        {
            currentTile = "DiningArea";
        }

        else if (room.tag == "BackroomVent")     //Vent
        {
            currentTile = "Kitchen";
        }

        else if (room.tag == "Backroom")
        {
            currentTile = "Backroom";
        }

        else if (room.tag == "Unisex")
        {
            currentTile = "Unisex";
        }

        else if (room.tag == "Boys")
        {
            currentTile = "Boys";
        }

        else if (room.tag == "Girls")
        {
            currentTile = "Girls";
        }

        else if (room.tag == "GirlsVent") //Vent
        {
            currentTile = "SupplyCloset";
        }

        else if (room.tag == "Restrooms")
        {
            currentTile = "Restrooms";
        }

        else if (room.tag == "PirateCove")
        {
            currentTile = "PirateCove";
        }

        else if (room.tag == "SupplyCloset")
        {
            currentTile = "SupplyCloset";
        }

        else if (room.tag == "SupplyClosetVent") //Vent
        {
            currentTile = "Girls";
            Vanessa.transform.position = GirlsBlue.position;
            Debug.Log("Whoop");
        }

        else if (room.tag == "Arcade")
        {
            currentTile = "Arcade";
        }

        else if (room.tag == "WestHall")
        {
            currentTile = "WestHall";
        }

        else if (room.tag == "PrizeCorner")
        {
            currentTile = "PrizeCorner";
        }

        else if (room.tag == "EastHall")
        {
            currentTile = "EastHall";
        }

        else if (room.tag == "EastHallVent") //Vent
        {
            currentTile = "Controlroom";
        }

        else if (room.tag == "Kitchen")
        {
            currentTile = "Kitchen";
        }

        else if (room.tag == "KitchenVent")//Vent
        {
            currentTile = "Backroom";
        }

        else if (room.tag == "Entrance")
        {
            currentTile = "Entrance";
        }

        //Hallways

        else if (room.tag == "HallwayB-D-P")
        {
            currentTile = "HallwayB-D-P";
        }

        else if (room.tag == "HallwayA-D") 
        {
            currentTile = "HallwayA-D";
        }

        else if (room.tag == "HallwayD-S")
        {
            currentTile = "HallwayD-S";
        }

        else if (room.tag == "HallwayS-S")
        {
            currentTile = "HallwayS-S";


        }
        else if (room.tag == "HallwayA-S")
        {
            currentTile = "HallwayA-S";
        }

        else if (room.tag == "HallwayC-S")
        {
            currentTile = "HallwayC-S";
        }

        else if (room.tag == "HallwayC-E")
        {
            currentTile = "HallwayC-E";


        }
        else if (room.tag == "HallwayE-S-R")
        {
            currentTile = "HallwayE-S-R";
        }

        else if (room.tag == "HallwayR-U")
        {
            currentTile = "HallwayR-U";
        }

        else if (room.tag == "HallwayG-R")
        {
            currentTile = "HallwayG-R";


        }
        else if (room.tag == "HallwayB-R")
        {
            currentTile = "HallwayB-R";
        }

        else if (room.tag == "HallwayK-R")
        {
            currentTile = "HallwayK-R";
        }

        else if (room.tag == "HallwayE-K")
        {
            currentTile = "HallwayE-K";


        }
        else if (room.tag == "HallwayA-E")
        {
            currentTile = "HallwayA-E";
        }

        else if (room.tag == "HallwayE-P")
        {
            currentTile = "HallwayE-P";
        }

        else if (room.tag == "HallwayP-W")
        {
            currentTile = "HallwayP-W";


        }
        else if (room.tag == "HallwayW-P")
        {
            currentTile = "HallwayW-P";
        }

        else if (room.tag == "HallwayS-W")
        {
            currentTile = "HallwayS-W";
        }

        Vtiles.Add(currentTile);
            Debug.Log(currentTile);
        
    }

    
    
    public void FindLast(List<string> tiles)
    {
        tiles.Last();
    }
}
