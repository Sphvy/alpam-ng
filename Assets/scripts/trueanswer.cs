using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trueanswer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 7, 0, -7 };
        int randomNum = Random.Range(0, array.Length);
        transform.position = new Vector3(array[randomNum], -4f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
