using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTweenUi : MonoBehaviour
{
    [SerializeField] private RectTransform _bg = null;
    [SerializeField] private RectTransform [] _mathLevelRect = null;
    // Start is called before the first frame update
    void Start()
    {
        if (_mathLevelRect != null)
        {
            for (int i = 0; i < _mathLevelRect.Length; i++)
            {
                if (_mathLevelRect[i]!= null)
                {
                    if (i == 0)
                    {
                        _mathLevelRect[i].DOScale(Vector3.zero, 3f).From();
                    }
                    else if (i == 1)
                    {
                        _mathLevelRect[i].DOScale(Vector3.down, 3f).From();
                    }
                    else
                    {
                        _mathLevelRect[i].DOScale(Vector3.up, 3f).From();
                    }
                }
              
            } 
        }
        if (_bg != null)
        {
            _bg.DOScale(Vector3.zero, 3f).From();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
