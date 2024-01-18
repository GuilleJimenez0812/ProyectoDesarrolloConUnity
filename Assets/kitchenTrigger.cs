using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class kitchenTrigger : MonoBehaviour
{
    public GameObject subtitles;
    public Animator bathroomDoor;
    public AudioSource dogsBark;
    private bool hasTriggered = false;

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
            hasTriggered=true;
            StartCoroutine(bathroom());
            Invoke("PlayDog", 4f);
            bathroomDoor.enabled=true;

         }
    }

  private void PlayDog()
    {
        dogsBark.Play();
    }
    IEnumerator bathroom(){
        yield return new WaitForSeconds(1);
        subtitles.GetComponent<Text>().text = "Algo muy malo esta pasando aqui";
        yield return new WaitForSeconds(3);
         subtitles.GetComponent<Text>().text = "......";
        yield return new WaitForSeconds(6);
         subtitles.GetComponent<Text>().text = "Daisy no dios!, que hacias en el baño?, debo buscarla y avisarle a mama todo lo que esta pasando";
        yield return new WaitForSeconds(7);
         subtitles.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);}
}
