using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInfo : MonoBehaviour
{
    public Text dmgText;
    public Text movText;
    private Shooting _shooting;
    private PlayerMovement _movement;
    void Update()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        _movement = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
        movText.text = _movement.moveSpeed.ToString();
        _shooting = GameObject.FindWithTag("Player").GetComponent<Shooting>();
        dmgText.text = _shooting.bulletDamage.ToString();
    }
}
