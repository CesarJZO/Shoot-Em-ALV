using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;
    MeshRenderer meshRenderer;
    Vector2 movement;
    void Awake() {
        meshRenderer = GetComponent<MeshRenderer>();
        movement = new Vector2();
    }
    void Update()
    {
        movement.y = Time.time * speed;
        movement.x = Time.time * speed / 2;
        meshRenderer.material.mainTextureOffset = movement;
    }
}
