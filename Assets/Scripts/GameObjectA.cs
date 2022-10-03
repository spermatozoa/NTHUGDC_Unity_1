using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectA : MonoBehaviour
{
    private GameObject B;
    public GameObject C;
    // Start is called before the first frame update
    void Start()
    {
        B = GameObject.Find("B");

        Debug.Log(B.name);
        Debug.Log(C.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveC(){
        C.SetActive(true);
    }

    public void CloseC(){
        C.SetActive(false);
    }
}
