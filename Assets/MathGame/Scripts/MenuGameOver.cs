using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace ApeGaming.MathGame
{
	public class MenuGameOver : MonoBehaviour 
	{
		public Text level;
		public Text score;
		public Text bestScore;

		public GameObject newBestScoreLabel;

        [Header("Sound")]
        [SerializeField] Image soundBtnImage;
        [SerializeField] Sprite soundOn;
        [SerializeField] Sprite soundOff;

        void OnEnable(){
			level.text = ScoreManager.GetLastLevel ().ToString ();
			score.text = ScoreManager.GetLastScore ().ToString ();
			bestScore.text = ScoreManager.GetBestScore ().ToString ();

			bool isNewBest = ScoreManager.GetLastScoreIsBest ();

			if (isNewBest) {
				newBestScoreLabel.SetActive (true);
			} else {
				newBestScoreLabel.SetActive (false);
			}

            RefreshSoundButtonUI();
        }

        #region SOUNDS
        public void OnClickSoundButton()
        {
            GlobalUserSettings.IsBgMuted = !GlobalUserSettings.IsBgMuted;
            Debug.Log(GlobalUserSettings.IsBgMuted);
            RefreshSoundButtonUI();
            if (!GlobalUserSettings.IsBgMuted) SoundManager.soundInstance.PlayMusic("backgroundMusic");
            else SoundManager.soundInstance.StopMusic();
            GlobalUserSettings.SaveSoundSettings();
        }

        void RefreshSoundButtonUI()
        {
            Debug.LogError(GlobalUserSettings.IsBgMuted);
            if (GlobalUserSettings.IsBgMuted)
            {
                soundBtnImage.sprite = soundOff;
            }
            else
            {
                soundBtnImage.sprite = soundOn;
            }
        }
        #endregion
    }
}