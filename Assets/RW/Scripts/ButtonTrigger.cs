using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
	public GameObject door;
	public GameObject message;
	Animator buttonAnimator;
	Animator doorAnimator;
	Collider2D doorCollider;
	void Start ()
	{
		buttonAnimator = GetComponent<Animator> ();
		doorAnimator = door.GetComponent<Animator> ();
		doorCollider = door.GetComponent<Collider2D> ();
	}
	void OnTriggerEnter2D (Collider2D other)
	{

		if (transform.name.Equals ("Button 3"))
		{
			message.SetActive (true);
		}
		if (other.tag.Equals ("Player"))
		{
			buttonAnimator.SetBool ("press", true);
			doorAnimator.SetBool ("open", true);
			doorCollider.enabled = false;
		}
	}
}