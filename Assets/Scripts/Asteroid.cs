using UnityEngine;
using UnityEngine.Events;

public class Asteroid : MonoBehaviour
{
    public static int AsteroidCounter { get; private set; } = 0;
    [SerializeField] float _speed = 1;
    [SerializeField] GameObject _explosion;

    public UnityEvent<int> OnAsteroidDestroyed;
    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.down * _speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AsteroidCounter++;
        OnAsteroidDestroyed?.Invoke(AsteroidCounter);
        GameObject bullet = collision.gameObject;
        Instantiate(_explosion, bullet.transform.position, Quaternion.identity);
        Destroy(bullet);
        Destroy(gameObject);
    }
}
