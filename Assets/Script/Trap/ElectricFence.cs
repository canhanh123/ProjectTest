using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricFence : MonoBehaviour
{
   //ublic GameObject electricFence;
    public GameObject Buttonelectric;
    public GameObject[] electric;
    int i;
    bool OnOff = true;
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
        if (other.gameObject.CompareTag("Player"))
        {
            if (OnOff == true)
            {
                OnOff = false;
              //electricFence.SetActive(true);
              for(int  i = 0; i < electric.Length; i++)
                {
                    electric[i].SetActive(true);
                }
             
            }
            else if (OnOff == false)
            {
                OnOff = true;
                //electricFence.SetActive(false);
                for (int i = 0; i < electric.Length; i++)
                {
                    electric[i].SetActive(false);
                }
            }


        }
    }
 
}