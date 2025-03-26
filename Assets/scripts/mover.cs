using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField] float moveSpace = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpace;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpace;
        transform.Translate(xValue, 0, zValue);
        
    }
}
