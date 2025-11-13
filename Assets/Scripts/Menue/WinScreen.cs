using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public GameObject winScreen;
    public Timer timer;

    public GameObject winResults;
    public TMP_Text timeResultText;

    public string backToMenu = "MainMenu"; //retunr to the main menu

    /// DOTWEEN ///
    public RectTransform textToSlide;
    public float slideDuration = 0.6f;
    public Vector2 targetPos = new Vector2(0,0);
    public Vector2 finalPos = new Vector2(2000,0);
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        winScreen.SetActive(false);
        winResults.SetActive(false);
        //ShowWinScreen();
    }

    // Update is called once per frame
    void Update()
    {
        float finalTime = timer.time;
        timeResultText.text = "Final Time : " + finalTime.ToString("F2"); 
        
    }

    public void ShowWinScreen(){
        winResults.SetActive(false);
        winScreen.SetActive(true);
        StartCoroutine(PlayWinResults());
    }

    void FINISHTween()
    {
        textToSlide.DOAnchorPos(targetPos, slideDuration).SetEase(Ease.OutBack);
        
    }

    IEnumerator PlayWinResults(){
        //play finial tween
        textToSlide.DOAnchorPos(targetPos, slideDuration).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(2f);
        textToSlide.DOAnchorPos(finalPos, slideDuration).SetEase(Ease.OutBack);

        //show time results and retunr button
        yield return new WaitForSeconds(0.2f);
        winResults.SetActive(true);

    }

    public void ReturnButton(){
        //return to the main menu
        SceneManager.LoadScene(backToMenu);

    }
}
