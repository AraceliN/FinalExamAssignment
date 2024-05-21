using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TileTypes;

public class SharedRoomResult : MonoBehaviour
{
    public TileTracker Chica;
    public TileTracker Foxy;
    public TileTracker Freddy;
    public TileTracker Vanessa;

    public bool InRoomWithFreddy;
    public bool InRoomWithChica;
    public bool InRoomWithFoxy;

    List<TileInfo> ChicaTiles = new List<TileInfo>();
    List<TileInfo> FreddyTiles = new List<TileInfo>();
    List<TileInfo> FoxyTiles = new List<TileInfo>();


    // Start is called before the first frame update
    void Start()
    {
        if (Chica.currentTile == Vanessa.currentTile)
        {

        }
        else if (Foxy.currentTile == Vanessa.currentTile)
        {

        }
        else if (Freddy.currentTile == Vanessa.currentTile)
        {

        }

        List<TileInfo> freddyTiles = new List<TileInfo>();
        Freddy.GetComponents(freddyTiles);

        List<TileInfo> foxyTiles = new List<TileInfo>();
        Foxy.GetComponents(foxyTiles);


        InRoomWithFreddy = false;
        InRoomWithChica = false;
        InRoomWithFoxy = false;
    }

    // Update is called once per frame
    void Update()
    {


    }

}   
