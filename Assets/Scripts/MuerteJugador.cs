using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuerteJugador : MonoBehaviour
{
    public AudioClip screamer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            audioScreamer.clip = screamer;
            audioScreamer.Play();

            Invoke(nameof(Perder), 1f);
        }
    }
    AudioSource audioScreamer;


    // Start is called before the first frame update
    void Start()
    {
        audioScreamer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Perder()
    {
        SceneManager.LoadScene("Perdiste");
    }
}
