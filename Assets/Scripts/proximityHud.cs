using UnityEngine;

public class proximityHud : MonoBehaviour
{
    public GameObject canvasInfo;

    private void Start()
    {
        if (canvasInfo != null)
            canvasInfo.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Algo entrou no trigger");
        
        if (other.CompareTag("Player"))
        {
            canvasInfo.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvasInfo.SetActive(false);
        }
    }
}
