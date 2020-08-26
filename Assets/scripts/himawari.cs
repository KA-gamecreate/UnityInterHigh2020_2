using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class himawari : MonoBehaviour
{
	private int score;
	public GameObject goalkey;
	public GameObject hima1;
	public GameObject hima2;
	public GameObject hima3;
	public GameObject hima4;
	public GameObject hima5;
	public GameObject hima6;
	public GameObject hima7;
	public GameObject waterimage;
	Animator animator;
	// Start is called before the first frame update
	void Start()
	{
		animator = GetComponent<Animator>();
		goalkey.SetActive(false);
		hima1.SetActive(false);
		hima2.SetActive(false);
		hima3.SetActive(false);
		hima4.SetActive(false);
		hima5.SetActive(false);
		hima6.SetActive(false);
		hima7.SetActive(false);
		waterimage.SetActive(false);
		SetCountText();
	}

	// Update is called once per frame
	void Update()
	{

	}
	private void OnTriggerStay2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "water")
		{
			waterimage.SetActive(true);
		}
		if (waterimage.gameObject.activeSelf == true)
		{
			if (collision.gameObject.tag == "himawari")
			{
				if (Input.GetKeyDown(KeyCode.A))
				{
					score = score + 1;
					Debug.Log("+1");
					collision.gameObject.SetActive(false);
					animator.SetInteger("attack", 1);
					Invoke("AnimeReset", 1);
					SetCountText();
					waterimage.SetActive(false);
				}
			}
		}

	}
	void SetCountText()
	{
		if (score >= 1)
		{
			hima1.SetActive(true);
		}
		if (score >= 2)
		{
			hima2.SetActive(true);
		}
		if (score >= 3)
		{
			hima3.SetActive(true);
		}
		if (score >= 4)
		{
			hima4.SetActive(true);
		}
		if (score >= 5)
		{
			hima5.SetActive(true);
		}
		if (score >= 6)
		{
			hima6.SetActive(true);
		}
		if (score >= 7)
		{
			hima7.SetActive(true);
			goalkey.SetActive(true);
		}
	}
		void AnimeReset()
		{
			animator.SetInteger("attack", 0);
	
		}
	}
