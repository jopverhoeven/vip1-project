using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingThrowing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter(Collider other) {
        if (other.tag == "RingThrowing") {
            Material material = other.gameObject.GetComponent<MeshRenderer>().material;
            material.color = Color.green;
        }
    }

    public void OnTriggerExit(Collider other) {
        if (other.tag == "RingThrowing") {
            Material material = other.gameObject.GetComponent<MeshRenderer>().material;
            material.color = Color.white;
        }
    }

}
