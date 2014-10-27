using UnityEngine;
using System.Collections;

public class FlyController : MonoBehaviour 
{
	public Animator animControl;
	public Rigidbody2D rigid;
	public bool flyTrigger = false;

	// Use this for initialization
	void Start () 
	{
		animControl = GetComponent <Animator>();
		rigid = GetComponent <Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log(Input.GetButtonDown("Jump"));
		if (Input.GetButtonDown("Jump"))
		{
			animControl.SetTrigger("FlyTrigger");
			rigid.AddForce(new Vector2(0,500));
		}
	}
}
