using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{

    //EventControllerから来るシナリオを格納
    private string[] Receivedscenarios;
    //uiTextへの参照を保つ
    private Text uiText;

    //現在の行番号
    int currentLine;

    //セリフを表示するテクスト(文字の大きさや色はここにアタッチしたTextをいじって決定する)
    public Text message;
    //

    //テキストウィンドウ
    public GameObject panel;
    public GameObject Player;


    void Start()
    {

        panel.SetActive(false);
    }

    public void StartText(string[] scenarios)
    {

        Receivedscenarios = scenarios;
        currentLine = 0;
        uiText = message;
        //パネルを表示
        panel.SetActive(true);
        //テキストを表示
        uiText.gameObject.SetActive(true);
        TextUpdate();
        Debug.Log("start");
        

    }

    public void Click()
    {
        //現在の行番号がラストまで行ってない状態でボタンを押すとテキストを更新する
        if (currentLine < Receivedscenarios.Length)
        {
            TextUpdate();
        }
        else
        {
            //最後まで行ったら、テキストとテキストウィンドウを消す
            uiText.gameObject.SetActive(false);
            panel.SetActive(false);

        }


    }


    public void TextUpdate()
    {
        //現在の行番号をuiTextに流し込み、現在の行番号を一つ追加する
        uiText.text = Receivedscenarios[currentLine];
        currentLine++;
    }


}