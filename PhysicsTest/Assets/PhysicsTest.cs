using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{

    [SerializeField]
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 vector3 = new Vector3(0, 100f, 0);

        //rigidbody.AddForce(transform.up * 1000);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rigidbody.AddForce(transform.up * 7500);
        } 
    }
}
