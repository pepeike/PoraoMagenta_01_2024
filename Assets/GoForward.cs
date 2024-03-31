using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GoForward : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Vector3 endpos;
    public Vector3 startpos;
    private float desireduration = 2f;
    private float elapsedtime;
    public bool mouseentered;
    
    

    public void Start()
    {
        startpos = transform.position;
    }

    private void Update()
    {
        
        if (mouseentered == true)
            elapsedtime += Time.deltaTime;
        float percentagecomplete = elapsedtime / desireduration;
        transform.position = Vector3.Lerp(startpos, endpos, percentagecomplete);
        
    }
    public void OnPointerEnter(PointerEventData pointeventdata)
    {
        mouseentered = true;
    }

    public void OnPointerExit(PointerEventData pointereventdata)
    {
        mouseentered = false;
        transform.position = startpos;
        elapsedtime = 0;
    }
}
