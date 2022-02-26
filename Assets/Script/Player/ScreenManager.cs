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
        //タイマーの表示
        countTime += Time.deltaTime;
        GetComponent<Text>().text = countTime.ToString("F2");

        //得たモーションを画面上に表示する。

        motionText.text = "Motion : " + gameObject.GetComponent<GetMotionList>();
        Debug.Log(motionText.text);
        

        
        
    }
    GetMotionList DisplayMotion()
    {
        return getMotionList;
    }
}
