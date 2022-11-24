using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;
    public Spawner spawni;
    public GameObject arrowObject;
    ParticleSystem spriteRenderer;
    public int presentsNotDelivered;
    Timer time;
    bool still_time;
    void Start()
    {
        time = FindObjectOfType<Timer>();
        spriteRenderer = GetComponent<ParticleSystem>();
        arrowObject.SetActive(false);
         

        Debug.Log(time.TimeLeft);
        
    }
    void Update()
    {
        
        
        still_time =time.TimerOn;
        
        if (presentsNotDelivered == 0 && still_time)
        {
            
            Debug.Log("You won");
        }
        if(!still_time && presentsNotDelivered > 0)
        {

            Debug.Log(time.TimeLeft);
            Debug.Log("You Lose");
            SceneManager.LoadScene("You Lose");

        }
        
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ouch!");
        
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        Score(presentsNotDelivered);
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Packaged picked up");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
            spriteRenderer.Play();
            arrowObject.SetActive(true);
            spawni.spawn();
        }
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Delivered Package to Customer");
            spriteRenderer.Stop();
            Destroy(other.gameObject, destroyDelay);
            hasPackage = false;
            arrowObject.SetActive(false);
            presentsNotDelivered --;
            Debug.Log(presentsNotDelivered);
            Score(presentsNotDelivered);
            Debug.Log(time.TimeLeft);
        }

    void Score(int presentsNotDelivered)
    {
        
        if (presentsNotDelivered == 0 && still_time)
        {
            Debug.Log("You won");
            SceneManager.LoadScene("You Won");
        }
        if(presentsNotDelivered > 0 && !still_time)
        {
            Debug.Log(time.TimeLeft);
        
            SceneManager.LoadScene("You Lose");

        }
        
    }

}
}
