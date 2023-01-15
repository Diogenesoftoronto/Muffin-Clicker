using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    // Start is called before the first frame update
    // Create a integer variable that is public called default volume
    public static float defaultVolume = 0.45f;
    private float currentVolume = 0.10f;
    public GameObject Music;
    public Slider slider;

    private AudioSource MusicAudioComponent;
    void Start()
    {
        // On start we want set the volume to the default
        // Find the BackgroundMusic Game Object.
        Music = GameObject.Find("/BackgroundMusic");
        if (Music == null) {
            print(Music);
            return;
        }
       MusicAudioComponent = Music.GetComponent<AudioSource>();
        if (MusicAudioComponent == null) {
            print(MusicAudioComponent);
            return;
        }
        MusicAudioComponent.volume = defaultVolume;
    }

    // Update is called once per frame
    void Update()
    {
        /* check to see the position of the slider 
        and set the volume at that position. */

        slider = GameObject.Find("Slider").GetComponent<Slider>();
        currentVolume = slider.value;
        MusicAudioComponent.volume = currentVolume;
    }
}
