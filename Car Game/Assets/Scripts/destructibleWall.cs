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
            for (int x = 0; x < destroyedWall.transform.childCount; x++)
            {
                GameObject t = destroyedWall.transform.GetChild(x).gameObject;
                float randomNumber = Random.Range(0, 2);
                moveForce += transform.right * 15 * randomNumber * Time.deltaTime * 0.00000000001f;
                t.transform.position -= moveForce;
            }
            Destroy(gameObject);
        }
    }
}
