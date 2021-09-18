using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public static SoundManager soundInstance;

    [Header("SoundNames")]
    [SerializeField] AudioClip backgourndMusic;

    [Header("Btn Clicked Sound")]
    [SerializeField] AudioClip btnClickedSound;

    public AudioSource _audioSource;
    Dictionary<string, AudioClip> soundDictionary = new Dictionary<string, AudioClip>();

    private AudioSource _musicSource;

    public bool testBoolForSound;

    private void Awake()
    {
        if (soundInstance == null)
        {
            soundInstance = this;
        }
        initiateVariables();
    }

    private void initiateVariables()
    {
        // assign sounds to dictionary
        
        soundDictionary.Add("backgroundMusic", backgourndMusic);
        soundDictionary.Add("btnClickedSound", btnClickedSound);

        _audioSource = transform.GetComponent<AudioSource>();
        _musicSource = gameObject.AddComponent<AudioSource>();
        _musicSource.loop = true;
    }

    private void Start()
    {
        if (!GlobalUserSettings.IsBgMuted && testBoolForSound)
        {
            Debug.Log("pLAY mUSIC");
            PlayMusic("backgroundMusic");
        }
    }

    /// <summary>
    /// use GlobalUserSettings as conditions to play or mute the sound, put a check of bool before calling the method
    /// </summary>
    /// <param name="soundName"></param>
    public void PlaySound(string soundName)
    {
        if (!GlobalUserSettings.IsBgMuted && testBoolForSound)
        {
            if (soundDictionary.ContainsKey(soundName))
            {
                PlaySound(soundDictionary[soundName]);
            }
            else
            {
                Debug.Log("KEY NOT FOUND  SoundManager :: " + soundName);
            }
        }
    }

    public void PlaySoundBtnClicked()
    {
        if (!GlobalUserSettings.IsBgMuted && testBoolForSound)
        {
            if (soundDictionary.ContainsKey("btnClickedSound"))
            {
                PlaySound(soundDictionary["btnClickedSound"]);
            }
            else
            {
                Debug.Log("KEY NOT FOUND  SoundManager :: " + btnClickedSound);
            }
        }
    }

    public void PlaySound(AudioClip clip)
    {
        if (!GlobalUserSettings.IsBgMuted && testBoolForSound)
        {
            _audioSource.PlayOneShot(clip);
        }
    }


    public void PlayMusic(string musicName)
    {
        if (!GlobalUserSettings.IsBgMuted && testBoolForSound)
        {
            if (soundDictionary.ContainsKey(musicName))
            {
                _musicSource.clip = soundDictionary[musicName];
                if (!_musicSource.isPlaying) _musicSource.Play();
            }
            else
            {
                Debug.Log("KEY NOT FOUND  SoundManager :: " + musicName);
            }
        }
    }

    public void StopMusic()
    {
        _musicSource.Stop();
    }
}
