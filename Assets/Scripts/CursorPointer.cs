using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorPointer : MonoBehaviour {
    MeshRenderer renderer;
	// Use this for initialization
	void Start () {
        renderer = GetComponentInChildren<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hitTarget;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward,out hitTarget))
        {
            renderer.enabled = true;
            transform.position = hitTarget.point;
            transform.rotation = Quaternion.FromToRotation(Vector3.up, hitTarget.normal);
        }else
        {
            renderer.enabled = false;
        }
	}
}
