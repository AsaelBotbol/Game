using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instantiate : MonoBehaviour
{
    public GameObject objInstantiate;
    public bool Ganaste = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InstantiateObj();
    }

    public void InstantiateObj()
    {
        for (int i = 0; i <= 10; i++)
        {
            GameObject clon = Instantiate(objInstantiate);
            Destroy(clon,1);
        }
    }
}
