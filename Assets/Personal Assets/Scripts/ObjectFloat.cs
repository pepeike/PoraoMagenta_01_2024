using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFloat : MonoBehaviour
{

    private Vector3 initposition;
    public float amp;
    public float freq;

    private void Start()
    {
        amp = 0.3f;
        freq = 4;
        initposition = transform.position;
    }

    void Update()
    {
        transform.position = new Vector3(initposition.x, Mathf.Sin(Time.time * freq)* amp + initposition.y, initposition.z);
    }
}
