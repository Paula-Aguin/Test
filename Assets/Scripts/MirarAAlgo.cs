using UnityEngine;

public class MirarAAlgo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform objetoTarget;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ACCIÓN DE MIRAR HACIA UN PUNTO O COORDENADA 
        transform.LookAt(objetoTarget);
    }
}
