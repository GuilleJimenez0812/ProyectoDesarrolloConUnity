using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScreemTrigger : MonoBehaviour
{
    public AudioSource scream;
    private bool hasTriggered = false;
    public GameObject hallTrigger;
    public GameObject subtitles;

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
            scream.Play();
            hallTrigger.SetActive(true);
            StartCoroutine(dogdialog());

           foreach (GameObject light in lights)
            {
               light.SetActive(false);
            }
        }
    }

      IEnumerator dogdialog(){
        yield return new WaitForSeconds(1);
        subtitles.GetComponent<Text>().text = "Daisy.......";
        yield return new WaitForSeconds(6);
         subtitles.GetComponent<Text>().text = "......Mamá, debo volver arriba?";
        yield return new WaitForSeconds(8);
        subtitles.GetComponent<Text>().text = "";}
    
}
