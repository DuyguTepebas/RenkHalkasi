using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalkaControl : MonoBehaviour
{
    public float donmeHizi;
    public bool solaDon = true;

    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (solaDon)
        {
            transform.Rotate(0f, 0f, donmeHizi * Time.deltaTime);
        }
        else
        {
            transform.Rotate(0f, 0f, -donmeHizi * Time.deltaTime);
        }
    }

}//class
