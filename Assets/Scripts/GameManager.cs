using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    // making it singleton
    public Board board;
    public static GameManager Instance { get; private set; }

    public Vector2 boardDim
    {
        get
        {
            return new Vector2(100,100);
        }
    }

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        initiate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void MoveCharacterOnBoard(GameObject character, int x, int y)
    {
        Debug.Log("Moving character on Board");
    }

    public void initiate()
    {
        //// wipe board
        //board.Wipe();

        //// create tiles
        //board.CreateTiles();

        //// spawn player

        //// spawn enemy
    }

}
