using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSystem : MonoBehaviour
{
    public bool GotItem = false;
    public GameObject[] items;
    public int currentitem;
    public Transform ItemExit;
    public AudioSource itemget;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("ItemBox"))
        {
            Destroy(collision.gameObject);
            currentitem = Random.Range(0, items.Length);
            GotItem = true;
            itemget.Play();

        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && GotItem == true)
        {
            UseItem();
        }
    }

    private void UseItem()
    {
        GotItem = false;
        GameObject useditem = Instantiate(
            items[currentitem],
            ItemExit.transform.position, 
            Quaternion.identity);

    }
}
