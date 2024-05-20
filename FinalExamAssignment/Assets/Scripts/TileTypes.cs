using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TileTypes : MonoBehaviour
{
    public enum Room
    {
        None,
        ControlRoom,
        Stage,
        SecurityOffice,
        DiningArea,
        BackRoom,
        Unisex,
        Boys,
        Girls,
        Restrooms,
        PirateCove,
        SupplyCloset,
        Arcade,
        WestHall,
        PrizeCorner,
        EastHall,
        Kitchen,
        Entrance

    }
    public enum Tiletype
    {
        Standard,
        Blue,
        Corridor,
        Vent
    }

    public class TileInfo
    {
        public Room room;
        public Tiletype type;

        //A constructor for tiles that contains their roomtype and tiletype
        public TileInfo(Room roomtype, Tiletype tile)
        {
            room = roomtype;
            type = tile;
        }


    }

}
