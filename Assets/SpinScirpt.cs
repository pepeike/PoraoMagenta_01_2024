using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScirpt : MonoBehaviour
{

    float maxrotation = 25f;
    float speed = 3f;
    public CarSelector carsel;
    public int iconattachedto;
    private void Update()
    {
        if (carsel.selectedCar == iconattachedto)
        {
            transform.rotation = Quaternion.Euler(0, 0, maxrotation * Mathf.Sin(Time.time * speed));
        }
        else
        {
            transform.rotation = Quaternion.identity;
        }
        
    }
}
