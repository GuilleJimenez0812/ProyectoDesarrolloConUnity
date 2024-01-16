using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SubsScript : MonoBehaviour
{
    public GameObject textBox;
    private bool subStatus;
    private GameObject interactSub;
    private GameObject interactCube1;
    private GameObject interactCube2;
    private GameObject interactCube3;
    private GameObject interactCube4;
    private GameObject interactCube5;
    void Start()
    {
        StartCoroutine(TheSequence());
    }

    IEnumerator TheSequence(){
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "¿Que fue ese sonido?";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "Esta muy oscuro aqui";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
    }
        IEnumerator TheSequence2(){
        textBox.GetComponent<Text>().text = "¿Hay una nota al lado del gorro?";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        interactCube1.SetActive(false);
    }
    IEnumerator TheSequence3(){
        textBox.GetComponent<Text>().text = "¿Porque la musica esta encendida?";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        interactCube2.SetActive(false);
    }
    IEnumerator TheSequence4(){
        textBox.GetComponent<Text>().text = "Nooo, mi perro";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "¿Porque me esta pasando esto?";
        yield return new WaitForSeconds(3);
        interactCube3.SetActive(false);
    }
    IEnumerator TheSequence5(){
        textBox.GetComponent<Text>().text = "Ahhhh, ¿Que fue eso?";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        interactCube4.SetActive(false);
    }
    IEnumerator TheSequence6(){
        textBox.GetComponent<Text>().text = "Todo esto esta mu mal, tengo mucho miedo";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "Voy a buscar a mis padres arriba";
        yield return new WaitForSeconds(4);
        interactCube5.SetActive(false);
    }


    public void ToggleSub(int num)
    {
        subStatus = !subStatus;

        switch (num){
            case 1:
                interactCube1 = GameObject.Find("SubCube");
                StartCoroutine(TheSequence2());
                break;
            case 2:
                interactCube2 = GameObject.Find("SubCube2");
                StartCoroutine(TheSequence3());
                break;
            case 3:
                interactCube3 = GameObject.Find("SubCube3");
                StartCoroutine(TheSequence4());
                break;
            case 4:
                interactCube4 = GameObject.Find("SubCube4");
                StartCoroutine(TheSequence5());
                break;
            case 5:
                interactCube5 = GameObject.Find("SubCube5");
                StartCoroutine(TheSequence6());
                break;
        }
        
        
        
    }

    public bool GetSubStatus()
    {
        return subStatus;
    }
}
