using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityVariables : MonoBehaviour
{
    public GameObject gameObject;
    public Transform transform;

    public Vector3 vector3;
    // Start is called before the first frame update
    void Start()
    {
       // vector3 = new Vector3(3,4,12);
        transform.position = vector3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
