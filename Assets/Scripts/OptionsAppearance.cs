
using System;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class OptionsAppearance : DefaultTrackableEventHandler
{
    public GameObject options;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        options.SetActive(true);

        
    }
}