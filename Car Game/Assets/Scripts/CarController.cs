using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CarController : MonoBehaviour
{
    private Vector3 MoveForce;
    public float forwardAcceleration = 4f;
    public float reverseAcceleration = 4f;
    public float turnAngle = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Calculating the forward/back Vector
        MoveForce += transform.forward * forwardAcceleration * Input.GetAxis("Vertical") * Time.deltaTime;
        // Apply calculation onto our player
        transform.position += MoveForce * Time.deltaTime;

        // Calculating positive/negative turn Vector
        float turning = Input.GetAxis("Horizontal");
        // Apply calcaulation onto our player
        transform.Rotate(Vector3.up * turning * MoveForce.magnitude * turnAngle * Time.deltaTime);
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
