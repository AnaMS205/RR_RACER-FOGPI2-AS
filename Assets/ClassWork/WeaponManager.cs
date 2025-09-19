// using System.Collections.Generic;
// using UnityEditor;

// #if UNITY_EDITOR 
// using UnityEngine;
// //using UnityEditor;

// [CustomEditor(typeof(WeaponManager))]
// public class WeaponManagerEditor : Editor

// #ELIF
// {
//     public override void OnInspectorGUI()
//     {
//         base.OnInspectorGUI();

//         WeaponManager wm = (WeaponManager)target;

//         if (GUILayout.Button("prev"))
//         {
//             wm.PreWeapon();
//         }

//         if (GUILayout.Button("Use"))
//         {
//             wm.Use();
//         }
//     }
// }

// public class WeaponManager : MonoBehaviour
//     {   //sit on player
//         public List<Weapon> weapons;
//         public Weapon currentWeapon;
//         private int weaponIndex = 0;

//         public void Use()
//         {
//             if (currentWeapon)
//                 currentWeapon.Use();
//         }

//         public void PreWeapon()
//         {
//             if (weapons.Count <= 1)
//                 return;

//             weaponIndex--;
//             if (weaponIndex < 0)
//                 weaponIndex = weapons.Count - 1;

//             currentWeapon = weapons[weaponIndex];
//             currentWeapon.equiped.Invoke();


//         }

//         public void NextWeapon()
//         {
//             if (weapons.Count <= 1)
//                 return;

//             weaponIndex++;

//             if (weaponIndex >= weapons.Count)
//                 weaponIndex = 0;

//             currentWeapon = weapons[weaponIndex];
//             currentWeapon.equiped.Invoke();
//         }
//     }
