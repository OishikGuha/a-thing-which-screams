using UnityEngine;

public class Player : MonoBehaviour
{

    public AudioSource audioSource;
    
    void Update()
    {
           
    }

    void OnMouseDown()
    {
        audioSource.Play();
    }
}
