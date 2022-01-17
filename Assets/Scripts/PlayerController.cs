using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5;
    public Boundary boundary;
    Gamepad gamepad = Gamepad.current;
    void Start()
    {
        if (gamepad == null)
            Debug.Log("You need a controller!");
    }

    void Update()
    {
        if (gamepad != null)
        {
            Vector2 direction = gamepad.leftStick.ReadValue() * speed * Time.deltaTime;
            transform.Translate(direction.x, direction.y, 0);

            // Delimiting the playing area
            transform.position = new Vector3(
                Mathf.Clamp(transform.position.x, boundary.MinX, boundary.MaxX),
                Mathf.Clamp(transform.position.y, boundary.MinY, boundary.MaxY)
            );
        }
    }
}

[System.Serializable] public class Boundary
{
    [SerializeField] private float _horizontal;
    [SerializeField] private float _vertical;
    public float MaxX
    {
        get
        {
            return _horizontal / 2;
        }
    }
    public float MaxY
    {
        get
        {
            return _vertical / 2;
        }
    }
    public float MinY
    {
        get
        {
            return _vertical / -2;
        }
    }
    public float MinX
    {
        get
        {
            return _horizontal / -2;
        }
    }
}
