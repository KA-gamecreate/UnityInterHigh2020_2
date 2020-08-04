using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EventController : MonoBehaviour
{

    public TextController textController;

    //
    bool Atalkedflag = false;
    public static bool sampleflag = true;

    //今イベントで使っているシナリオ
    string[] scenarios;


    //キャラクターから使われる命令
    public void StartEvent(bool flag, string[] inputScenarios)
    {
        Atalkedflag = flag;
        this.scenarios = inputScenarios;
    }


    void Update()
    {

    }

    //ボタンが押されたときの命令
    public void AButton()
    {
        if (Atalkedflag)
        {
            //textController.Click();
            textController.StartText(scenarios);
            Atalkedflag = false;
        }

    }


   

}
