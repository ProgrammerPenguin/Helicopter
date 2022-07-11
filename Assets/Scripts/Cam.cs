using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public Transform Camara;

    private Vector3 _distance;
    // Start is called before the first frame update
    void Start()
    {
        _distance = Camara.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Camara.position - _distance;
    }
}
