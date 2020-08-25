using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poison : MonoBehaviour
{
    public GameObject kira_image;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

  
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (kira_image.gameObject.activeSelf == true)
            {
                StartCoroutine("dead");
                Destroy(this.gameObject);
                Debug.Log("Destroy");
            }        
            
          else if (kira_image.gameObject.activeSelf == false)
            {
                collision.gameObject.SendMessage("Gameover");
                Debug.Log("gameover");
            }

        }
    }
    IEnumerator dead()
    {
        
        kira_image.gameObject.SetActive(false);
        yield return null;
    }


}
