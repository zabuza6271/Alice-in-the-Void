using Unity.VisualScripting;
using UnityEngine;

public class Mov : MonoBehaviour
{

    //SerializedField serve pra vari�vel aparecer na unity.
    //Aqui eu fiz uma vari�vel pro Rigidbody2D pra fazer a movimenta��o do boneco.

    [SerializeField]
    private Rigidbody2D rigidbody;

    [SerializeField]
    private float VelocidadeMovimento;

    // Usando a aba "Update" pra Unity saber que o bot�o est� sendo pressionado 
    // GetAxisRaw é pra uma movimentação mais direta, mas se quiser uma parada mais suave da pra usar o GetAxis (não acho necessário)
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); // x
        float vertical = Input.GetAxisRaw("Vertical"); // y

        Vector2 direcao = new Vector2(horizontal, vertical);
        direcao = direcao.normalized;
        //debug ai só pra ver no console na unity
        Debug.Log(direcao + " => " + direcao.magnitude);

        this.rigidbody.linearVelocity = direcao * this.VelocidadeMovimento;


    }
}
