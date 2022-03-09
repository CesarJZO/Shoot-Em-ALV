using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float _speed = 20;
    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * _speed;
    }
}
