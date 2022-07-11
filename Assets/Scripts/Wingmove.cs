using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wingmove : MonoBehaviour
{
    public GameObject Wing;
    public GameObject TailWing;
    private HelicopterInput _input;
    private Transform TP;
    private Rigidbody RG;
    private bool IsWing = false;
    private bool IsReady = false;
    public float HelicopterSpeed = 1f;
    public float WingSpeed = 1f;
    public float WingSpeedMax = 10f;
    // Start is called before the first frame update
    void Start()
    {
        _input = GetComponent<HelicopterInput>();
        TP = GetComponent<Transform>();
        RG = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_input.isEngin)
        {
            IsWing = !IsWing;
        }

        if (IsWing)
        {
            WingSpeed += 1f;
            Wing.transform.Rotate(new Vector3(0f, WingSpeed * Time.deltaTime, 0f));
            TailWing.transform.Rotate(new Vector3(WingSpeed * Time.deltaTime, 0f, 0f));
            if (WingSpeed > WingSpeedMax)
            {
                WingSpeed = WingSpeedMax;
                IsReady = true;
            }
            RG.useGravity = false;
        } 
        else
        {
            Physics.gravity = new Vector3(0f, -1500f, 0f);
            RG.useGravity = true;
            if (WingSpeed > 0)
            {
                WingSpeed -= 1f;
            }
            Wing.transform.Rotate(new Vector3(0f, WingSpeed * Time.deltaTime, 0f));
            TailWing.transform.Rotate(new Vector3(WingSpeed * Time.deltaTime, 0f, 0f));
            if (HelicopterSpeed > 0)
            {
                HelicopterSpeed -= 0.05f;
            }
        }

        if (IsReady)
        {
            if (_input.isUp)
            {
                HelicopterSpeed += 0.05f;
                RG.AddForce(0f, HelicopterSpeed, 0f);
            }
            else if (_input.isDown)
            {
                HelicopterSpeed += 0.05f;
                RG.AddForce(0f, -HelicopterSpeed, 0f);
            }
            else if (HelicopterSpeed > 0)
            {
                HelicopterSpeed -= 0.05f;
            }
        }

     

        
    }
}
