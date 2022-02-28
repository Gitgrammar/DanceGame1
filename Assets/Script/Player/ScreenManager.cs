using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScreenManager : MonoBehaviour
{
    float countTime = 0;
    public PlayerPrefs motions;
    public GameObject player;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //タイマーの表示
        countTime += Time.deltaTime;
       GetComponent<Text>().text = countTime.ToString("F2");

       



    }
        
   
}
