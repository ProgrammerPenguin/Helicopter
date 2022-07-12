using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterInput : MonoBehaviour
{
    public float X { get; private set; }
    public float Z { get; private set; }

    public bool leftTurn;
    public bool rightTurn; 
    public bool IsEngin;
    public bool IsUp;
    public bool IsDown;
    public bool IsBullet;
    public bool IsMissile;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        X = Z = 0;

        X = Input.GetAxis("Horizontal");
        Z = Input.GetAxis("Vertical");

        leftTurn = Input.GetKey(KeyCode.Q);
        rightTurn = Input.GetKey(KeyCode.E);

        IsEngin = Input.GetKeyDown(KeyCode.R);
        IsUp = Input.GetKey(KeyCode.Space);
        IsDown = Input.GetKey(KeyCode.C);
        IsBullet = Input.GetKey(KeyCode.A);
        IsMissile = Input.GetKey(KeyCode.S);
       
    }
}
