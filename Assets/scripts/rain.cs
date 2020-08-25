using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rain : MonoBehaviour
{
    
    private void Start()
    {
       
    }

    private void Update()
    {
    }

    void OnParticleCollision(GameObject obj)
    {
        if (obj.tag == "Player")
        {
            Debug.Log("敵と衝突しました");
            obj.gameObject.SendMessage("Gameover");

        }
        if(obj.tag == "kasa")
        {
           
        }
    }

}
