using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DownButtonScript : MonoBehaviour
{
    private XRBaseInteractable interactable;
    private CNCController cNCController;

    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<XRBaseInteractable>();
        cNCController = GetComponentInParent<CNCController>();
        interactable.hoverEntered.AddListener(Clicked);
        interactable.hoverExited.AddListener(Clicked);

    }

    public void Clicked(BaseInteractionEventArgs hover){
        if(hover.interactorObject is XRPokeInteractor){
            cNCController.ToggleXMotor();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
