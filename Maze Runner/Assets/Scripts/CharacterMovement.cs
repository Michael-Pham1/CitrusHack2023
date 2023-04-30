using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float xDir, yDir;
    private Vector2 initialPosition;
    public GameObject mazeGenOb;
    private MazeGenerator mazeGen;
    private GameObject endCell;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = new Vector2(0,0);
        rb = GetComponent<Rigidbody2D>();
        mazeGen = mazeGenOb.GetComponent<MazeGenerator>();
        StartCoroutine(endCellDetection());
        score = 0;
    }

    IEnumerator endCellDetection(){
        while(true){
            endCell = mazeGen.endCell;
            yield return new WaitForSeconds(0.1f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        xDir = Input.GetAxisRaw("Horizontal");
        yDir = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(xDir * 7f, yDir * 7f);
        if(Input.GetKey(KeyCode.Space)){
            Application.Quit();
        }
        
    }

    void OnTriggerEnter2D(Collider2D collision){
        //Debug.Log(collision.gameObject.ToString());
        if(collision.gameObject == endCell){
            score++;
            GetComponent<Transform>().transform.position = initialPosition;
        }
    }
}
