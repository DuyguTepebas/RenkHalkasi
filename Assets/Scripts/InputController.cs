using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputController : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Rigidbody2D player;

    public void OnPointerClick(PointerEventData eventData)
    {
        gameObject.SetActive(false);
        player.gravityScale = 0.7f;
    }
    
    
    
}//class
