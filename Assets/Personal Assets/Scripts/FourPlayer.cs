using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class FourPlayer : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public Animator playerone;
    public Animator playertwo;
    public Animator playerthree;
    public Animator playerfour;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Debug.Log("PointerEntered");
        playerone.SetBool("IsSelected", true);
        playertwo.SetBool("IsSelected", true);
        playerthree.SetBool("IsSelected", true);
        playerfour.SetBool("IsSelected", true);
    }


    public void OnPointerExit(PointerEventData pointerEventData)
    {
        playerone.SetBool("IsSelected", false);
        playertwo.SetBool("IsSelected", false);
        playerthree.SetBool("IsSelected", false);
        playerfour.SetBool("IsSelected", false);
    }

    public void OnPointerClick(PointerEventData pointeventdata)
    {
        CarSelector.playerstochoose = 4;
        SceneManager.LoadScene("CharSel");
    }

}
