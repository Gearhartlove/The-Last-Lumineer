using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundryCollision : MonoBehaviour
{
    PlayerActions pa;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        pa = collision.gameObject.GetComponent<PlayerActions>();
        if (!pa.isDead)
        {

        }
    }
}
