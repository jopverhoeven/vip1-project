using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToMovingObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit raycastHit;
        Ray ray = new Ray(transform.position, Vector3.down);
        if (Physics.Raycast(ray, out raycastHit, 3f))
        {
            if (raycastHit.transform.gameObject.tag == "MovingAlong")
            {
                transform.parent = raycastHit.transform;
            } else {
                transform.parent = null;
                transform.rotation = Quaternion.identity;
            }
        }
    }
}
