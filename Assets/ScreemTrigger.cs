using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScreemTrigger : MonoBehaviour
{
    public AudioSource scream;
    public AudioSource doorShut;
    private bool hasTriggered = false;
    public GameObject hallTrigger;
    public GameObject subtitles;
    public Animator bathroomDoor;

    public GameObject[] lights;
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
        if (!hasTriggered && other.CompareTag("Player"))
        {
            hasTriggered = true;
             Invoke("PlayScream", 4f);
            hallTrigger.SetActive(true);
            StartCoroutine(dogdialog());
           foreach (GameObject light in lights)
            {
               light.SetActive(false);
            }
        }
    }


      private void PlayScream()
    {
        scream.Play();
    }

      IEnumerator dogdialog(){
        yield return new WaitForSeconds(1);
        bathroomDoor.Play("Closing");
        doorShut.Play();
        yield return new WaitForSeconds(2);
        bathroomDoor.enabled=false;
        subtitles.GetComponent<Text>().text = "Daisy.......";
        yield return new WaitForSeconds(6);
         subtitles.GetComponent<Text>().text = "Mamá..., debo volver arriba";
        yield return new WaitForSeconds(8);
        subtitles.GetComponent<Text>().text = "";
         yield return new WaitForSeconds(3);
         bathroomDoor.enabled=true;
        bathroomDoor.Play("Opening");}

}
