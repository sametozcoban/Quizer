using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Quizer.Scene
{
    public class UIControl : MonoBehaviour
    {
        [Header("Ayarlara Basıldığında Açılan UI")]
        [SerializeField] private GameObject _settingsUi;
        
        [Header("Ayarlara Basıldığında Course Select Kısmı Text Kontrol")]
        [SerializeField] private GameObject _txt = null;
        
        [Header("Kapatılan butonlar")]
        [SerializeField] private Button[] _gameButtons;
        
        [Header("Ayarlar UI kapatmak için kullanılan buton")]
        [SerializeField] private Button closeButton;
        [SerializeField] private Button infoCloseButton;
        
        [Header("DOTween Rect Kontrol")]
        [SerializeField] private RectTransform _settingsRect;
        [SerializeField] private RectTransform _informationRect;
        [SerializeField] private RectTransform _infoCloseRect;
        [SerializeField] private RectTransform _closeRect;
        
        [Header("Information Basıldığında Açılan UI")]
        [SerializeField] private GameObject _informationUI;
        
        public void OpenSettings()
        {
                 if (_txt != null)
                 {
                     _txt.SetActive(false);
                 }
                _settingsUi.SetActive(true);
                _settingsRect.DOScale(Vector3.zero, 2f).From();
                _closeRect.DOScale(Vector3.zero, 2f).From();
                closeButton.gameObject.SetActive(true);
                foreach (var button in _gameButtons)
                {
                    button.gameObject.SetActive(false);
                } 
        }

        public void CloseSettings()
        {
            if (_txt != null)
            {
                _txt.SetActive(true);
            }
            _settingsUi.SetActive(false);
            closeButton.gameObject.SetActive(false);
            foreach (var button in _gameButtons)
            {
                button.gameObject.SetActive(true);
            }
        }

        public void OpenInformationUI()
        {
            _informationUI.SetActive(true);
            _informationRect.DOScale(Vector3.zero, 2f).From();
            _infoCloseRect.DOScale(Vector3.zero, 2f).From();
            infoCloseButton.gameObject.SetActive(true);
            foreach (var button in _gameButtons)
            {
                button.gameObject.SetActive(false);
            } 
        }

        public void CloseInformationUI()
        {
            _informationUI.SetActive(false);
            infoCloseButton.gameObject.SetActive(false);
            foreach (var button in _gameButtons)
            {
                button.gameObject.SetActive(true);
            }         }

        public void ReturnToBackPage()
        {
            int activeBuildIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(activeBuildIndex - 1);
        }

        public void ReturnToHome()
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}