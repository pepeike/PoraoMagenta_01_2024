using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartButton : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler
{
    public GameObject numbselimage;
    public Animator anim;

    public void ClickedStart()
    {
        
        numbselimage.SetActive(true);
    }

    public void OnPointerEnter(PointerEventData pointer)
    {
        anim.SetTrigger("GoFoward");
    }

    public void OnPointerExit(PointerEventData pointer)
    {
        anim.SetTrigger("GoBack");
    }
}
