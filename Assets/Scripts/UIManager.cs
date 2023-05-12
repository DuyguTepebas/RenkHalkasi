using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject howToPlayPanel;
    [SerializeField] private TopControl player;

    public void OpenPanel()
    {
        if (!howToPlayPanel.activeSelf)
        {
            howToPlayPanel.SetActive(true);
            player.rb.gravityScale = 0f;
            player.ziplamaKuvveti = 0f;

        }
        else
        {
            howToPlayPanel.SetActive(false);
            Invoke("SetGravity",2f);
        }
        
    }

    void SetGravity()
    {
        player.rb.gravityScale = 0.7f;
        player.ziplamaKuvveti = 3f;
    }
    
    
    
}//class
