using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FerrisWheelMovement : MonoBehaviour
{

    public float rotateSpeed;
    private bool isMoving;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
        if (isMoving) {
            audioSource.Stop();
        } else {
            audioSource.Play();
        }
        isMoving = !isMoving;
    }
}
