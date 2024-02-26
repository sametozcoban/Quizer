using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Quizer.Scene
{
    public class SceneControl : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
                Debug.Log("Uygulamadan Çıkılıyor");
            }
        }

        public void SelectionToMathFirstWeekQuestions()
        {
            SceneManager.LoadScene("MathTestScene");
        }

        public void MainMenuToSelection()
        {
            SceneManager.LoadScene("CourseSelect");
        }

        public void MathToLevelSelection()
        {
            SceneManager.LoadScene("CourseSelect");
        }

        public void PlayAgain()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        public void QuitApplication()
        {
            Application.Quit();
        }
        
        public void MathSelectToMathWeeks()
        {
            SceneManager.LoadScene("MathLevel");
        } 
 
        public void TRLevel()
        {
            //Türkçe Level
        } // Yapılmadı
        public void SocialScience()
        {
            //Sosyal Bilgiler
        } // Yapılmadı
        public void Science()
        {
            //Fen Bilimleri
        } // Yapılmadı
        public void ScienceOfLife()
        {
            //Hayat bilgisi
        } // Hayat bilgisi yapılmadı.
    }
}
