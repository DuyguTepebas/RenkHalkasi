using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InputController : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private TopControl player;
    [SerializeField] private GraphicRaycaster graphicRaycaster;
    public void OnPointerClick(PointerEventData eventData)
    {
        graphicRaycaster.enabled=false;
        gameObject.SetActive(false);
        player.rb.gravityScale = 0.7f;
        player.ziplamaKuvveti = 3f;
    }
    
    
    
}//class
