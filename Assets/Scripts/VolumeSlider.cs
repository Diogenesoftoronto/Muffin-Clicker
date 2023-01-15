using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    // Start is called before the first frame update
    // Create a integer variable that is public called default volume
    private float currentVolume = 0.10f;
    [SerializeField]
    private static float defaultVolume = 0.45f;
    
    private GameObject music;
    private Slider slider;

    private AudioSource musicAudioComponent;
    void Start()
    {
        // On start we want set the volume to the default
        // Find the BackgroundMusic Game Object.
        music = GameObject.Find("/BackgroundMusic");
        // get component throws an exception if this it doesn not find an audio source :(
        musicAudioComponent = music.GetComponent<AudioSource>();
        musicAudioComponent.volume = defaultVolume;
    }

    // Update is called once per frame
    void Update()
    {
        /* check to see the position of the slider 
        and set the volume at that position. */
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        currentVolume = slider.value;
        musicAudioComponent.volume = currentVolume;
    }
}
