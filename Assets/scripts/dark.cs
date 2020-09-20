using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class dark : MonoBehaviour
{

    public readonly float fadeTime = 0.4f;  //フェードにかかる時間
    float fadeDeltaTime = 0;
    //フェードに使った時間
    float changetime = 0f;
    bool fade = false;

    public GameObject player;


    public Image image;    //フェードに使う画像

    private IEnumerator FadeInCoroutine()
    {
        float alpha = 1;                            //色の不透明度
        Color color = new Color(0, 0, 0, alpha);    //Imageの色変更に使う
        this.fadeDeltaTime = 0;                     //初期化
        this.image.color = color;                   //色の初期化(黒)
        do
        {
            yield return null;                      //次フレームで再開
            this.fadeDeltaTime += Time.unscaledDeltaTime;       //時間の加算
            alpha = 1 - (this.fadeDeltaTime / this.fadeTime);   //透明度の決定
            if (alpha < 0)
            {
                alpha = 0;                          //alphaの値の制限
            }
            color.a = alpha;                        //色の透明度の決定
            this.image.color = color;               //色の代入
        }
        while (this.fadeDeltaTime <= this.fadeTime);
    }

    private IEnumerator FadeOutCoroutine()
    {
        float alpha = 0;                            //色の不透明度
        Color color = new Color(0, 0, 0, alpha);    //Imageの色変更に使う
        this.fadeDeltaTime = 0;                     //初期化
        this.image.color = color;                   //色の初期化
        do
        {
            yield return null;                      //次フレームで再開
            this.fadeDeltaTime += Time.unscaledDeltaTime;       //時間の加算
            alpha = this.fadeDeltaTime / this.fadeTime;         //透明度の決定
            if (alpha > 1)
            {
                alpha = 1;                          //alphaの値の制限
            }
            color.a = alpha;                        //色の透明度の決定
            this.image.color = color;               //色の代入
        }
        while (this.fadeDeltaTime <= this.fadeTime);



    }
    private void Update()
    {
        if (player.GetComponent<Player>().gameover == false && player.GetComponent<Player>().gameclear == false)
        {
            changetime += Time.deltaTime;
            if (changetime > 2 && fade == false)
            {
                fade = !fade;
                FadeIn();
                changetime = 0;
            }
            else if (changetime > 2 && fade == true)
            {
                fade = !fade;
                changetime = 0;
                FadeOut();
            }
        }
    }

    //外部から呼び出される
    public void FadeIn()
    {
        IEnumerator coroutine = FadeInCoroutine();
        StartCoroutine(coroutine);
    }
    public void FadeOut()
    {
        IEnumerator coroutine = FadeOutCoroutine();
        StartCoroutine(coroutine);
    }
}