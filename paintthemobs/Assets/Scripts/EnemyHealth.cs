using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyHealth;
    private Shooting _shooting;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Damage();
        if (collision.CompareTag("Bullet") && enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void Damage()
    {
        _shooting = GameObject.FindWithTag("Player").GetComponent<Shooting>();
        enemyHealth = enemyHealth - _shooting.bulletDamage;
    }
}
