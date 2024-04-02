using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TwoPlayer : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler,IPointerClickHandler 
{
    public Animator playerone;
    public Animator playertwo;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Debug.Log("PointerEntered");
        playerone.SetBool("IsSelected", true);
        playertwo.SetBool("IsSelected", true);
    }


    public void OnPointerExit(PointerEventData pointerEventData)
    {
        playerone.SetBool("IsSelected", false);
        playertwo.SetBool("IsSelected", false);
    }

    public void OnPointerClick(PointerEventData pointeventdata)
    {
        CarSelector.playerstochoose = 2;
    }
}
    

