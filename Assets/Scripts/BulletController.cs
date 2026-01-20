using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
   
{
    public GameObject bullet;
    public Transform ballet;
    private Quaternion bulletRotation;
    void Update()
        
    {
        bulletRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, -90);
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, ballet.position,bulletRotation);
        }
    }
}
