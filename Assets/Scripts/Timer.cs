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

    //int i = 2;

    public GameObject Enemy;

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
            textoTimer.text = "El enemigo ha sido spawneado, busca las notas antes de que te encuentre.";
            Destroy(textoTimer, 6);
            originalObject.gameObject.SetActive(true);
            tiempo = false;

            //while (i > 2)
            //{

            //    GameObject clon = Instantiate(Enemy, gameObject.transform.position, Quaternion.Euler(0, 0, 0));
            //    i -= 1;
            //}

        }
        
    }
}
