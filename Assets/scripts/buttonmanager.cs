using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonmanager : MonoBehaviour
{
    public GameObject menu;
    public GameObject leftway;
    
    // Start is called before the first frame update
    void Start()
    {
        menu.gameObject.transform.Translate(3, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Stage1()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void Back()
    {
        SceneManager.LoadScene("title");
    }

    public void Select()
    {
        SceneManager.LoadScene("select");
    }
    public void Stage2()
    {
        SceneManager.LoadScene("Tutorial2");
    }
    public void Stage3()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void Stage4()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void Stage5()
    {
        SceneManager.LoadScene("Stage3");
    }
    public void Stage6()
    {
        SceneManager.LoadScene("Stage4");
    }
    public void Stage7()
    {
        SceneManager.LoadScene("Stage5");
    }
    public void Stage8()
    {
        SceneManager.LoadScene("Stage6");
    }
    public void Stage9()
    {
        SceneManager.LoadScene("Stage7");
    }
    public void Stage10()
    {
        SceneManager.LoadScene("Stage8");
    }
    public void Stage11()
    {
        SceneManager.LoadScene("Stage9");
    }
    public void Stage12()
    {
        SceneManager.LoadScene("Stage10");
    }
    public void Go()
    {
        SceneManager.LoadScene("select2");
    }
    public void right()
    {
        menu.gameObject.transform.Translate(3, 0, 0);

    }
    public void left()
    {
        menu.gameObject.transform.Translate(-3, 0, 0);
    }

}

