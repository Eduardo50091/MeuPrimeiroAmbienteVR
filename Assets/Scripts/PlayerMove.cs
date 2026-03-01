using UnityEngine;

public class PlayerMove : MonoBehaviour
{
        public float velocidade = 5f;
        public float gravidade = -9.81f;
        private CharacterController controller;
        private Vector3 velocidadeVertical;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
        AplicarGravidade();
    }

    void Mover()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direcao = transform.right * horizontal + transform.forward * vertical;
        controller.Move(direcao * velocidade * Time.deltaTime);
    }

    void AplicarGravidade()
    {
        if (controller.isGrounded && velocidadeVertical.y < 0)
        {
            velocidadeVertical.y = -2f;
        }

        velocidadeVertical.y += gravidade * Time.deltaTime;
        controller.Move(velocidadeVertical * Time.deltaTime);
    }
}
