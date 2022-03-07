using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDrone : MonoBehaviour
{
    [SerializeField] float _speed = 1;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.down * _speed;
    }
}
