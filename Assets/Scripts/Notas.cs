using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notas : MonoBehaviour
{
    public GameObject ObjPuntos;
    public AudioClip papersound;
    AudioSource audioNota;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            Destroy(gameObject);
        }
    }

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
