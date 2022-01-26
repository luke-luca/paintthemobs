using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovUp : MonoBehaviour
{
    private PlayerMovement _movement;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _movement = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
            _movement.moveSpeed = _movement.moveSpeed + 3;
            gameObject.SetActive(false);
        }
    }
}
