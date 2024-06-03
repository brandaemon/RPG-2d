using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.UI;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    public player playerMovement; 
    private RectTransform Rect;
    //public Image image;
    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<player>(); 
        Rect = GetComponent<RectTransform>();

    }

    // Update is called once per frame
    void Update()
    {
        Rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, playerMovement.health * 3f );

    }
}
