using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProgressBar : MonoBehaviour
{
    public SphereMotion Player;
    public Transform FinishPlatform;
    public Slider Slider;
    public float AcceptableFinishPlayerDistance = 10f;

    private float _startY;
    private float _currentlY;

    private void Start()
    {
        _startY = Player.transform.position.y;
    }
    private void Update()
    {
        float currentlY = Player.transform.position.y;
        float finishY = FinishPlatform.position.y;
        float t = Mathf.InverseLerp(_startY, finishY + AcceptableFinishPlayerDistance, currentlY);
        Slider.value = t;
    }
}
