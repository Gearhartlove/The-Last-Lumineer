using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudCollision : MonoBehaviour
{
    Animator anim;
    private void Awake()
    {
        
        anim = gameObject.GetComponent<Animator>();    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Player")
        {
            anim.Play("fade");
        }
    }
}
