using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioEnd : MonoBehaviour
{
    public GameObject finish;
    // Start is called before the first frame update
    void Start()
    {
        finish.SetActive(false);
        
        
    }

    // Update is called once per frame
    public void next()
    {
        gameObject.SetActive(false);
        finish.SetActive(true);

    }
}
