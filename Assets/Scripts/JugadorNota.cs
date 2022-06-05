using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorNota : MonoBehaviour
{
    public GameObject ObjPuntos;
    public AudioClip papersound;
    public AudioSource audioNota;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Notas")
        {
            ObjPuntos.GetComponent<Puntos>().puntos += 1;

            audioNota.clip = papersound;
            audioNota.Play();
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
