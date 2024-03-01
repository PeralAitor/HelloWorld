using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarPartesTren : MonoBehaviour
{
    private GameObject [] allGameObjects;

    // Start is called before the first frame update
    void Start()
    {
        allGameObjects = (GameObject[])GameObject.FindObjectsOfType(typeof(MonoBehaviour));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(allGameObjects[1]);
        }
       
    }
}
