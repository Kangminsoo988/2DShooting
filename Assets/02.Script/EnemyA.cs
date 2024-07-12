using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*public void OnCollisionEnter2D(Collection2D collection)
    {
        Destroy(OnCollisionEnter2D gameObject);
    }*/

    public void OnCollisionEnter2D(Collection2D collection)
    {
        Destroy(OnCollisionEnter2D gameObject);
    }
}
