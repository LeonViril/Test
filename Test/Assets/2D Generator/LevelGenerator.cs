using UnityEngine;
using System.Collections;

public class LevelGenerator : MonoBehaviour {

    public enum TileType
    {
        Wall, Floor, Door
    }

    public int columns = 100;
    public int rows = 100;
    public IntRange numRooms = new IntRange(5, 10);
    public IntRange roomWidth = new IntRange(1, 5);
    public IntRange roomHeight = new IntRange(1, 5);
    public GameObject[] floorTiles;
    public GameObject[] wallTiles;
    public GameObject[] doorTile;
    public GameObject[] player;

    private TileType[][] tiles;
    private Room[] rooms;
    private GameObject boardHolder;

    // Use this for initialization
    private void Start () {

        GameObject boardHolder = new GameObject("BoardHolder");

        SetupTilesArray()
        GenerateNewLevel()
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    void SetupTilesArray()
    {
        tiles = new TileType[columns][];

        for (int i = 0; i <tiles.Length; i++)
        {
            tiles[i] = new TileType[rows];
        }
    }

    void GenerateNewLevel()
    {
        rooms = new Room[numRooms.Random];
        door = new Door[]

        rooms[0] = new Room();
        door[0] = new Door();

        rooms[0].SetupRoom(roomWidth, roomHeight, columns, rows);
        
    }

}
