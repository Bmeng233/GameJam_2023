using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    public CanvasGroup canvasGroup;

    void awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.ap
        DOFade(0, 0.5f).From(1);
    }
}
