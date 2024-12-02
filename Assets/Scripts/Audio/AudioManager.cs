using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup musicEffectGroup;
    [SerializeField] private AudioMixerGroup soundEffectsGroup;

    public static AudioManager Instance;
    public Sounds[] sounds;

    private Dictionary<string, float> musicPlaybackPositions = new Dictionary<string, float>();

    public void Awake()
    {
        Instance = this;

        foreach (Sounds s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.audioClip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.Loop;

            switch (s.audioType)
            {
                case Sounds.AudioTypes.soundEffect:
                    s.source.outputAudioMixerGroup = soundEffectsGroup;
                    break;

                case Sounds.AudioTypes.music:
                    s.source.outputAudioMixerGroup = musicEffectGroup;
                    break;
            }
        }
    }

    //82% - >

    public void Start()
    {
        audioMuted = PlayerPrefs.GetInt("saveMutedAudio");

        if (!PlayerPrefs.HasKey("saveMutedAudio"))
        {
            audioMuted = 1;
        }
       
        if (audioMuted == 0)
        {
            audioMutedIcon.SetActive(true);
            audioUnmutedIcon.SetActive(false);
        }
        if (audioMuted == 1)
        {
            audioMutedIcon.SetActive(false);
            audioUnmutedIcon.SetActive(true);
        }
    }

    public void Stop(string name)
    {
        Sounds s = Array.Find(sounds, sound => sound.clipName == name);
        if (s == null)
        {
            Debug.LogWarning("Sound clip not found: " + name);
            return;
        }

        if (s.source.isPlaying)
        {
            s.playbackPosition = s.source.time; // Store the playback position in the Sounds object
            s.source.Stop();
        }
    }

    public void Play(string name)
    {
        Sounds s = Array.Find(sounds, sound => sound.clipName == name);

        if (s == null)
        {
            Debug.LogWarning("Sound clip not found: " + name);
            return;
        }

        if (s.source.isPlaying)
        {
            s.source.Stop();
        }

        s.source.time = s.playbackPosition; // Set the stored playback position

        s.source.Play();
    }

    public void UpdateMixerVolume()
    {
        musicEffectGroup.audioMixer.SetFloat("Music Volume", Mathf.Log10(AudioOptionsManager.musicVolume) * 20);
        soundEffectsGroup.audioMixer.SetFloat("Audio Volume", Mathf.Log10(AudioOptionsManager.soundEffectolume) * 20);
    }

    public GameObject audioMutedIcon, audioUnmutedIcon;
    public static int audioMuted;

    public void MuteAudio()
    {
        FindObjectOfType<AudioManager>().Stop("music");
        audioMutedIcon.SetActive(true);
        audioUnmutedIcon.SetActive(false);
        PlayerPrefs.SetInt("saveMutedAudio", audioMuted = 0);
    }

    public void UnMuteAudio()
    {
        FindObjectOfType<AudioManager>().Play("music");
        audioMutedIcon.SetActive(false);
        audioUnmutedIcon.SetActive(true);
        PlayerPrefs.SetInt("saveMutedAudio", audioMuted = 1);
    }
}
