using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notas : MonoBehaviour
{
    public GameObject ObjPuntos;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            ObjPuntos.GetComponent<Puntos>().puntos += 1;
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
