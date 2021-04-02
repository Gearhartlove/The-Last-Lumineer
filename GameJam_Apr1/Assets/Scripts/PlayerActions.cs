using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    PlayerVariables pv;

    private void Start()
    {
        pv = gameObject.GetComponent<PlayerVariables>();
    }

    private void OnW_Press()
    {
        
    }

    private void OnA_Press()
    {
        pv.GetRigidBody().gravityScale++;
    }

    private void OnD_Press()
    {
        pv.GetRigidBody().gravityScale--;
    }

    private void OnSpace_Press()
    {
        Debug.Log("Space");
    }
}
