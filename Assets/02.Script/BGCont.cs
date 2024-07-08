using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGCont : MonoBehaviour
{
    public Transform[] bgs; 

    
    void Update()
    {
        for (int i = 0; i < bgs.Length; i++)
        {
            bgs[i].Translate(Vector2.down * Time.deltaTime * 3f);
        }
    }
}
