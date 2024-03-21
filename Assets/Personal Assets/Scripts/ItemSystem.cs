using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSystem : MonoBehaviour
{
    private bool GotItem;
  
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("ItemBox"))
        {
            Destroy(collision.gameObject);
            GotItem = true;

        }
    }
}
