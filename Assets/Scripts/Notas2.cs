using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notas2 : MonoBehaviour
{
    public GameObject ObjPuntos;
    public AudioClip papersound;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Notas")
        {
            ObjPuntos.GetComponent<Puntos>().puntos += 1;

            audioNota.clip = papersound;
            audioNota.Play();

            Destroy(gameObject,1);
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
