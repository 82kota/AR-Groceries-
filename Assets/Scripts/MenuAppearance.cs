using System;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class MenuAppearance : DefaultTrackableEventHandler
{
    public GameObject menu;
    public GameObject trigger;
    public GameObject mainMenu;
    protected override void OnTrackingFound()
    {
        if (mainMenu.activeSelf == false && trigger.activeSelf == false)
        {
            base.OnTrackingFound();
            trigger.SetActive(true);
            menu.SetActive(true);
        }
    }
}
