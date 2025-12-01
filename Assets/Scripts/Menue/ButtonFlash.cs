using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonFlash : MonoBehaviour
{
    public Image buttonImage;
    public Color flashColor = Color.yellow;
    public Color ogColor = Color.white;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       buttonImage = GetComponent<Image>();
    }

    // Update is called once per frame
    public void ButtonPress(){
        StartCoroutine(FlashEffect());
    }

    IEnumerator FlashEffect(){
        

        for(int i = 0; i<3 ; i++){
            buttonImage.color = flashColor;
            yield return new WaitForSeconds(0.1f);
            buttonImage.color = ogColor;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
