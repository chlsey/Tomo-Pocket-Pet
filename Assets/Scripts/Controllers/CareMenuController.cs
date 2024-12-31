using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject menu;

    public void ShowMenu()
    {
        if (menu != null)
        {
            menu.SetActive(true);
        }
    }

    public void HideMenu()
    {
        if (menu != null)
        {
            menu.SetActive(false);
        }
    }
}
