using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public GameObject tileA;
    public float length = 100;
    public float width = 100;
    public int lengthBin = 100;
    public int widthBin = 100;

    Vector2[,] tileLoc;

    // Start is called before the first frame update
    void Start()
    {
        tileLoc = new Vector2[lengthBin, widthBin];
        for (int i = 0; i < lengthBin; i++)
        {
            for (int j = 0; j < widthBin; j++)
            {
                // Set the Vector2 location for each tile (i, j)
                float x = i * (length / lengthBin) - (length / 2);
                float y = j * (width / widthBin) - (width / 2);
                tileLoc[i, j] = new Vector2(x, y);

                GameObject quadInstance = Instantiate(tileA, transform);
                quadInstance.transform.localPosition = new Vector3(x, 0, y);
                quadInstance.transform.localRotation = Quaternion.identity;
                //
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
