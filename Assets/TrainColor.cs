using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainColor : MonoBehaviour
{
    private GameObject [] objectListWheel,objectListBody;
    private  GameObject objectChimney;
    public Color color;
    public string tags;
   

    // Start is called before the first frame update
    void Start()
    {
        startGameObjects();
    }

    // Update is called once per frame
    void Update()
    {
        setColorToTrain();
    }

    private void startGameObjects()
    {
        objectListWheel = GameObject.FindGameObjectsWithTag(tags);
    }

    private void setColorToTrain()
    {
        for(int i = 0; i < objectListWheel.Length; i++)
        {
            objectListWheel[i].GetComponent<Renderer>().material.color = color;
        }

        for (int i = 0; i < objectListBody.Length; i++)
        {
            objectListBody[i].GetComponent<Renderer>().material.color = color;
        }

        objectChimney.GetComponent<Renderer>().material.color = color;

    }

}
