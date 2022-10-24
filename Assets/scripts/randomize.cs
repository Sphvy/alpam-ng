using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomize : MonoBehaviour
{
    public GameObject wronganswer1;
    public GameObject wronganswer2;
    public GameObject rightanswer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rightanswer.transform.position.x < -1f)
        {
            wronganswer1.transform.position = new Vector3(0, -4f, 0f);
            wronganswer2.transform.position = new Vector3(9f, -4f, 0f);
        }
        else if (rightanswer.transform.position.x == 0)
        {
            wronganswer1.transform.position = new Vector3(9f, -4f, 0f);
            wronganswer2.transform.position = new Vector3(-9f, -4f, 0f);
        }
        else if (rightanswer.transform.position.x > 1f)
        {
            wronganswer1.transform.position = new Vector3(-9f, -4f, 0f);
            wronganswer2.transform.position = new Vector3(0, -4f, 0f);
        }
    }
}
