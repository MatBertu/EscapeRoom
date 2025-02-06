using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Lever leva;
    public Button bottone;
    public Ponte ponte;
    public GameObject porta;

       /* leva.onLeverActivate.AddListener(ponte.MaterializzaPonte);
        leva.onLeverDeactivate.AddListener(ponte.SmaterializzaPonte);
        bottone.onButtonPressed.AddListener(ApriPorta);
        bottone.onButtonRelease.AddListener(ChiudiPorta);
       */
    // Start is called before the first frame update
    /*void Start()
    {
        
    }
        private void ChiudiPorta()
    {
        porta.SetActive(true);
    }

    private void ApriPorta()
    {
        porta.SetActive(false);
    }
    */
    // Update is called once per frame
    void Update()
    {
        
    }
}
