using UnityEngine;

public class RotarSamba : MonoBehaviour
{
    public GameObject nave;
    public float giro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //transform.Rotate(Vector3.right * Time.deltaTime * giro);

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
