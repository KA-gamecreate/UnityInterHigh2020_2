using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class umbrella : MonoBehaviour
{
    public GameObject player;
    private float hp = 50;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      

        transform.position = new Vector3(player.transform.position.x, -0.2f, 0);
        
    }
}

