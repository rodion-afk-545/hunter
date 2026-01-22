using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
   private float speed = 15;

    
    void Update()
    {
        
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
