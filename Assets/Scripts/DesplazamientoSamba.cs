using UnityEngine;

public class DesplazamientoSamba : MonoBehaviour
{
    public GameObject nave;
    public float speed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float desplX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * desplX * Time.deltaTime * speed);

        float desplY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * desplY * Time.deltaTime * speed);

        
        
    }
}
