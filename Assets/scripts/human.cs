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
 

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Key.gameObject.SetActive(true);
        Key_image.gameObject.SetActive(false);
        hasami.gameObject.SetActive(true);
        hasami_image.gameObject.SetActive(false);
        tuta.gameObject.SetActive(true);
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

        if (hasami_image.gameObject.activeSelf)
            {
            if(col.gameObject.tag == "tuta")
                {
                    tuta.gameObject.SetActive(false);
                    hasami_image.gameObject.SetActive(false);
                }
            }
        
        }
}


