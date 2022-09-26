void Start()

{//Disable Instructions After Putting Off Fires
    window.setActive(false)
}

//Update is called once per frame

void Update()
{//Enable Instrucitons After Putting Off Fires
    if (Fire == null && Fire2 == null && Fire3 == null && Fire5 == null && Fire6 == null && Fire7 == null && Fire8 == null)
    {
        window.setActive(true);
        Destroy(window,10);
    }
}

private void OnCollisionENter(Collision col)
{//Destroying Fires on Contact with Extinguisher Fumes
if (col.gameObject.name == "Enemy")
    {
        Debug.Log("Collision Detected");
        Destroy(Fire);
        Destroy(Cube);   
    }

}


// Function: This script is in two parts. It destroys fires upon collision and prints a timed message for
// the user for directives to exit the building.
// Explanation:

// a. A box collider was placed at the base of the fire, upon collision with the box colliders from
// the fire extinguisher, the fire is destroyed.
// b. To do this, a ‘OnCollisionEnter’ function to detect this collision. A message printed on the
// Debug.Log was used to verify the function.
// c. Upon quenching the fire, a UI panel is displayed for 10 seconds for directives to exit the
// building. The UI panel is only activated upon quenching all three fires.