using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{

    public Health _health;
    public int setDamage;
    float timer = 0;
    public float damageTime = 2;
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (timer >= damageTime)
            {
                timer -= damageTime;

                Damage();
            }
            timer += Time.deltaTime;
        }
    }
    private void Damage()
    {
        _health.health = _health.health - setDamage;
        _health.UpdateHealth();
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Reset the damage timer
            timer = 0;
        }
    }
}
