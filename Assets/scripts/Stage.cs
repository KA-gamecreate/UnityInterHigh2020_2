using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage : MonoBehaviour
{
    public int stage_num;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;
    public GameObject ten;
    public GameObject eleven;
    public GameObject twelve;
    // Start is called before the first frame update
    void Start()
    {
        stage_num = PlayerPrefs.GetInt("SCORE", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PlayerPrefs.DeleteKey("SCORE");
        }
        
        if(stage_num >= 1)
        {
            two.SetActive(true);
        }
        if(stage_num >= 2)
        {
           three.SetActive(true);
            Debug.Log("2");
        }
        if (stage_num >= 3)
        {
            four.SetActive(true);
            Debug.Log("3");
        }
        if (stage_num >= 4)
        {
            five.SetActive(true);
        }
        if (stage_num >= 5)
        {
            six.SetActive(true);
        }
        if (stage_num >= 6)
        {
            seven.SetActive(true);
        }
        if (stage_num >= 7)
        {
            eight.SetActive(true);
        }
        if (stage_num >= 8)
        {
            nine.SetActive(true);
        }
        if (stage_num >= 9)
        {
            ten.SetActive(true);
        }
        if (stage_num >= 10)
        {
            eleven.SetActive(true);
        }
        if (stage_num >= 11)
        {
            twelve.SetActive(true);
        }
      
    }
}
