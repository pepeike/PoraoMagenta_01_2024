using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartButton : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler
{
    public GameObject numbselimage;
    public Animator anim;
    public GameObject triang;

    public void ClickedStart()
    {
        
        numbselimage.SetActive(true);
    }

    public void OnPointerEnter(PointerEventData pointer)
    {
        anim.SetBool("IsHighlighted", true);
        triang.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData pointer)
    {
        anim.SetBool("IsHighlighted", false);
        triang.gameObject.SetActive(false);
    }
}
