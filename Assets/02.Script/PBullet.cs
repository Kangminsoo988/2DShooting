using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBullet : MonoBehaviour
{
    [HideInInspector]
    public float speed;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 10f);
        
    }
}
