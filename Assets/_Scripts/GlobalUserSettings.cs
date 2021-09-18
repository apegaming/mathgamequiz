using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalUserSettings : MonoBehaviour
{
    private static bool isBgMuted;
    private static bool isSfxMuted;

    public static bool IsBgMuted { get => isBgMuted; set => isBgMuted = value; }
    public static bool IsSfxMuted { get => isSfxMuted; set => isSfxMuted = value; }

    private void Awake()
    {
        if (PlayerPrefs.HasKey("isBgMuted"))
        {
            Debug.Log("HERE");
            int temp = PlayerPrefs.GetInt("isBgMuted");

            if (temp == 0)
            {
                IsBgMuted = false;
            }
            else
            {
                IsBgMuted = true;
            }
        }
        else
        {
            Debug.Log("HERE 1");
            PlayerPrefs.SetInt("isBgMuted", 0);
        }
    }

    public static void SaveSoundSettings()
    {
        if (IsBgMuted)
        {
            PlayerPrefs.SetInt("isBgMuted", 1);
        }
        else
        {
            PlayerPrefs.SetInt("isBgMuted", 0);
        }
    }
}
