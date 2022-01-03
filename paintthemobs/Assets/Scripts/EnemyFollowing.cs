using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowing : MonoBehaviour
{
    public float moveSpeed;
    private Transform target;
    public void Start()
    {
        target = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }
    public void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    }
}
