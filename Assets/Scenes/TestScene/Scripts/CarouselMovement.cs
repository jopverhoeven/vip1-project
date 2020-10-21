using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarouselMovement : MonoBehaviour
{
    public float rotateSpeed;
    private bool isMoving;


    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            this.transform.RotateAround(transform.position, Vector3.up, rotateSpeed * Time.deltaTime);
        }
    }

    public void ToggleMovement()
    {
        isMoving = !isMoving;
    }
}
