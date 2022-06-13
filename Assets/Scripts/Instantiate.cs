using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instantiate : MonoBehaviour
{
    public GameObject objInstantiate;
    public bool Ganaste = true;
    public GameObject clon;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i >= 0; i++)
        {
            clon = Instantiate(objInstantiate);
            Destroy(clon, 0.5f);

            if(i >= 10)
            {
                break;
            }
        }
    }

    public void InstantiateObj()
    {
        
    }
}
