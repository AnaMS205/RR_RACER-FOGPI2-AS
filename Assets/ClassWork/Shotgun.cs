using UnityEngine;

public class Shotgun : Weapon
{
    public override void Use()
    {
        Debug.Log("Player Shotgun Bang!");
    }

    public void Equiped(){
        Debug.Log("Equiped: " + gameObject.name);
    }
}
