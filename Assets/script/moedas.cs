using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moedas : MonoBehaviour
{
    [SerializeField] private float rX;
    [SerializeField] private float rY;
    [SerializeField] private float rZ;
    [SerializeField] private float velocidade;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rX * velocidade * Time.deltaTime, rY * velocidade * Time.deltaTime, rZ * velocidade * Time.deltaTime);
    }
}
