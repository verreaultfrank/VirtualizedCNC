using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Motor : MonoBehaviour
{
    public decimal stepPerFrame = 0.1m;
    
    public bool isRotating {get; set; } = false;
    public bool antiClockWise = true;

    public GameObject attachedLeadScew;  

    public AudioSource audioSource;
    public AudioClip audioClip;  
    
    public void Start(){
        audioSource.clip = audioClip;
        audioSource.loop = true;
    }

    public void Update(){
        if(isRotating){
            Rotate();
            if(!audioSource.isPlaying && !attachedLeadScew.GetComponent<LeadScrew>().attachedCart.GetComponent<Cart>().maximumIsReached){
                audioSource.Play();
            }else if(audioSource.isPlaying && attachedLeadScew.GetComponent<LeadScrew>().attachedCart.GetComponent<Cart>().maximumIsReached)
                audioSource.Pause();
        }
        else if(audioSource.isPlaying){
            audioSource.Pause();
        }
    }

    public void Rotate(){
        attachedLeadScew.GetComponent<LeadScrew>().Rotate(antiClockWise);
    }
}