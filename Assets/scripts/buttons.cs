using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    public GameObject wronganswer1;
    public GameObject wronganswer2;
    public GameObject rightanswer;
    public GameObject rightanswerbutton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rightanswer.transform.position.x == -7)
        {
            rightanswerbutton.transform.position = new Vector3(-7f, -4f, 0f);
            wronganswer1.transform.position = new Vector3(0f, -4f, 0f);
            wronganswer2.transform.position = new Vector3(7f, -4f, 0f);
        }
        else if (rightanswer.transform.position.x == 0)
        {
            rightanswerbutton.transform.position = new Vector3(0f, -4f, 0f);
            wronganswer1.transform.position = new Vector3(7f, -4f, 0f);
            wronganswer2.transform.position = new Vector3(-7f, -4f, 0f);
        }
        else if (rightanswer.transform.position.x == 7)
        {
            rightanswerbutton.transform.position = new Vector3(7f, -4f, 0f);
            wronganswer1.transform.position = new Vector3(-7f, -4f, 0f);
            wronganswer2.transform.position = new Vector3(0f, -4f, 0f);
        }
    }
}
