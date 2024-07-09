using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGCont : MonoBehaviour
{
    [System.Serializable]
    public class BGData
    {
        public Transform bgT;
        public float speed;
    }
    public BGData[] bgData;

    public void Start()
    {
        
    }

    public void Update()
    {
        for (int i = 0; i < bgData.Length; i++)
        {
            bgData[i].bgT.Translate(Vector3.down * Time.deltaTime * bgData[i].speed);
        }
        
    }

}
