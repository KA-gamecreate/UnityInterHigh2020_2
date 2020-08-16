using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class music : MonoBehaviour
{
    private int score;
    public GameObject KEY;
    public GameObject Kagi;


    // Start is called before the first frame update
    void Start()
    {
        Kagi.SetActive(false);
        KEY.SetActive(false);
        score = 0;
        
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "music")
        {
            score = score + 1;
            Debug.Log("+1");
            collision.gameObject.SetActive(false);
            SetCountText();
        }

    }
    void SetCountText()
    {

        if (score >= 11)
        {
            Kagi.SetActive(true);
        }
        if (score >= 7)
        {
         KEY.SetActive(true);
        }
        
    }
}
