using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
   public GameObject player;

    void Start()
    {
 
    }

    void Update()
    {
        transform.position = Vector3(player.transform.position.x, 5, -10);
    }
}

