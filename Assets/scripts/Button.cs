using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

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
}

