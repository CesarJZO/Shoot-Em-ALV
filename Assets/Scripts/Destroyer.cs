using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public void DestroyItself()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
