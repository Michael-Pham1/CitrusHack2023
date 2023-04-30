using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI display;
    public GameObject player;
    private CharacterMovement cm;
    
    void Start()
    {
        cm = player.GetComponent<CharacterMovement>();
        StartCoroutine(Score());
    }
    
    IEnumerator Score()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.3f);
            display.text = "Score: " + cm.score.ToString();
        }
    }
    // void Update(){
        
    // }
}