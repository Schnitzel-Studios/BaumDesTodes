using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HingeJoint2D))]
public class Branch : MonoBehaviour
{
    public float desiredAngle = -1;
    public float springForce = 1;
    public float damping = 1;
    public float breakForce = 90;
    public Rigidbody2D connectedBody;

    Vector2 startRot;


    SpringJoint2D joint;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        joint = GetComponent<SpringJoint2D>();
        joint.breakForce = breakForce;
        joint.connectedBody = connectedBody;
        joint.dampingRatio = damping;
        
    }
}
