using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Launcher : MonoBehaviour
{
	// Start is called before the first frame update
	[SerializeField]
	private Transform firePoint;
	[SerializeField]
	private Rigidbody projectilePrefab;
	[SerializeField]
	private float launchForce = 700f;
	void Start()
	{
    	
	}
 
	// Update is called once per frame
	void Update()
	{
    	if (Input.GetButtonDown("Fire1"))
    	{
        	LaunchProjectile();
    	}
	}
	private void LaunchProjectile()
	{
            	
        	var projectileInstance = Instantiate(
            	projectilePrefab,
            	firePoint.position,
            	firePoint.rotation);
 
            projectileInstance.AddForce(firePoint.forward * launchForce);
    	
	}
}
//Function: This script was to make the fire extinguishing more realistic by deactivating the fire crackling sound upon fire quenching.
//Explanation: This script uses a setActive function which deactivates sound upon fire quenching. If fire is active, setActive activates sound.
