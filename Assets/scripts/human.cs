using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class human : MonoBehaviour
{
    public GameObject Key;
    Animator animator;
    public GameObject Key_image;
    public GameObject hasami;
    public GameObject hasami_image;
    public GameObject tuta;
    public GameObject salt_image;
    public GameObject salt;
    public GameObject horror;
    public GameObject bikkuriimage;
   
   
    float speed = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Key.gameObject.SetActive(true);
        Key_image.gameObject.SetActive(false);
        hasami.gameObject.SetActive(true);
        hasami_image.gameObject.SetActive(false);
        tuta.gameObject.SetActive(true);
        salt.gameObject.SetActive(true);
        salt_image.gameObject.SetActive(false);
        horror.gameObject.SetActive(true);
        bikkuriimage.gameObject.SetActive(false);
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
    }
    
    void OnCollisionStay2D(Collision2D col)
    {

        if (col.gameObject.tag == "Key")
        {
            Key.gameObject.SetActive(false);
            Key_image.gameObject.SetActive(true);
            Debug.Log("key");
        }
        if (col.gameObject.tag == "hasami")
        {
            hasami.gameObject.SetActive(false);
            hasami_image.gameObject.SetActive(true);
            Debug.Log("hasami");
        }
        if (col.gameObject.tag == "salt")
        {
            salt.gameObject.SetActive(false);
            salt_image.gameObject.SetActive(true);
            Debug.Log("salt");
        }
       
           
   
       
        if (col.gameObject.tag == "tuta")
        {
            if (hasami_image.gameObject.activeSelf == true)
            {
                tuta.gameObject.SetActive(false);
                hasami_image.gameObject.SetActive(false);
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

                }
            }
        }
    }



    private void OnTriggerExit2D(Collider2D collision)
    {
        bikkuriimage.gameObject.SetActive(false);
    }

}





