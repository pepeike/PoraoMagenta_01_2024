using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharNumSelBack : MonoBehaviour
{
    public GameObject numsel;
    public void GoBack()
    {
        numsel.SetActive(false);
    }
}
