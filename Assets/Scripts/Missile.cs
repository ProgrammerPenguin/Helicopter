using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public GameObject HE;
    public Transform spawn;
    private HelicopterInput _input;
    private Rigidbody RG; 
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody instance = Instantiate(RG, spawn.position, spawn.rotation);
        //_input = GetComponent<HelicopterInput>();
       // RG = GetComponent<Rigidbody>();
       //Instantiate(HE, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if(_input.IsMissile)
        {
            RG.AddForce(5000f, 0f, 0f);
           
            Destroy(HE, 5f);
        }
    }
}
