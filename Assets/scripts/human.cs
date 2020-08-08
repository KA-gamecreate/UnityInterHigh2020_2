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
    public GameObject hasigo;
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

        if (hasami_image.gameObject.activeSelf)
        {
            if (col.gameObject.tag == "tuta")
            {
                tuta.gameObject.SetActive(false);
                hasami_image.gameObject.SetActive(false);
            }
        }
        if (salt_image.gameObject.activeSelf)
            {
                Debug.Log("A");
                if (col.gameObject.tag == "enemy")
                {
                    bikkuriimage.gameObject.SetActive(true);
                    Debug.Log("ready");
                    if (Input.GetKeyDown(KeyCode.A))
                    {
                        Destroy(col.gameObject, 1.0f);
                    }
                }
            }
    }

    void OnTriggerEnterStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "hashigo")
        {
            Debug.Log("hasigo");
            if (Input.GetKeyDown("up"))
            {
                transform.position += new Vector3(0, speed * Time.deltaTime, 0);
            }
            if (Input.GetKeyDown("down"))
            {
                transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
        {
            bikkuriimage.gameObject.SetActive(false);
        }

    }




