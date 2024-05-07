using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManaUI : MonoBehaviour
{
    // Start is called before the first frame update

    public player playerMovement;

    private TMP_Text ManaText;
    void Start()
    {
        ManaText = GetComponent<TMP_Text>();
        playerMovement = GameObject.Find("Player").GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    {
        ManaText.text = "Mana: " + Mathf.Round(playerMovement.mana);

    }
}
