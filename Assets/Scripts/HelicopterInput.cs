using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterInput : MonoBehaviour
{
    public float X { get; private set; }
    public float Z { get; private set; }

    public bool leftTurn;
    public bool rightTurn; 
    public bool isEngin;
    public bool isUp;
    public bool isDown;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        X = Z = 0;

        X = Input.GetAxis("Horizontal");
        Z = Input.GetAxis("Vertical");

        leftTurn = Input.GetKey(KeyCode.Q);
        rightTurn = Input.GetKey(KeyCode.E);

        isEngin = Input.GetKeyDown(KeyCode.R);
        isUp = Input.GetKey(KeyCode.Space);
        isDown = Input.GetKey(KeyCode.C);
       
    }
}
