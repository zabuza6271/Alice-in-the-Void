using UnityEngine;

public class LanternaPickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LanternaDOPlayer flashlight = collision.GetComponent<LanternaDOPlayer>();

            if (flashlight != null)
            {
                flashlight.EnableLantern();
            }

            // Destr�i o item do ch�o
            Destroy(gameObject);
        }
    }
}
