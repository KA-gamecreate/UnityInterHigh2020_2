using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charachange : MonoBehaviour
{
    public bool charaA = false;
    public bool charaB = false;
    public static Charachange charachange;

    public GameObject ghost;
    public GameObject human;
    public Rigidbody2D char_rb;
    float ForceGravity = 100;
    bool jump = false;




    // Start is called before the first frame update
    void Start()
    {
        charaA = true;
        charachange = this;
        human.gameObject.SetActive(true);
        ghost.gameObject.SetActive(false);
        //gameObject.AddComponent<Rigidbody2D>();
        //char_rb = gameObject.GetComponent<Rigidbody2D>();
        jump = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            charaA = !charaA;
            charaB = !charaB;
            if (charaA == true)
            {
                jump = true;
                human.gameObject.SetActive(true);
                ghost.gameObject.SetActive(false);
                gameObject.AddComponent<Rigidbody2D>();
                char_rb = gameObject.GetComponent<Rigidbody2D>();
                //char_rb.AddForce(Vector3.down * ForceGravity);
                char_rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            }

            else if (charaB == true)
            {
                jump = false;
                ghost.gameObject.SetActive(true);
                human.gameObject.SetActive(false);
                Destroy(GetComponent<Rigidbody2D>());
            }
        }
    }

   void OnCollisionStay2D(Collision2D col)
    {
        if (jump && col.gameObject.tag == "Ground")
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                char_rb.AddForce(Vector2.up * 500, ForceMode2D.Impulse);
                Invoke("JumpStop", 1);
            }
            
        }
    }
    void JumpStop()
    {
        char_rb.AddForce(Vector2.down * 500, ForceMode2D.Impulse);
        char_rb.velocity = Vector3.zero;
    }
}
