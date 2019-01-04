using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public Animator doorAnimator;
    public GameObject message;
    Animator buttonAnimator;
    void Start ()
    {
        buttonAnimator = GetComponent<Animator> ();
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag.Equals ("Player"))
        {
            buttonAnimator.SetBool ("press", true);
            doorAnimator.SetBool ("open", true);
        }
        if (transform.name.Equals ("Button 3"))
        {
            message.SetActive (true);
        }
    }
}