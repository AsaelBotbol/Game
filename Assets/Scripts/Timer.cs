using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 0;

    public Text textoTimer;

    public bool existe;

    public GameObject originalObject;

    // Start is called before the first frame update
    void Start()
    {
        existe = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(existe)
        {
            timer -= Time.deltaTime;
            textoTimer.text = "" + Mathf.CeilToInt(timer);
        }

        if (timer < 0)
        {
                                    
            textoTimer.text = "El bicho ha sido liberado.";

            Destroy(textoTimer, 6);

            existe = false;

        }
    }
    public void InstantiateObject()
    {
        if(existe)
        {
            Instantiate(originalObject);
        }
    }
}
