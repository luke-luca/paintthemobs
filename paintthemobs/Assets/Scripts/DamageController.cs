using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{

    private Health _health;
    public AudioSource audio1;
    public int setDamage;
    float timer = 0;
    public float damageTime = 2;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            timer -= damageTime;
            audio1.Play();
            Damage();
        }

    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (timer >= damageTime)
            {
                timer -= damageTime;
                audio1.Play();
                Damage();
            }
            timer += Time.deltaTime;
        }
    }
    private void Damage()
    {
        _health = GameObject.FindWithTag("Player").GetComponent<Health>();
        _health.health = _health.health - setDamage;
        _health.UpdateHealth();
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            timer = 0;
        }
    }
}
