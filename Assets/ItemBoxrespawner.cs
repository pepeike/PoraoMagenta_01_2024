using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxrespawner : MonoBehaviour
{
    public GameObject itembox1;
    public GameObject itembox2;
    public GameObject itembox3;
    [SerializeField]private float respawntimer = 10;

   

    private void Update()
    {
        if (respawntimer > 0)
        {
            respawntimer -= Time.deltaTime;
        }

        if (respawntimer < 1)
        {
            itembox1.SetActive(true);
            itembox2.SetActive(true);
            itembox3.SetActive(true);
            respawntimer = 10;
        }
    }


}
