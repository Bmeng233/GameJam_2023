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
        fader.DOFade(1, 0.5f).From(0).OnStepComplete(() =>
        {
            Invoke("LoadScene", 0.5f);
        });
    }
}
