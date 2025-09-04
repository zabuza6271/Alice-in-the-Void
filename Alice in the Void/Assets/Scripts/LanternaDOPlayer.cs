using UnityEngine;

public class LanternaDOPlayer : MonoBehaviour
{
    public GameObject cursor;
    public GameObject flashlight;
    private bool hasLantern = false;

    private SpriteRenderer playerSprite;

    void Start()
    {
        playerSprite = GetComponentInChildren<SpriteRenderer>();

        flashlight.SetActive(false);
        cursor.SetActive(true);
    }

    public void EnableLantern()
    {
        hasLantern = true;
        cursor.SetActive(false);
        flashlight.SetActive(true);
    }

    void Update()
    {
        if (hasLantern)
        {
            // Posição do mouse no mundo
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPos.z = 0f; // Z = 0 para 2D

            // Direção do player para o mouse
            Vector2 dir = (mouseWorldPos - transform.position).normalized;

            // Rotaciona a lanterna na direção do mouse
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            flashlight.transform.rotation = Quaternion.Euler(0f, 0f, angle - 90f);

            // Ajusta flipX baseado no player
            if (playerSprite.flipX)
            {
                flashlight.transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                flashlight.transform.localScale = new Vector3(1, 1, 1);
            }
        }
    }
}