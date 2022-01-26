using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthReg : MonoBehaviour
{
    private Health _health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _health = GameObject.FindWithTag("Player").GetComponent<Health>();
            _health.health = _health.health + 2;
            _health.UpdateHealth();
            gameObject.SetActive(false);
        }
    }
}
