using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class activateEnding : MonoBehaviour
{
    public GameObject monster;
    public GameObject trigger1;
    public GameObject trigger2;
    public GameObject subtitles;
    private bool hasTriggered = false;
    public AudioSource[] audios;

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
        { monster.SetActive(true);                     
          trigger2.SetActive(true); 
          trigger1.SetActive(true); 
          StartCoroutine(finalDialog());
          hasTriggered=true;
            foreach (AudioSource audio in audios)
            {
               audio.Stop();
            }
         }
    }

        IEnumerator finalDialog(){
      
       
        yield return new WaitForSeconds(2);
        subtitles.GetComponent<Text>().text = "Ma..., lo siento";
        yield return new WaitForSeconds(6);
        subtitles.GetComponent<Text>().text = "";}
}
    
