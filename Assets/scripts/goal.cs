using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour
{
    
    public GameObject stage;
    public int Opennum;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionStay2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            col.gameObject.SendMessage("Gameclear");
            PlayerPrefs.SetInt("SCORE", Opennum);
            Debug.Log("point");
            PlayerPrefs.Save();

        }
    }
}
