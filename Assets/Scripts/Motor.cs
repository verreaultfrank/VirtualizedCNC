using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
    public decimal stepPerFrame = 0.1m;
    //From 0 to 359.999 deg
    public decimal currentRotation = 0;
    private decimal maxRotation = 360;
    
    public bool isRotating = false;

    public void Rotate(bool antiClockWise = false){
        int rotationMultiplier = (antiClockWise)? -1 : 1;
        currentRotation += rotationMultiplier*stepPerFrame;
        if(currentRotation >= maxRotation)
            currentRotation -= maxRotation;

        Debug.Log("The " + this.name + " rotation is " + currentRotation);
    }

}