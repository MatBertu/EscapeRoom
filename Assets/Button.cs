using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject OpenTheDoor;
    public GameObject Platform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)

    {
        Character character = other.gameObject.GetComponent<Character>();
        if (character != null)
        {
            Debug.Log("Hai premuto il bottone");
            Platform.SetActive(true);
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            OpenTheDoor.SetActive(false);
            
        }

    }

   
}
