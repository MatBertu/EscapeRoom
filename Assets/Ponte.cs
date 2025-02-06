using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ponte : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MaterializzaPonte()
    {
        gameObject.GetComponent<Collider>().isTrigger = false;
        gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
        Debug.Log("Ponte creato");
    }

    public void SmaterializzaPonte()
    {
        gameObject.GetComponent<Collider>().isTrigger = true;
        gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}
