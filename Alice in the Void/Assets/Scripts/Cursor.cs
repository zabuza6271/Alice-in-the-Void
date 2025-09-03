using UnityEngine;

public class Cursor : MonoBehaviour
{
    public Transform cursor;       // arraste (um objeto filho com sprite, ex: setinha)
    public float cursorDistance = 1.0f; // distância do cursor em relação ao player

    void Update()
    {
        // Pega posição do mouse no mundo
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0f;

        // Direção do player até o mouse
        Vector3 direction = (mouseWorldPos - transform.position).normalized;

        // Mantém o cursor a uma distância fixa do player
        cursor.position = transform.position + direction * cursorDistance;

        // Faz o cursor girar para apontar para o mouse
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        cursor.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}