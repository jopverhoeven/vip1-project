using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FerrisWheelMovement : MonoBehaviour
{

    public float rotateSpeed;
    private bool isMoving;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            this.transform.RotateAround(transform.position, Vector3.left, rotateSpeed * Time.deltaTime);
        }
    }

    public void ToggleMovement() {
        isMoving = !isMoving;
    }
}
