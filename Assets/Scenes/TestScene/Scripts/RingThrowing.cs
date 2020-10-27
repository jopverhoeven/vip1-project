using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingThrowing : MonoBehaviour
{
    private ParticleSystem particleSystem;

    // Start is called before the first frame update
    void Start()
    {
        particleSystem = this.GetComponentInChildren<ParticleSystem>();
        particleSystem.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter(Collider other) {
        if (other.tag == "RingThrowing") {
            Material material = other.gameObject.GetComponent<MeshRenderer>().material;
            material.color = Color.green;

            particleSystem.transform.position = other.transform.position;
            particleSystem.transform.rotation = other.transform.rotation;
            particleSystem.transform.Rotate(new Vector3(-90, 0, 0));
            particleSystem.Play();
        }
    }

    public void OnTriggerExit(Collider other) {
        if (other.tag == "RingThrowing") {
            Material material = other.gameObject.GetComponent<MeshRenderer>().material;
            material.color = Color.white;

            particleSystem.Stop();
        }
    }

}
