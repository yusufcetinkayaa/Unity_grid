using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grid : MonoBehaviour
{
    [SerializeField] private int n;
    [SerializeField] private Tile tile;
    [SerializeField] private Transform cam;
    void Start()
    {
        GenerateGrid();
    }
    public void GenerateGrid()
    {
        for (int x = 0; x < n; x++)
        {
            for (int y = 0; y < n; y++)
            {
                var spawnTile = Instantiate(tile, new Vector3(x, y), Quaternion.identity);
                spawnTile.name = $"Tile {x} {y}";
            }
        }
        cam.transform.position = new Vector3((float)n / 2 - 0.5f, (float)n / 2 - 0.5f, -10);
    }
}

