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
   

   
    // Start is called before the first frame update
    void Start()
    {
        charaA = true;
        charachange = this;
        human.gameObject.SetActive(true);
        ghost.gameObject.SetActive(false);
        gameObject.AddComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            charaA = !charaA;
            charaB = !charaB;
        }

       if(charaA == true)
        {
            human.gameObject.SetActive(true);
            ghost.gameObject.SetActive(false);
            gameObject.AddComponent<Rigidbody2D>();
        }

       else if(charaB == true)
        {
            ghost.gameObject.SetActive(true);
            human.gameObject.SetActive(false);
            Destroy(GetComponent<Rigidbody2D>());
        }
    }
}
