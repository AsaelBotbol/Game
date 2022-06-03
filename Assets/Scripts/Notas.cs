using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notas : MonoBehaviour
{
    public GameObject ObjPuntos;
    public AudioClip papersound;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            ObjPuntos.GetComponent<Puntos>().puntos += 1;

            audioNota.clip = papersound;
            audioNota.Play();

            Destroy(gameObject);
        }
    }
    AudioSource audioNota;

    // Start is called before the first frame update
    void Start()
    {
        
        audioNota = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
