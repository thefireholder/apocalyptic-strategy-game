using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject tileA;
    public float length = 100;
    public float width = 100;
    public int lengthBin = 100;
    public int widthBin = 100;

    Vector2[,] tilePos; // position refers to float coordinate x,y
    Character[,] characterCoord; // location refer to integer location i,j

    // Start is called before the first frame update
    void Start()
    {
        Wipe();
        CreateTiles();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateTiles()
    {
        tilePos = new Vector2[lengthBin, widthBin];
        for (int i = 0; i < lengthBin; i++)
        {
            for (int j = 0; j < widthBin; j++)
            {
                // Set the Vector2 location for each tile (i, j)
                float x = i * (length / lengthBin) - (length / 2);
                float y = j * (width / widthBin) - (width / 2);
                tilePos[i, j] = new Vector2(x, y);

                GameObject quadInstance = Instantiate(tileA, transform);
                quadInstance.transform.localPosition = new Vector3(x, 0, y);
                quadInstance.transform.localRotation = Quaternion.identity;
            }
        }
    }

    public void Wipe()
    {
        characterCoord = new Character[lengthBin, widthBin];
    }

    public void SpawnPlayer(Vector2 coord)
    {

    }

    public void SpawnEnemy(Vector2 coord, string enemyType = "", int level = 1, int hp = -1)
    {

    }

}
