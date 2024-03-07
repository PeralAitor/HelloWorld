using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCubo : MonoBehaviour
{

    public float velocidad = 1f;

    // Start is called before the first frame update
    void Start()
    {
        createCubeAndSetParent();
    }

    // Update is called once per frame
    void Update()
    {
        checkMovement();
        checkEscale();
        checkRotation();
        
    }

    void checkMovement()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += Vector3.up;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += Vector3.down;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.transform.position = new Vector3(0.0f, 1.0f, 0.0f);
        }

    }

    void checkEscale()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.localScale += Vector3.down;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.localScale += Vector3.up;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.localScale += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.localScale += Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            this.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
        }
    }

    void checkRotation()
    {
        this.transform.rotation *= Quaternion.Euler(0, 1, 0);
    }

    void createCubeAndSetParent()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(3.0f, 1.0f, 0.0f);
        cube.transform.SetParent(this.transform);
        cube.transform.LookAt(this.transform);
    }
}
