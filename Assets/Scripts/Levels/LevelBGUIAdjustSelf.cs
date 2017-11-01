﻿using UnityEngine;
using System.Collections;
using System;

public class LevelBGUIAdjustSelf : MonoBehaviour, IUIAdjustSelf {
    public RectTransform Self { get; set; }

    public RectTransform Target { get;set ;}

    private Vector2 size;
    public RectTransform spawnpoint;
    public void GetTargetTransform()
    {
        size = new Vector2(GridController.Instance.xl, GridController.Instance.yl);
        Self = GameObject.Find("Canvas/PlayGame/BG1").GetComponent<RectTransform>();
        
    }

    public void SynSelfTransform()
    {
        Self.sizeDelta = size;
        Debug.Log(Self.sizeDelta);
        Debug.Log(Self.transform.name);
        //spawnpoint.localPosition = new Vector2(Self.position.x - Self.sizeDelta.x / 2 + 70, Self.position.y - Self.sizeDelta.y / 2 + 50);
    }

    // Use this for initialization
    void Start ()
    {
        GetTargetTransform();
        SynSelfTransform();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
