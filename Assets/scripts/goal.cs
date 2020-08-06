using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour
{
    public GameObject owari;
    public GameObject stage;
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
            PlayerPrefs.SetInt("SCORE", 3);
            Debug.Log("point");
            PlayerPrefs.Save();

        }
    }
}
