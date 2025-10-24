using UnityEngine;

public class DeathDrop : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.PlayerDied();
            GameManager.Instance.GameOver();
        }
    }
}

