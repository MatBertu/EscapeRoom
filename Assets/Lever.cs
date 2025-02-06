using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public Ponte ponte;
    public bool azionata = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.GetComponent<Character>() != null)
        {
            if (azionata == true)
            {
                Debug.Log("Deazione la leva ");
                azionata = false;
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                ponte.SmaterializzaPonte();

            }
            else
            {
                Debug.Log("Aziono la leva ");
                azionata = true;
                transform.rotation = Quaternion.Euler(new Vector3(66, 0, 0));
                ponte.MaterializzaPonte();


            }

        }



    }
}
