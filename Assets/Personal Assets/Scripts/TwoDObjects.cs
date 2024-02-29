using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDobjects : MonoBehaviour
{
    public Transform cam;

    private void Update()
    {
        transform.LookAt(cam);
    }
}
