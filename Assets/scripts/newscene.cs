using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newscene : MonoBehaviour
{
    public GameObject scene0;
    public GameObject scene1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void newScene1()
    {
        
        scene0.SetActive(false);
        scene1.SetActive(true);
        Debug.Log("new");
    }
}
