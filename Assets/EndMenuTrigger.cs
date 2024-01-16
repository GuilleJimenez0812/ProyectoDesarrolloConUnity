using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    // El nombre de la escena a la que quieres cambiar
    public string nombreEscena = "EndScreen";

    // El tiempo en segundos que quieres esperar antes de cambiar de escena
    public float tiempoEspera = 7f;

    // Un booleano que indica si el box collider se ha activado o no
    private bool activado = false;

    // Un contador que lleva el tiempo transcurrido desde que se activ� el box collider
    private float tiempoTranscurrido = 0f;

    // Este m�todo se ejecuta cuando otro collider entra en contacto con el box collider de este objeto
    private void OnTriggerEnter(Collider other)
    {
        // Si el box collider est� en modo trigger
        if (GetComponent<Collider>().isTrigger)
        {
            // Cambiamos el valor de activado a verdadero
            activado = true;
        }
    }

    // Este m�todo se ejecuta en cada fotograma del juego
    private void Update()
    {
        // Si el box collider se ha activado
        if (activado)
        {
            // Aumentamos el tiempo transcurrido con el tiempo que ha pasado desde el �ltimo fotograma
            tiempoTranscurrido += Time.deltaTime;

            // Si el tiempo transcurrido es mayor o igual que el tiempo de espera
            if (tiempoTranscurrido >= tiempoEspera)
            {
                // Cambiamos de escena usando el nombre que hemos indicado
                SceneManager.LoadScene(nombreEscena);
            }
        }
    }
}
