using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnterDrivableObject : MonoBehaviour
{
    public Transform cameraParent;
    private Transform attatch;
    private Transform previousTransform;
    private bool currentlyDriving;


    // Start is called before the first frame update
    void Start()
    {
        currentlyDriving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!currentlyDriving)
        {
            previousTransform = this.transform;
        }
        else {
            this.transform.parent = attatch;
            this.transform.position = attatch.position;
            this.transform.rotation = attatch.rotation;
        }
    }

    public void EnterDriving(Transform attatch) {
        this.attatch = attatch;
        currentlyDriving = true;
    }

    public void LeaveDriving() {
        this.transform.parent = cameraParent;
        this.transform.position = previousTransform.position;
        this.transform.rotation = previousTransform.rotation;

        currentlyDriving = false;
    }
}
