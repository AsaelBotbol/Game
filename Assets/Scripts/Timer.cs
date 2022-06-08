using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 0;

    public Text textoTimer;

    public bool tiempo;

    public GameObject originalObject;

    // Start is called before the first frame update
    void Start()
    {
        tiempo = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(tiempo)
        {
            timer -= Time.deltaTime;
            textoTimer.text = "" + Mathf.CeilToInt(timer);
        }

        if (timer < 0)
        {
            textoTimer.text = "El bicho ha sido liberado.";
            Destroy(textoTimer, 6);
            originalObject.gameObject.SetActive(true);
            tiempo = false;
        }
        
    }
}
