using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenManager : MonoBehaviour
{
    float countTime = 0;
    public Text motionText;
    public GetMotionList getMotionList;
    
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime;
        GetComponent<Text>().text = countTime.ToString("F2");

        motionText.text = "Motion : " + gameObject.transform.position.z;
        

        
        
    }
}
