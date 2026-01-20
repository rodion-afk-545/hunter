using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float sentifif = 2;

    void Update()
    {
        horizontal=Input.GetAxis("Mouse X")*sentifif;
        vertical=Input.GetAxis("Mouse Y")* sentifif;
        transform.Rotate(0,horizontal,0);   
        transform.Rotate(0,0,vertical);
    }
}
