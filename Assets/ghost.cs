using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost : MonoBehaviour
{
    BoxCollider2D boxCollider2D;
    public GameObject bikkuri;
    // Start is called before the first frame update
    void Start()
    {
        bikkuri.gameObject.SetActive(false);
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
            Debug.Log("test");
            if (Input.GetKeyDown(KeyCode.A))
            {
                Destroy(col.gameObject);
                bikkuri.gameObject.SetActive(false);
                Debug.Log("A");
               
            }

        }
    }
}

