using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeatstart : MonoBehaviour
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
        if (rightanswer.transform.position.x == -7)
        {
            new WaitForSeconds(1);
            rightanswer.SetActive(true);
            new WaitForSeconds(1);
            wronganswer1.SetActive(true);
            new WaitForSeconds(1);
            wronganswer2.SetActive(true);
        }
        else if (rightanswer.transform.position.x == 0)
        {
            new WaitForSeconds(1);
            wronganswer2.SetActive(true);
            new WaitForSeconds(1);
            rightanswer.SetActive(true);
            new WaitForSeconds(1);
            wronganswer1.SetActive(true);
        }
        else if (rightanswer.transform.position.x == 7)
        {
            new WaitForSeconds(1);
            wronganswer1.SetActive(true);
            new WaitForSeconds(1);
            wronganswer2.SetActive(true);
            new WaitForSeconds(1);
            rightanswer.SetActive(true);
        }
    }
}
