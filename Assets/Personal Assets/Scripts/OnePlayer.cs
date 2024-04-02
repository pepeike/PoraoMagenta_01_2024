using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class OnePlayer : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public Animator playerone;
    

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Debug.Log("PointerEntered");
        playerone.SetBool("IsSelected", true);
    }

    
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        playerone.SetBool("IsSelected", false);
    }

    public void OnPointerClick(PointerEventData pointeventdata)
    {
        CarSelector.playerstochoose = 1;
        SceneManager.LoadScene("CharSel");
    }
}
