using System;
using UnityEngine;

public class PlayerVariables : MonoBehaviour
{
    //Fields
    private GameObject p_go;
    private Rigidbody2D p_rb2d;
    private Collider2D p_c2d;


    private void Awake()
    {
        p_go = gameObject;
        p_rb2d = gameObject.GetComponent<Rigidbody2D>();
        p_c2d = gameObject.GetComponent<Collider2D>();
    }

    public GameObject GetGameObject()
    {
        return p_go;
    }

    public Rigidbody2D GetRigidBody()
    {
        return p_rb2d;
    }

    public Collider2D GetCollider()
    {
        return p_c2d;
    }

}
