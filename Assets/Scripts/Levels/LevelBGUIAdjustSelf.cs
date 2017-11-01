using UnityEngine;
using System.Collections;
using System;

public class LevelBGUIAdjustSelf : MonoBehaviour, IUIAdjustSelf {
    public RectTransform Self { get; set; }

    public RectTransform Target { get;set ;}

    private Vector2 Pos;
    public RectTransform spawnpoint;
    public void GetTargetTransform()
    {
        Pos = new Vector2(GridController.Instance.xl*65, GridController.Instance.yl*65);
        Self = GameObject.Find("Canvas/PlayGame/BG1").GetComponent<RectTransform>();
        
    }

    public void SynSelfTransform()
    {
        Self.sizeDelta = Pos;
        spawnpoint.localPosition = new Vector2(Self.position.x - Self.sizeDelta.x / 2 + 70, Self.position.y - Self.sizeDelta.y / 2 + 50);
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
