using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateMove : MonoBehaviour
{
    private float castleGateHeight;

    // Start is called before the first frame update
    void Start()
    {
        castleGateHeight = transform.position.y + 4.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || transform.position.y < castleGateHeight)
        {
            Vector3 newPos = new Vector3(transform.position.x, castleGateHeight, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * 0.5f);
        }
    }
}
