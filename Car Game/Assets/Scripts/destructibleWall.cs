using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destructibleWall : MonoBehaviour
{
    public GameObject destroyedWall;
    private Vector3 moveForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            Instantiate(destroyedWall, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
