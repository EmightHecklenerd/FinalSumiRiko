using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectortion : MonoBehaviour
{
    
    private void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.CompareTag("lid"))
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }

        else if (other.gameObject.CompareTag("good"))
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
        }

    }




}
