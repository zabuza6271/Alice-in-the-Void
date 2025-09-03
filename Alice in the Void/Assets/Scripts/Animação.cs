using UnityEngine;

public class Animação : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D rigidbody2d;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    [SerializeField]
    private Animator animator;
    


    // Update is called once per frame
    private void LateUpdate()
    {
        Vector2 velocidade = this.rigidbody2d.linearVelocity;

        if ((velocidade.x != 0) || (velocidade.y != 0))
        {
            this.animator.SetBool("run", true);
        }
        else
        {
            this.animator.SetBool("run", false);
        }


        if (velocidade.x > 0)
        {
            this.spriteRenderer.flipX = false; //direita
        } else if (velocidade.x < 0)
        {
            this.spriteRenderer.flipX = true; //esquerda
        }


    }
}
