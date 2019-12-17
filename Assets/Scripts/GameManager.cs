
using System;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class GameManager : MonoBehaviour
{
    public GameObject[] recepies; 
    public void OnClickButton() {

        foreach (GameObject reciept in recepies)
        {
            reciept.SetActive(true);
        }
    }

}