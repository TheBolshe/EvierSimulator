using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenePlate : MonoBehaviour
{
    public GameObject assiette;

    int cpt;
    int lim=1000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cpt++;
        if (cpt==lim){
            cpt=0;
            lim=(int)Random.Range(500, 1500);
            Instantiate(assiette);
        }
    }
}
