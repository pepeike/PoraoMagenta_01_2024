using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject numbselimage;
    

    public void ClickedStart()
    {
        numbselimage.SetActive(true);
    }
}
