using UnityEngine;

public class Pistol : Weapon
{
    public override void Use()
    {
        Debug.Log("Player Pistol Noise");
    }

    public void Equiped(){
        Debug.Log("Equiped: " + gameObject.name);
    }
}