using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{

    private Transform trans;
    private GameObject gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("Cubo");
        trans = gm.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        LogPosition();
    }

    private void LogPosition()
    {
        Debug.Log("La transformacion del objeto es: " + trans.localPosition.x);
        Debug.Log("La transformacion del objeto es: " + trans.localPosition.y);
        Debug.Log("La transformacion del objeto es: " + trans.localPosition.z);
    }
}
