using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDrone : MonoBehaviour
{
    [HideInInspector]
    public EnemyConfig config; 
    float _speed;
    void Start()
    {
        _speed = config.speed;
        GetComponent<Rigidbody2D>().velocity = Vector2.down * _speed;
        if (config.sprite != null)
            GetComponentInChildren<SpriteRenderer>().sprite = config.sprite;
    }
}
