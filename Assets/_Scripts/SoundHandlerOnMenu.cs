using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundHandlerOnMenu : MonoBehaviour
{
    [Header("Sound")]
    [SerializeField] Image soundBtnImage;
    [SerializeField] Sprite soundOn;
    [SerializeField] Sprite soundOff;

    private void OnEnable()
    {
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
