using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 5f;
    MeshRenderer Renderer;
    Rigidbody Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Renderer = GetComponent<MeshRenderer>();
        Rigidbody = GetComponent<Rigidbody>();
        Renderer.enabled = false;
        Rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
            Renderer.enabled = true;
            Rigidbody.useGravity = true;  
        }
        
    }
}
