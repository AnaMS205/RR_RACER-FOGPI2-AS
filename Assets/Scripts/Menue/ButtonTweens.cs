using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ButtonTweens : MonoBehaviour
{
    public RectTransform[] buttons;
    public float slideDuration = 0.6f;
    public float delayButtons = 0.2f;

    void Start(){
        SlidInButtons();
    }

    void SlidInButtons(){
        for(int i=0; i<buttons.Length; i++){
            RectTransform btn = buttons[i];
            Vector2 targetPos = btn.anchoredPosition;
            btn.anchoredPosition = new Vector2(-500, targetPos.y);

            btn.DOAnchorPos(targetPos, slideDuration)
                .SetEase(Ease.OutBack)
                .SetDelay(i* delayButtons);
        }
    }
}
