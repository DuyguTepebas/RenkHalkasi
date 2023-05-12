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

    public void OpenPanel()
    {
        if (!howToPlayPanel.activeSelf)
        {
            howToPlayPanel.SetActive(true);
        }
        else
        {
            howToPlayPanel.SetActive(false);   
        }
        
    }
    
}//class
