using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            Vector2 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)){
            Vector2 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow)){
            Vector2 position = this.transform.position;
            position.y++;
            this.transform.position = position;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)){
            Vector2 position = this.transform.position;
            position.y--;
            this.transform.position = position;
        }
    }
}
