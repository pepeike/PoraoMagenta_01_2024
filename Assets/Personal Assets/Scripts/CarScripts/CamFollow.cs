using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    [SerializeField]
    private GameObject player;
    private Rigidbody rb;
    [SerializeField]
    private float speed;

    [SerializeField]
    private Vector3 camOffset;


    private void Start()
    {
        rb = player.GetComponent<Rigidbody>();
        
    }

    private void LateUpdate()
    {
        Vector3 playerForward = (rb.velocity + player.transform.forward).normalized;
        transform.position = Vector3.Lerp(transform.position,
            player.transform.position + player.transform.TransformVector(camOffset) + playerForward * (-5f),
            speed * Time.deltaTime);
        transform.LookAt(player.transform);
    }

}
