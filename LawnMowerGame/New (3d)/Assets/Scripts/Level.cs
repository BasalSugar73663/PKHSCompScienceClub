using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Level : MonoBehaviour
{
    public GameObject[] prefabs;
    private int sizeX;
    private int sizeY;

    void Start()
    {
        string[] mapData = ReadLevelText();

        sizeX = mapData[0].ToCharArray().Length;
        sizeY = mapData.Length;

        for(int y = 0; y < sizeY; y++)
        {
            char[] newTiles = mapData[y].ToCharArray();
            for(int x = 0; x < sizeX; x++)
            {
                PlaceTile(x - sizeX/2, y - sizeY/2, newTiles[x].ToString());
            }
        }
    }

    private void PlaceTile(int x, int y, string tileType)
    {
        int tileIndex = int.Parse(tileType);

        GameObject tile = Instantiate(prefabs[tileIndex], new Vector3(x, 0, y), Quaternion.identity);
    }

    private string[] ReadLevelText()
    {
        TextAsset bindData = Resources.Load("map") as TextAsset;

        string data = bindData.text.Replace(Environment.NewLine, string.Empty);

        return data.Split('-');
    }

}
