using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{


    float speed = 1.5f;
    int key = 0;
    bool gameover = false;
    bool gameclear = false;
    bool hasigo = false;
    bool down = false;
    
    public GameObject gameovercanvas;
    public GameObject gameclearcanvas;
    public Rigidbody2D rb2d;


    // Start is called before the first frame update
    void Start()
    {
        gameovercanvas.SetActive(false);
        gameclearcanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (down == true)

            if (Input.GetKey("down"))
            {
                rb2d.velocity = Vector2.zero;
            }

        if (!gameover &&!gameclear){
          

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
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "hashigo") {
            hasigo = true;
        }
        if(other.gameObject.tag == "down")
        {
            down = true;
            Debug.Log("Down");
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "hashigo")
        {
            hasigo = false;

        }
        if(collision.gameObject.tag == "down")
        {
            down = false;
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

