using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Net.Mime;
using System.Collections.Generic;
using UnityEditor.VersionControl;

public class TooltipManager : MonoBehaviour
{
    public static TooltipManager _intance;

    public TextMeshProUGUI content;
    private void Awake()
    {
        if (_intance != null && _intance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _intance = this;
        }    
    }

    private void Start()
    {
        Cursor.visible = true;
        gameObject.SetActive(false);
    }

    private void Update()
    {
        transform.position = Input.mousePosition;
    }

    public void SetandShowToolTips(string message)
    {
        gameObject.SetActive(true);
        content.text = message;
    }

    public void HideToolTip()
    {
        gameObject.SetActive(false );
        content.text = string.Empty;
    }    
}    

