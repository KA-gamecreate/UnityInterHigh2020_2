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
    bool enemy = false;
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
    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "down")
        {
            if (Input.GetKeyDown("down"))
            {
                col.gameObject.GetComponent<PlatformEffector2D>().surfaceArc = 0;
                StartCoroutine(TurnSurfaceArc(col.gameObject));
            }
            if (Input.GetKeyDown("up"))
            {
                transform.position += Vector3.up * 1.2f;
            }
        }
    }
    private IEnumerator TurnSurfaceArc(GameObject obj)
    {
        yield return new WaitForSeconds(1.0f);
        obj.GetComponent<PlatformEffector2D>().surfaceArc = 180;
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

