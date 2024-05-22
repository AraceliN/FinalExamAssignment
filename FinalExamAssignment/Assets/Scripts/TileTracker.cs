using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TileTypes;
using System.Linq;
using Unity.VisualScripting;

public class TileTracker : MonoBehaviour
{

    public string currentTile;
    List<string> tiles = new List<string>();
    // List<TileInfo> TravelledTiles = new List<TileInfo>();



    GameObject RoomCollider;
    GameObject Vanessa;
    

    public VanessaTileTracker vanessaTileTracker;
    
    Vector2 characterPos;
    string AnimatronicTile;
    string VcurrentTile;

    public void Start()
    {
    
        Vanessa.GetComponent<VanessaTileTracker>();
        
    }

    public void Update()
    {
        
        AnimatronicTile = currentTile;
        SameTileAsVanessa();
        
    }

    public void SameTileAsVanessa()
    {
        if (AnimatronicTile == VcurrentTile)
        {
            Debug.Log("Oopsie you're dead");
        }
    }

    public void OnTriggerEnter2D(Collider2D room)
    {
        if (room.tag == "Controlroom")
        {
            currentTile = "Controlroom";
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

        else if (room.tag == "Kitchen")
        {
            currentTile = "Kitchen";
        }

        else if (room.tag == "Entrance")
        {
            currentTile = "Entrance";
        }



        tiles.Add(currentTile);
        Debug.Log(currentTile);

    }


    /*public void OnTriggerEnter2D(Collider2D room)
    {

        if (room.tag == "ControlRoom")
        {
            TileInfo currentTile = new TileInfo(Room.ControlRoom, Tiletype.Standard);
        }
        else if (room.tag == "Stage")
        {
            TileInfo currentTile = new TileInfo(Room.Stage, Tiletype.Standard);
        }
        else if (room.tag == "SecurityOffice")
        {
            TileInfo currentTile = new TileInfo(Room.SecurityOffice, Tiletype.Standard);
        }
        else if (room.tag == "DiningArea")
        {
            TileInfo currentTile = new TileInfo(Room.DiningArea, Tiletype.Standard);
        }
        else if (room.tag == "BackRoom")
        {
            TileInfo currentTile = new TileInfo(Room.BackRoom, Tiletype.Standard);
        }
        else if (room.tag == "Unisex")
        {
            TileInfo currentTile = new TileInfo(Room.Unisex, Tiletype.Standard);
        }
        else if (room.tag == "Boys")
        {
            TileInfo currentTile = new TileInfo(Room.Boys, Tiletype.Standard);
        }
        else if (room.tag == "Girls")
        {
            TileInfo currentTile = new TileInfo(Room.Girls, Tiletype.Standard);
        }
        else if (room.tag == "Restrooms")
        {
            TileInfo currentTile = new TileInfo(Room.Restrooms, Tiletype.Standard);
        }
        else if (room.tag == "Pirate")
        {
            TileInfo currentTile = new TileInfo(Room.PirateCove, Tiletype.Standard);
        }
        else if (room.tag == "SupplyCloset")
        {
            TileInfo currentTile = new TileInfo(Room.SupplyCloset, Tiletype.Standard);
        }
        else if (room.tag == "Arcade")
        {
            TileInfo currentTile = new TileInfo(Room.Arcade, Tiletype.Standard);
        }
        else if (room.tag == "WestHall")
        {
            TileInfo currentTile = new TileInfo(Room.WestHall, Tiletype.Standard);
        }
        else if (room.tag == "PrizeCorner")
        {
            TileInfo currentTile = new TileInfo(Room.PrizeCorner, Tiletype.Standard);
        }
        else if (room.tag == "EastHall")
        {
            TileInfo currentTile = new TileInfo(Room.EastHall, Tiletype.Standard);
        }
        else if (room.tag == "Kitchen")
        {
            TileInfo currentTile = new TileInfo(Room.Kitchen, Tiletype.Standard);
        }
        else if (room.tag == "Entrance")
        {
            TileInfo currentTile = new TileInfo(Room.Entrance, Tiletype.Standard);
        }
        else
        {
            TileInfo currentTile = new TileInfo(Room.None, Tiletype.Standard);
        }


        TravelledTiles.Add(currentTile);
        Debug.Log(currentTile);

    }*/
    //Adds the current Tile being stood on to the list
    //Make sure parent object at (0;0)
    /* public void AddTiles(List<TileInfo> travelledtiles )
        {
          Vector2 characterPos = character.GetComponent<Transform>().position;

             //Control Room
             if(3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
             {
                 if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.ControlRoom, Tiletype.Blue);
                 }
                 else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.ControlRoom, Tiletype.Vent);
                 }
                 else
                 {
                     TileInfo currentTile = new TileInfo(Room.ControlRoom, Tiletype.Standard);
                 }
             }

             //Stage
             else if(3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
             {
                 if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.Stage, Tiletype.Blue);
                 }
                 else
                 {
                     TileInfo currentTile = new TileInfo(Room.Stage, Tiletype.Standard);
                 }
             }

             //Security Office
             else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
             {
                 if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.SecurityOffice, Tiletype.Blue);
                 }
                 else
                 {
                     TileInfo currentTile = new TileInfo(Room.SecurityOffice, Tiletype.Standard);
                 }
             }

             //Dining Area
             else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
             {
                 if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.DiningArea, Tiletype.Blue);
                 }
                 else
                 {
                     TileInfo currentTile = new TileInfo(Room.DiningArea, Tiletype.Standard);
                 }
             }

             //Backroom
             else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
             {
                 if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.BackRoom, Tiletype.Blue);
                 }
                 else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.BackRoom, Tiletype.Vent);
                 }
                 else
                 {
                     TileInfo currentTile = new TileInfo(Room.BackRoom, Tiletype.Standard);
                 }
             }

             // Unisex
             else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
             {
                 if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.Unisex, Tiletype.Blue);
                 }
                 else
                 {
                     TileInfo currentTile = new TileInfo(Room.Unisex, Tiletype.Standard);
                 }
             }

             //Boys
             else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
             {
                 if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.Boys, Tiletype.Blue);
                 }
                 else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.Boys, Tiletype.Vent);
                 }
                 else
                 {
                     TileInfo currentTile = new TileInfo(Room.Boys, Tiletype.Standard);
                 }
             }

             // Girls
             else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
             {
                 if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.Girls, Tiletype.Blue);
                 }
                 else
                 {
                     TileInfo currentTile = new TileInfo(Room.Girls, Tiletype.Standard);
                 }
             }

             // Restrooms
             else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
             {
                 if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.Restrooms, Tiletype.Blue);
                 }
                 else
                 {
                     TileInfo currentTile = new TileInfo(Room.Restrooms, Tiletype.Standard);
                 }
             }

             // Pirate Cove
             else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
             {
                 if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.PirateCove, Tiletype.Blue);
                 }
                 else
                 {
                     TileInfo currentTile = new TileInfo(Room.PirateCove, Tiletype.Standard);
                 }
             }

             //Supply Closet
             else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
             {
                 if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.SupplyCloset, Tiletype.Blue);
                 }
                 else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.SupplyCloset, Tiletype.Vent);
                 }
                 else
                 {
                     TileInfo currentTile = new TileInfo(Room.SupplyCloset, Tiletype.Standard);
                 }
             }

             //Arcade
             else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
             {
                 if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.Arcade, Tiletype.Blue);
                 }
                 else
                 {
                     TileInfo currentTile = new TileInfo(Room.Arcade, Tiletype.Standard);
                 }
             }

             // WestHall
             else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
             {
                 if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.WestHall, Tiletype.Blue);
                 }
                 else
                 {
                     TileInfo currentTile = new TileInfo(Room.WestHall, Tiletype.Standard);
                 }
             }

             // PrizeCorner
             else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
             {
                 if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.PrizeCorner, Tiletype.Blue);
                 }
                 else
                 {
                     TileInfo currentTile = new TileInfo(Room.PrizeCorner, Tiletype.Standard);
                 }
             }
             // EastHall
             else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
             {
                 if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.EastHall, Tiletype.Blue);
                 }
                 else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.EastHall, Tiletype.Vent);
                 }
                 else
                 {
                     TileInfo currentTile = new TileInfo(Room.EastHall, Tiletype.Standard);
                 }
             }

             // Kitchen
             else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
             {
                 if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.Kitchen, Tiletype.Blue);
                 }
                 else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.Kitchen, Tiletype.Vent);
                 }
                 else
                 {
                     TileInfo currentTile = new TileInfo(Room.Kitchen, Tiletype.Standard);
                 }
             }
             // Entrance
             else if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
             {
                 if (3 <= characterPos.x && characterPos.x <= 5 && 3 <= characterPos.y && characterPos.y <= 5)
                 {
                     TileInfo currentTile = new TileInfo(Room.Entrance, Tiletype.Blue);
                 }
                 else
                 {
                     TileInfo currentTile = new TileInfo(Room.Entrance, Tiletype.Standard);
                 }
             }

         TravelledTiles.Add(currentTile);
        }*/


    // Finds the most recent item in the list
    public void FindLast(List<string> tiles)
    {
        tiles.Last();
    }
}
