using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiner : MonoBehaviour
{
    [SerializeField] float xValue = 0f;
    [SerializeField] float yValue = 0f;
    [SerializeField] float zValue = 0f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xValue, yValue, zValue);   
    }
}
