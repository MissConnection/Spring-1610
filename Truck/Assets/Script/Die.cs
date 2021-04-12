using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public GameObject Square;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "p")
        {
            Debug.Log("Collision detected");
            Square.GetComponent<Renderer>().enabled = false;
        }
    }
}