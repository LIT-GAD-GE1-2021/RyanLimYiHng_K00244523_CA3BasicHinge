using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HingeJoint2D))]

public class TrapdoorScript : MonoBehaviour
{
    private HingeJoint2D hinge;
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update

    private void Awake()
    {
        hinge = GetComponent<HingeJoint2D>();
        rigidBody = GetComponent<Rigidbody2D>();
        hinge.useMotor = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
