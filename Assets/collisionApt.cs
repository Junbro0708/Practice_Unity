using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionApt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "ground")
        {
            Debug.Log("Hit the floor!");
        } else if(collision.gameObject.name != "ground")
        {
            Debug.Log("Hit another object!");
            Destroy(collision.gameObject);
        }
    }
}
