using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public void DestroyItself()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Bottom Limit") return;
        Destroy(collision.gameObject);
    }
}
