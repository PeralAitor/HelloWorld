using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionLogger : MonoBehaviour
{
    [SerializeField]
    private GameObject gm;
    public Vector3 vector;


    void Start()
    {
        gm = GameObject.Find("Cubo");
    }

    // Update is called once per frame
    void Update()
    {
        LogPosition();
    }

    private void LogPosition()
    {
        Debug.Log("La transformacion del objeto es: " + vector.x);
        Debug.Log("La transformacion del objeto es: " + vector.y);
        Debug.Log("La transformacion del objeto es: " + vector.z);
    }
}
