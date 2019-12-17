using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour
{
    public string input;

    public void openUrl(){
        Application.OpenURL(input);
    }
}
