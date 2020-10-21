using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class MenuToggle : MonoBehaviour
{

    public GameObject menuObject;

    // Start is called before the first frame update
    void Start()
    {
        menuObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Actions.default_ToggleMenu.lastStateDown) {
            menuObject.SetActive(!menuObject.activeSelf);
        }
       
    }
}
