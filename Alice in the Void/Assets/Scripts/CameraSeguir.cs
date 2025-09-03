using UnityEngine;

public class CameraSeguir : MonoBehaviour
{
    public Transform player;     // arraste o Player no Inspector
    public float smoothSpeed = 5f; // velocidade da suavização

    void LateUpdate()
    {
        if (player != null)
        {
            Vector3 targetPos = player.position;
            targetPos.z = transform.position.z; // mantém o Z fixo da câmera

            // Suaviza o movimento da câmera até o player
            transform.position = Vector3.Lerp(transform.position, targetPos, smoothSpeed * Time.deltaTime);
        }
    }
}