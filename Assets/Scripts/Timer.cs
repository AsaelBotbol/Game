using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 0;

    public Text textoTimer;

    public bool existe;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        textoTimer.text = "" + timer.ToString();

        if (timer < 0)
        {
            textoTimer.text = "El bicho ha sido liberado.";

            Destroy(textoTimer, 6);
        }

    }
}
