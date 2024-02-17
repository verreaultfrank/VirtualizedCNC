using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CNCButtonScript : MonoBehaviour
{
    private XRBaseInteractable interactable;
    private CNCController cNCController;

    public string MotorName;

    public bool Inverse = false;
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
            cNCController.ToggleMotor(MotorName, Inverse);
        }
    }
}
