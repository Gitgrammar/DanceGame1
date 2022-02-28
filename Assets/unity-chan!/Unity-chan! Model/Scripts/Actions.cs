using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Actions : MonoBehaviour
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
       
        GetMotionList motions = player.gameObject.GetComponent<GetMotionList>();

        List<string> actions = motions.motionList;

  

           
        foreach(string a in actions)
        {
            GetComponent<Text>().text =string.Join("\n", a);
            Debug.Log(a);
            Debug.Log(string.Join("\n", a));
        }
        


        //得たモーションを画面上に表示する。

        Debug.Log(string.Join(",", actions));

        Debug.Log(System.Tuple.Create(actions));

        Debug.Log("Guess What");


    }


}
