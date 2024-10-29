using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject nave;
    public float speed;
    public float giro;
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

        if (Input.GetKey(KeyCode.Q))
        {
            //ROTO EL OBJETO Y UTILIZO LA VARIABLE DE GIRO 
            transform.Rotate(Vector3.forward * Time.deltaTime * giro);
        }

        if (Input.GetKey(KeyCode.E))
        {
            //ROTO EL OBJETO Y UTILIZO LA VARIABLE DE GIRO 
            transform.Rotate(Vector3.back * Time.deltaTime * giro);
        }
    }
}
