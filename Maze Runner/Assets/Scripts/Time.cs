using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Time : MonoBehaviour
{
    public TextMeshProUGUI display;
    int time;
    
    void Start()
    {
        time = 0;
        StartCoroutine(CountTime());
    }
    
    IEnumerator CountTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            time++;
            display.text = "Time: " + time.ToString();
        }
    }
    // void Update(){
        
    // }
}