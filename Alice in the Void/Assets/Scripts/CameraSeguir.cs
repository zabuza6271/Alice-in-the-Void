using UnityEngine;

public class CameraSeguir : MonoBehaviour
{
    public Transform player;     // arraste o Player no Inspector
    public float smoothSpeed = 5f; // velocidade da suaviza��o

    void LateUpdate()
    {
        if (player != null)
        {
            Vector3 targetPos = player.position;
            targetPos.z = transform.position.z; // mant�m o Z fixo da c�mera

            // Suaviza o movimento da c�mera at� o player
            transform.position = Vector3.Lerp(transform.position, targetPos, smoothSpeed * Time.deltaTime);
        }
    }
}