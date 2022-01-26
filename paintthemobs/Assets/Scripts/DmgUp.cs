using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgUp : MonoBehaviour
{
    private Shooting _shooting;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _shooting = GameObject.FindWithTag("Player").GetComponent<Shooting>();
            _shooting.bulletDamage = _shooting.bulletDamage + 2;
            Debug.Log(_shooting.bulletDamage);
            gameObject.SetActive(false);
        }
    }
}
