using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    private GameObject teleport;
    [SerializeField]
    private GameObject player;
    private bool tele = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
            
            
    //            StartCoroutine(PlayerTeleport());
            
    //    }
    //}

    

    IEnumerator PlayerTeleport()
    {
        yield return new WaitForSeconds(1f);
        player.transform.position = new Vector3(teleport.transform.position.x,teleport.transform.position.y, teleport.transform.position.z);

        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (tele == true) { 

            teleport.gameObject.SetActive(true);
                tele = false;
            }

        else if (tele == false) 
            {
                teleport.gameObject.SetActive(false);
                tele = true;
            }

        }



    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           
            if(tele == true)
            {
                teleport.gameObject.SetActive(false);
            }
                StartCoroutine(PlayerTeleport());
           

        }
    }
    
}
