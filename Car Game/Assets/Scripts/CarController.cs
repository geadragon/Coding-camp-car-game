using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CarController : MonoBehaviour
{
    public float speed;
    public float turnspeed;
    private Rigidbody rb;
    public float moveConstant;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = 1f;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.forward * speed * moveConstant);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(Vector3.back * speed * moveConstant);
        }
        Vector3 localVelocity = transform.InverseTransformDirection(rb.velocity);
        localVelocity.x = 0;
        if (localVelocity.z >= 45)
        {
            localVelocity.z = 45;
        }
        rb.velocity = transform.TransformDirection(localVelocity);
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(Vector3.up * turnspeed * moveConstant);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(Vector3.down * turnspeed * moveConstant);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //if the other is changelevel box loads level 2
        Debug.Log("hi");
        if (other.gameObject.CompareTag("changeLevel"))
        {
            SceneManager.LoadScene("SampleScene 1");
        }
    }
}
