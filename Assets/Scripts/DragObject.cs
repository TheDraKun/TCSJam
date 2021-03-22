using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    Rigidbody rb;
    private float CamZDdist;
    private Camera Cam;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cam = Camera.main;
        CamZDdist = Cam.WorldToScreenPoint(transform.position).z;
    }

    private void OnMouseDrag()
    {
        Vector3 ScreenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, CamZDdist);
        Vector3 nWorldPos = Cam.ScreenToWorldPoint(ScreenPos);
        transform.position = nWorldPos;
    }
}
