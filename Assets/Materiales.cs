using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Materiales : MonoBehaviour
{
    private GameObject gm;
    private GameObject[] lGm;
    private bool check;
    private string tags;
    private Color colorDeseado;

    // Start is called before the first frame update
    void Start()
    {
        lGm = GameObject.FindGameObjectsWithTag(tags);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (check == true)
        {

            for (int i = 0; i < lGm.Length; i++)
            {
                lGm[i].GetComponent<Renderer>().material.color = colorDeseado;
            }
        }
    }
         

}
