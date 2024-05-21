using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TileTypes;
using System.Linq;
using Unity.VisualScripting;

public class VanessaTileTracker : MonoBehaviour
{

    public string VcurrentTile;
    List<string> Vtiles = new List<string>();
    // List<TileInfo> TravelledTiles = new List<TileInfo>();

    GameObject RoomCollider;
    GameObject character;
    Vector2 characterPos;

    GameObject Kitchenvent;

    public Transform Vanessa;
    public Transform GirlsBlue;


    public void OnTriggerEnter2D(Collider2D room)
    {
        if (room.tag == "Controlroom")
        {
            VcurrentTile = "Controlroom";
        }

        else if (room.tag == "ControlroomVent") //Vent
        {
            VcurrentTile = "East Hall";
        }

        else if (room.tag == "Stage")
        {
            VcurrentTile = "Stage";
        }

        else if (room.tag == "SecurityOffice")
        {
            VcurrentTile = "SecurityOffice";
        }

        else if (room.tag == "DiningArea")
        {
            VcurrentTile = "DiningArea";
        }

        else if (room.tag == "BackroomVent")     //Vent
        {
            VcurrentTile = "Kitchen";
        }

        else if (room.tag == "Backroom")
        {
            VcurrentTile = "Backroom";
        }

        else if (room.tag == "Unisex")
        {
            VcurrentTile = "Unisex";
        }

        else if (room.tag == "Boys")
        {
            VcurrentTile = "Boys";
        }

        else if (room.tag == "Girls") 
        {
            VcurrentTile = "Girls";
        }

        else if (room.tag == "GirlsVent") //Vent
        {
            VcurrentTile = "SupplyCloset";
        }

        else if (room.tag == "Restrooms")
        {
            VcurrentTile = "Restrooms";
        }

        else if (room.tag == "PirateCove")
        {
            VcurrentTile = "PirateCove";
        }

        else if (room.tag == "SupplyCloset")
        {
            VcurrentTile = "SupplyCloset";
        }

        else if (room.tag == "SupplyClosetVent") //Vent
        {
            VcurrentTile = "Girls";
            Vanessa.transform.position = GirlsBlue.position;
        }

        else if (room.tag == "Arcade")
        {
            VcurrentTile = "Arcade";
        }

        else if (room.tag == "WestHall")
        {
            VcurrentTile = "WestHall";
        }

        else if (room.tag == "PrizeCorner")
        {
            VcurrentTile = "PrizeCorner";
        }

        else if (room.tag == "EastHall")
        {
            VcurrentTile = "EastHall";
        }

        else if (room.tag == "EastHallVent") //Vent
        {
            VcurrentTile = "Controlroom";
        }

        else if (room.tag == "Kitchen")
        {
            VcurrentTile = "Kitchen";
        }

        else if (room.tag == "KitchenVent")//Vent
        {
            VcurrentTile = "Backroom";
        }

        else if (room.tag == "Entrance")
        {
            VcurrentTile = "Entrance";
        }



        Vtiles.Add(VcurrentTile);
        Debug.Log(VcurrentTile);

    }


    
    public void FindLast(List<string> tiles)
    {
        tiles.Last();
    }
}
