using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
   private float speed = 4;

    
    void Update()
    {
        
        transform.Translate(Vector3.down * Time.deltaTime * speed);
    }
}
