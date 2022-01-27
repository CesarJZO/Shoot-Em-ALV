using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float _speed = 10;
    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * _speed;
    }
}
