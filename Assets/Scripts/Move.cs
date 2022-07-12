using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private HelicopterInput _input;
    private Rigidbody Helicopterrigibody;
    public GameObject Helicopter;
    public float Speed = 1f;
    public float turnSpeed = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        _input = GetComponent<HelicopterInput>();
        Helicopterrigibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = _input.X * Speed;
        float zSpeed = _input.Z * Speed;
        Helicopterrigibody.velocity = new Vector3(-xSpeed, 0f, -zSpeed);
        
        
        if(_input.leftTurn)
        {
            Helicopter.transform.Rotate(new Vector3(0f, -(turnSpeed * Time.deltaTime), 0f));
        }

        if (_input.rightTurn)
        {
            Helicopter.transform.Rotate(new Vector3(0f, turnSpeed * Time.deltaTime, 0f));
        }
    }
}
