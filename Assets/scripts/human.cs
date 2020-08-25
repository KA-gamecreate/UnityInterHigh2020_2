using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class human : MonoBehaviour
{
    bool gameover = false;
    public GameObject Key;
    Animator animator;
    public GameObject Key_image;

    public GameObject salt_image;
    public GameObject salt;
    public GameObject kira_image;
    public GameObject kira;
    public GameObject kira2;
    public GameObject bikkuriimage;
    public GameObject bikkuri2;
    public GameObject hasami;
    public GameObject hasami_image;
    public GameObject tuta;
    public GameObject pikkeru;
    public GameObject pikkeruimage;
    public GameObject umbrellaimage;
    public GameObject umbrellaimage2;


    float speed = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        umbrellaimage.gameObject.SetActive(false);
        umbrellaimage2.gameObject.SetActive(true);
        Key_image.gameObject.SetActive(false);
        kira.gameObject.SetActive(true);
        kira2.gameObject.SetActive(true);
        kira_image.gameObject.SetActive(false);
        salt.gameObject.SetActive(true);
        salt_image.gameObject.SetActive(false);
        bikkuriimage.gameObject.SetActive(false);
        bikkuri2.gameObject.SetActive(false);
        hasami.gameObject.SetActive(true);
        hasami_image.gameObject.SetActive(false);
        tuta.gameObject.SetActive(true);
        pikkeru.gameObject.SetActive(true);
        pikkeruimage.gameObject.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            animator.SetInteger("Chara", 1);
            
        }

        if (Input.GetKey("left"))
        {
            animator.SetInteger("Chara", 1);
            
        }
        if (Input.GetKeyUp("right"))
        {
            animator.SetInteger("Chara", 0);
            
        }
        if (Input.GetKeyUp("left"))
        {
            animator.SetInteger("Chara", 0);
            
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            animator.SetInteger("jump", 0);
            
        }
        if (umbrellaimage.gameObject.activeSelf == true)
        {
            if (Input.GetKeyUp(KeyCode.A))
            {
                umbrellaimage2.gameObject.SetActive(true);
                umbrellaimage.gameObject.SetActive(false);
                Debug.Log("close");
            }
        }
        if (umbrellaimage2.gameObject.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                umbrellaimage.gameObject.SetActive(true);
                umbrellaimage2.gameObject.SetActive(false);
                Debug.Log("open");
            }
        }
       

    }
    
    void OnCollisionStay2D(Collision2D col)
    {
 
        if (col.gameObject.tag == "Key")
        {
            Key.gameObject.SetActive(false);
            Key_image.gameObject.SetActive(true);
            Debug.Log("key");
        }
       
        if (col.gameObject.tag == "salt")
        {
            salt.gameObject.SetActive(false);
            salt_image.gameObject.SetActive(true);
            Debug.Log("salt");
        }
        if (col.gameObject.tag == "Ground")
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                animator.SetInteger("jump", 1);
            }
        }
        if (col.gameObject.tag == "kira")
        {
            kira.gameObject.SetActive(false);
            kira_image.gameObject.SetActive(true);
           
        }
        if (col.gameObject.tag == "kira2")
        {
            kira2.gameObject.SetActive(false);
            kira_image.gameObject.SetActive(true);
          
        }


        if (col.gameObject.tag == "tuta")
        {
            if (hasami_image.gameObject.activeSelf == true)
            {
                tuta.gameObject.SetActive(false);
                hasami_image.gameObject.SetActive(false);
            }
        }
       
        if (col.gameObject.tag == "hasami")
        {
            hasami.gameObject.SetActive(false);
            hasami_image.gameObject.SetActive(true);
            Debug.Log("hasami");
        }
        if (col.gameObject.tag == "pikkeru")
        {
            pikkeru.gameObject.SetActive(false);
            pikkeruimage.gameObject.SetActive(true);
        }

        if (col.gameObject.tag == "ice")
        {
            if (pikkeruimage.gameObject.activeSelf == true)
            {            
                if (Input.GetKeyDown(KeyCode.A))
                {
                    Destroy(col.gameObject,1.0f);
                    Debug.Log("destroy");
                    animator.SetInteger("attack", 1);
                }

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "enemy")
        {
            if (salt_image.gameObject.activeSelf == true)
            {
                bikkuriimage.gameObject.SetActive(true);


                if (Input.GetKeyDown(KeyCode.A))
                {
                    Destroy(collision.gameObject, 1.0f);
                    Debug.Log("destroy");
                    salt_image.gameObject.SetActive(false);
                    animator.SetInteger("attack", 1);
                    Invoke("AnimeReset", 1);

                }

            }
        }

            if (collision.gameObject.tag == "enemy2")
            {
                if (salt_image.gameObject.activeSelf == true)
                {
                    bikkuri2.gameObject.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.A))
                    {
                        Destroy(collision.gameObject, 1.0f);
                        Debug.Log("destroy2");
                        salt_image.gameObject.SetActive(false);
                        animator.SetInteger("attack", 1);
                        Invoke("AnimeReset", 1);
                    }
                }
            }

        
    }



    private void OnTriggerExit2D(Collider2D collision)
    {
        bikkuriimage.gameObject.SetActive(false);
    }

    void AnimeReset()
    {
        animator.SetInteger("attack", 0);
        Debug.Log("a");
    }
   

}





