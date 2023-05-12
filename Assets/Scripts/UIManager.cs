using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject howToPlayPanel;
    [SerializeField] private Text tapToPlay;
    private bool isStart = false;

    private void Start()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tapToPlay.gameObject.SetActive(false);
            isStart = true;
        }
    }

    void OpenPanel()
    {
        howToPlayPanel.SetActive(true);
    }


}//class
