﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour
{
    public Color OriginalColor = new Color(1, 1, 1);
    public Color HighlightColor = new Color(1, 0.3f, 0.3f);
    private bool _selected = false;
    public Action<Zone> OnSelect;

    private ZonesController _zonesController;

    // Use this for initialization
    void Start()
    {
        _zonesController = FindObjectOfType(typeof(ZonesController)) as ZonesController;

        GetComponent<Renderer>().material.color = new Color(1, 1, 1);
//		Debug.Log("Zone Start()");
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseEnter()
    {
        Debug.Log("OnMouseEnter");
        GetComponent<Renderer>().material.color = HighlightColor;
        // Here some logic to highlight okay?
    }

    private void OnMouseExit()
    {
        if (!_selected)
            GetComponent<Renderer>().material.color = new Color(1, 1, 1);

        Debug.Log("OnMouseExit");
    }

    public Color OriginalColor1
    {
        get { return OriginalColor; }
        set { OriginalColor = value; }
    }

    public Color HighlightColor1
    {
        get { return HighlightColor; }
        set { HighlightColor = value; }
    }

    public bool Selected
    {
        get { return _selected; }
        set { _selected = value; }
    }

    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        if (!_selected)
        {
            if (_zonesController.SelectedCount < 10)
            {
                _zonesController.SelectedCount++;
                _selected = !_selected;
            } 
        }
        else
        {
            _zonesController.SelectedCount--;
            _selected = !_selected;
        }
        Debug.Log("Selected Count: " + _zonesController.SelectedCount);
    }
}