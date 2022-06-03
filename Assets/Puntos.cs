using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public int puntos;

    public Text textoPuntos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (puntos >= 10)
        {
            SceneManager.LoadScene("Ganaste");
            Cursor.lockState = CursorLockMode.None;
        }

        //UI
        textoPuntos.text = puntos + "/10";
    }
}
