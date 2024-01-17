using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class activateHallFootsteps : MonoBehaviour
{
    public AudioSource hallfootsteps;
    private bool hasTriggered = false;
    public GameObject subtitles;
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
         if (!hasTriggered && other.CompareTag("Player")){
             Invoke("PlayFootsteps", 3f);
            hasTriggered=true;
            StartCoroutine(hallFootseps());
         }
    }

      private void PlayFootsteps()
    {
        hallfootsteps.Play();
    }

     IEnumerator hallFootseps(){
        yield return new WaitForSeconds(1);
        subtitles.GetComponent<Text>().text = "¿Que es ese Oso?";
        yield return new WaitForSeconds(2);
         subtitles.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
         subtitles.GetComponent<Text>().text = "Esta muy oscuro aqui";
        yield return new WaitForSeconds(2);
         subtitles.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
    }
}
