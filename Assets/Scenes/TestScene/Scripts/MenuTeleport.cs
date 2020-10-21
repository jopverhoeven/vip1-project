using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTeleport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TeleportToLocation(Vector3 location) {
        this.transform.position = location;
    }

    public void TeleportToLocation(Transform location)
    {
        this.transform.position = location.position;
        this.transform.rotation = location.rotation;
    }
}
