using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    

    float speed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     

            if (Input.GetKey("right"))
            {
                transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            }



            if (Input.GetKey("left"))
            {
                transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
            }
        

    }
}

