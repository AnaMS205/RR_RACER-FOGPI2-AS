using UnityEngine;
using TMPro;

public class TempGameButtons : MonoBehaviour
{
    //public TMP_Text text;

    //public GameObject QRimage;
    //public GameObject UnButton;

    public bool clicked = false;

    // public void Start(){
    //     HideQR();
    //     UnButton.SetActive(false);

    // }

    public void OuitGame(){
        Application.Quit();     //quit game
    }

    // public void QRButton(){
    //     ShowQR();
    //     UnButton.SetActive(true);
    // }

    // public void UnQRButton(){
    //     HideQR();
    //     UnButton.SetActive(false);
    // }

//     public void ShowQR(){
//         //show an image of the qr code
//         QRimage.SetActive(true);
//     }

//     public void HideQR(){
//         //show an image of the qr code
//         QRimage.SetActive(false);
//     }
 }
