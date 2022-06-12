using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instantiate : MonoBehaviour
{
    public GameObject objInstantiate;
    public bool Ganaste = true;

    int i = 0;

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
        while (i == 0)
        {
            Instantiate(objInstantiate);
            Destroy(objInstantiate,1);
            i++;
        }
    }
}
