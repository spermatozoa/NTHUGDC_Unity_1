using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLogPrint : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("From example: Hello GDC!");
        print("From example: Hello GDC again");

        Debug.LogError("This is LogError!");
        Debug.LogWarning("This is LogWarning!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
