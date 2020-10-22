using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class MenuToggle : MonoBehaviour
{

    public GameObject parent;
    public GameObject mainMenuObject;
    public GameObject[] subMenuObjects;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var subMenuObject in subMenuObjects)
        {
            subMenuObject.SetActive(false);
        }
        mainMenuObject.SetActive(true);
        parent.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Actions.default_ToggleMenu.lastStateDown) {
            parent.SetActive(!parent.activeSelf);
        }
    }

    public void GoToSubMenu(int subMenuIndex) 
    {
        mainMenuObject.SetActive(false);
        subMenuObjects[subMenuIndex].SetActive(true);
    }

    public void GoToSubMenu(GameObject subMenu)
    {
        mainMenuObject.SetActive(false);
        foreach (var subMenuObject in subMenuObjects)
        {
            if (subMenuObject == subMenu) {
                subMenuObject.SetActive(true);
            }
        }
    }

    public void GoBackToMainMenu()
    {
        mainMenuObject.SetActive(true);
        foreach (var subMenuObject in subMenuObjects)
        {
            subMenuObject.SetActive(false);
        }
    }
}
