using UnityEngine;

public class Room
{
    public int xPos;
    public int yPos;
    public int roomWidth;
    public int roomHeight;

    public void SetupRoom(IntRange widthRange, IntRange heightRange, int columns, int rows)
    {
        roomWidth = widthRange.Random;
        roomHeight = heightRange.Random;

        xPos = Mathf.RoundToInt(columns / 2f - roomWidth / 2f);
        yPos = Mathf.RoundToInt(rows / 2f - roomHeight / 2f);
    }