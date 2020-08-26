using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost : MonoBehaviour
{
    BoxCollider2D boxCollider2D;
    public GameObject bikkuri;
    public GameObject mybikkuri;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        bikkuri.gameObject.SetActive(false);
        mybikkuri.gameObject.SetActive(false);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionStay2D(Collision2D col)
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
        bikkuri.gameObject.SetActive(true);
        if (col.gameObject.tag == "enemy")
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Destroy(col.gameObject,1.0f);
                animator.SetInteger("obake", 1);
                Invoke("AnimeReset",1);
            }
        }  
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        bikkuri.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "himawari")
        {
            mybikkuri.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        mybikkuri.gameObject.SetActive(false);
    }


    void AnimeReset()
    {
        animator.SetInteger("obake", 0);
        Debug.Log("a");
    }
 
}

