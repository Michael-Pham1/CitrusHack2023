using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public MazeGenerator mazeGen;
    public GameObject player;
    public GameObject mazeGenOb;
    private GameObject endCell;
    void Start(){
        mazeGen = mazeGenOb.GetComponent<MazeGenerator>();
    }
    // Update is called once per frame
    void Update(){
        endCell = mazeGen.endCell;

    }
}
