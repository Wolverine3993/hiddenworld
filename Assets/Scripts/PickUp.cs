using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] GameObject targetColourOverlay;
    public GameObject canvasObject;
    enum Colours { red, white }
    [SerializeField] Colours targetColour;
    void Start()
    {
        canvasObject = GameObject.Find("Canvas");
    }
    void Update()
    {
        
    }
    public void ChangeColour()
    {
        for (int i = 0; i < canvasObject.transform.childCount; i++)
        {
            if (canvasObject.transform.GetChild(i).gameObject.tag == "Overlay" && canvasObject.transform.GetChild(i).gameObject.activeSelf == true)
            {
                canvasObject.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        if (targetColour != Colours.white)
            targetColourOverlay.SetActive(true);
    }
}
