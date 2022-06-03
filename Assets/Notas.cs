using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notas : MonoBehaviour
{
    public GameObject ObjPuntos;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Jugador")
        {
            ObjPuntos.GetComponent<Puntos>().puntos += 1;
            Destroy(gameObject); //https://www.youtube.com/watch?v=9A-kE0Y_R_k
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
