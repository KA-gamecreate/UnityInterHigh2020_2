using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{


    float speed = 1.5f;
    int key = 0;
    bool gameover = false;
    bool gameclear = false;
    public GameObject gameovercanvas;
    public GameObject gameclearcanvas;


    // Start is called before the first frame update
    void Start()
    {
        gameovercanvas.SetActive(false);
        gameclearcanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameover){


            if (Input.GetKey("right"))
            {
                transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
                key = 1;
            }
            if (Input.GetKey("left"))
            {
                transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
                key = -1;
            }
            if (key != 0)
            {
                transform.localScale = new Vector3(key, 1, 1);
            }
        }
    }



    private void Gameover()
    {
        gameover = true;
        gameovercanvas.SetActive(true);
    }
    private void Gameclear()
    {
        gameclear = true;
        gameclearcanvas.SetActive(true);
    }



}

