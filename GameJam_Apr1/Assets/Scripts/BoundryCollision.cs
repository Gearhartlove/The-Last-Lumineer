using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundryCollision : MonoBehaviour
{
    PlayerActions pa;
    [SerializeField] GameObject BlackBackground;
    [SerializeField] GameObject FloatIntoSpaceUI;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        pa = collision.gameObject.GetComponent<PlayerActions>();
        if (!pa.isDead)
        {
            pa = collision.gameObject.GetComponent<PlayerActions>();
            pa.isDead = true;
            BlackBackground.SetActive(true);
            FloatIntoSpaceUI.SetActive(true);
        }
    }
}
