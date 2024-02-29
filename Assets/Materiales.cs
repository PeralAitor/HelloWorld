using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Materiales : MonoBehaviour
{

    private GameObject[] gm;
    private Renderer render1,render2,render3;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectsWithTag("PrimerTag");
        
        render1 = gm[0].GetComponent<Renderer>();
        render1.material.color = Color.red;

        render2 = gm[1].GetComponent<Renderer>();
        render2.material.color = Color.blue;

        render3 = gm[2].GetComponent<Renderer>();
        render3.material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
