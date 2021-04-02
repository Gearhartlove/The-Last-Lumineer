using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    PlayerVariables pv;
    Rigidbody2D prb2d;
    private float RotationSpeed = 1f;
    private float timeCount = 0.0f;

    private bool leftThruster = false;
    private bool rightThruster = false;
    private bool forwardThruster = false;

    [Range (0,100)] float bothRotationSpeed = 0.0f;
    [SerializeField] [Range (0,-100)] float rightRotationSpeed = -60.0f; //less power
    [SerializeField] [Range (0,100)] float leftRotationSpeed = 60.0f;   //more power

    [Range(0, 100)] float bothDragSpeed = 0.0f;
    [SerializeField] [Range(0, -100)] float rightDragSpeed = 0.0f; //less power
    [SerializeField] [Range(0, 100)] float leftDragSpeed = 0.0f;   //more power

    [SerializeField] [Range(0, 3)] float MaxSpeed = 0f;
    [SerializeField] float forceApplied = 0;

    public Sprite[] spriteArray;
    SpriteRenderer sr;


    private void Start()
    {
        pv = gameObject.GetComponent<PlayerVariables>();
        prb2d = pv.GetRigidBody();

        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        //PICTURE 
        //nothing
        if (!leftThruster && !forwardThruster && !rightThruster)
            sr.sprite = spriteArray[0];
        //left only
        else if ((leftThruster && !forwardThruster && !rightThruster))
            sr.sprite = spriteArray[1];
        //middle only
        else if (!leftThruster && forwardThruster && !rightThruster)
            sr.sprite = spriteArray[2];
        //right only
        else if (!leftThruster && !forwardThruster && rightThruster)
            sr.sprite = spriteArray[3];
        //left middle only
        else if (leftThruster && forwardThruster && !rightThruster)
            sr.sprite = spriteArray[4];
        //middle right only
        else if (!leftThruster && forwardThruster && rightThruster)
            sr.sprite = spriteArray[5];
        //left right
        else if (leftThruster && !forwardThruster && rightThruster)
            sr.sprite = spriteArray[6];
        //all
        else if (leftThruster && forwardThruster && rightThruster)
            sr.sprite = spriteArray[7];
    }

    private void FixedUpdate()
    {
        //Movement / Rotation Logic 
        if (leftThruster && rightThruster)
        {
            //change rotation

            prb2d.MoveRotation(prb2d.rotation +
                bothRotationSpeed * Time.fixedDeltaTime);
            prb2d.angularVelocity = bothDragSpeed;
        }
        else if (leftThruster)
        {
            //change rotation

            prb2d.MoveRotation(prb2d.rotation +
                leftRotationSpeed * Time.fixedDeltaTime);
            prb2d.angularVelocity = leftDragSpeed;

        }
        else if (rightThruster)
        {
            //change rotation
            prb2d.MoveRotation(prb2d.rotation +
                rightRotationSpeed * Time.fixedDeltaTime);
            prb2d.angularVelocity = rightDragSpeed;
        }
        if (forwardThruster)
        {
            //add force
            prb2d.AddForce(transform.up * forceApplied);
            //Debug.Log("Normalized: " + prb2d.velocity.normalized);
            //float clampedVelocity = Mathf.Clamp(prb2d.velocity, 1f, 5f);
            if (prb2d.velocity.magnitude > MaxSpeed)
            {
                float pushBack = prb2d.velocity.magnitude - MaxSpeed;
                prb2d.AddForce(-transform.up * forceApplied * pushBack);
            }
        }
    }

    //go forward
    private void OnW_Press()
    {
        if (!forwardThruster)
        {
            forwardThruster = true;
        }
        else if (forwardThruster) forwardThruster = false;
    }

    //left thruster start , left thruster end
    private void OnA_Press()
    {
        if (!leftThruster)
        {
            leftThruster = true;

        }
        else if (leftThruster) leftThruster = false;
    }

    //right thruster start, right thruster stop
    private void OnD_Press()
    {
        if (!rightThruster)
        {
            rightThruster = true;

        }
        else if (rightThruster) rightThruster = false;
    }

    //??
    private void OnSpace_Press()
    {

    }
}
