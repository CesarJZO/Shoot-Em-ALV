using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    [Header("Properties")]
    [SerializeField] float _speed = 5;
    [Header("References")]
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] Transform _shooterPoint;
    [SerializeField] InputActionReference _moveAction;
    [SerializeField] Boundary _boundary;

    void Update()
    {
        transform.Translate(_speed * Time.deltaTime * _moveAction.action.ReadValue<Vector2>());

        // Delimiting the playing area
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, _boundary.MinX, _boundary.MaxX),
            Mathf.Clamp(transform.position.y, _boundary.MinY, _boundary.MaxY)
        );
            
    }
    public void OnFire()
    {
        Instantiate(_bulletPrefab, _shooterPoint.position, Quaternion.identity);
    }
}

[System.Serializable]
public class Boundary
{
    [SerializeField] private float _width;
    [SerializeField] private float _height;
    public float MaxX => _width / 2;
    public float MaxY => _height / 2;
    public float MinY => _height / -2;
    public float MinX => _width / -2;
}
