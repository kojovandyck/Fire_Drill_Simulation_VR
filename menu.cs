using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Menu : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
   	Destroy(gameObject, 10);
        	
	}
 
	// Update is called once per frame
	void Update()
	{
    	
	}
 
}
 
 
//Function: This script was to destroy a UI panel that had been activated at the start of the game. 
//Explanation: The game object here is the UI panel and it was meant to be destroyed after 15 seconds. The 15 seconds by our calculations is enough time for the user to read the game directives on the panel. This function is only executed at the start of the game.
