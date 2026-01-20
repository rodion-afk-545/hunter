using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Animals"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}

