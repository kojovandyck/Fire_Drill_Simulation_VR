using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ParticleLauncher : MonoBehaviour
{
	// Start is called before the first frame update
	public ParticleSystem particleLauncher;
	void Start()
	{
    	
	}
 
	// Update is called once per frame
	void Update()
	{
    	if (Input.GetButton("Fire1"))
    	{
        	particleLauncher.Emit(1);
    	}
	}
}
 
//Function: This script was to perform the “extinguishing” function of a fire extinguisher.
//Explanation: Upon hitting the ‘A’ button, tiny box colliders (mesh renderer removed) are emitted from the fire extinguisher which destroy the fire upon collision. This function is updated once per frame which gives it the fire extinguishing effect of multiple particles being emitted.
 
