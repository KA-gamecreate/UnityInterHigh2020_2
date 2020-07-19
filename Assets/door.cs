using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    BoxCollider2D boxCollider2D;
    public GameObject goal;
    public GameObject idou;

    public GameObject Keyimage;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
        boxCollider2D.isTrigger = false;
        goal.gameObject.SetActive(true);
        idou.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (Keyimage.gameObject.activeSelf)
        {
            if (col.gameObject.tag == "Player")
            {
                boxCollider2D.isTrigger = true;
                goal.gameObject.SetActive(false);
                idou.gameObject.SetActive(true);
                Keyimage.gameObject.SetActive(false);
            }
        }
    }
}
