using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShootTriggerable : TriggerableAbility {

    [HideInInspector] public int GunDamage;                         // Set the number of hitpoints that this gun will take away from shot objects with a health script.
    [HideInInspector] public float WeaponRange;                   // Distance in unity units over which the player can fire.
    [HideInInspector] public float HitForce;                     // Amount of force which will be added to objects with a rigidbody shot by the player.
    public Transform GunEnd;                                            // Holds a reference to the gun end object, marking the muzzle location of the gun.
    [HideInInspector] public LineRenderer LaserLine;                    // Reference to the LineRenderer component which will display our laserline.

    private WaitForSeconds shotDuration = new WaitForSeconds(1f);     // WaitForSeconds object used by our ShotEffect coroutine, determines time laser line will remain visible.


    public override void Initialize()
    {
        LaserLine = GetComponent<LineRenderer>();
    }
    public override void Trigger(Ability ability)
    {
        base.Trigger(ability);
        Fire();
    }
    public void Fire()
    {
        Camera fpsCam = Camera.main;
        //Create a vector at the center of our camera's near clip plane.
        Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(.5f, .5f, 0));

        //Draw a debug line which will show where our ray will eventually be
        Debug.DrawRay(GunEnd.position, fpsCam.transform.forward * WeaponRange, Color.green);

        //Declare a raycast hit to store information about what our raycast has hit.
        RaycastHit hit;

        //Start our ShotEffect coroutine to turn our laser line on and off
        StartCoroutine(ShotEffect());

        //Set the start position for our visual effect for our laser to the position of gunEnd
        LaserLine.SetPosition(0, GunEnd.position);

        //Check if our raycast has hit anything
        if (Physics.Raycast(rayOrigin, fpsCam.transform.forward, out hit, WeaponRange))
        {
            //Set the end position for our laser line 
            LaserLine.SetPosition(1, hit.point);

            //Get a reference to a health script attached to the collider we hit
            Entity entity = hit.collider.GetComponent<Entity>();

            //If there was an entity health script attached
            if (entity != null)
            {
                entity.Damage(GunDamage);
            }

            //Check if the object we hit has a rigidbody attached
            if (hit.rigidbody != null)
            {
                //Add force to the rigidbody we hit, in the direction it was hit from
                hit.rigidbody.AddForce(-hit.normal * HitForce);
            }
        }
        else
        {
            //if we did not hit anything, set a position to draw the end of line
            LaserLine.SetPosition(1, fpsCam.transform.forward * WeaponRange);
        }
    }
    
    private IEnumerator ShotEffect()
    {

        //Turn on our line renderer
        LaserLine.enabled = true;

        yield return shotDuration;

        //Deactivate our line renderer after waiting
        LaserLine.enabled = false;
    }

}
