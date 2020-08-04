
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story1 : MonoBehaviour
{


    //ここに文章データ
    public string[] scenarios;

   

   

    bool Aflagflag = false;

    public EventController eventScript;
    public TextController textController;



    void Start()
    {
   
        
    }


    void Update()
    {
        if (Aflagflag)
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                eventScript.AButton();
                textController.Click();
                Debug.Log("b");
            }
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {

        //近づいたらUI表示させる
        if (col.gameObject.tag == "Player")
        {
            Aflagflag = true;
            Debug.Log("test");
            eventScript.StartEvent(Aflagflag, scenarios);

        }
    }

}
