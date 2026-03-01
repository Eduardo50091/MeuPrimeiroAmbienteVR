using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float sensibilidade = 2f;
    public Transform corpoJogador;
    private float rotacaoX = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensibilidade;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidade;
        rotacaoX -= mouseY;
        rotacaoX = Mathf.Clamp(rotacaoX, -90f, 90f);
        transform.localRotation = Quaternion.Euler(rotacaoX, 0f, 0f);
        corpoJogador.Rotate(Vector3.up * mouseX);
    }
}
