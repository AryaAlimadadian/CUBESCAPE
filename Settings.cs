using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class Settings : MonoBehaviour
{
    public AudioMixer audiomixer;
    Resolution[] resolutions;
    public TMP_Dropdown resolutionDropdown;
    List<int> gg = new List<int>();
    void Start ()
    {
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();
        Debug.Log(resolutions);
        List<string> options = new List<string>();
        
        int currentResolutionIndex = 0;
        int flag = 0;
        int p = 0;
        for (int i=0;i<resolutions.Length;i++)
        {
            flag = 0;
            string option = resolutions[i].width + " x " + resolutions[i].height;
            for (int j=0;j<options.Count;j++)
            {
                if (option==options[j])
                {
                    flag = 1;
                    p++;
                }
            }
            if (flag == 0)
            {
                Debug.Log(p);
                gg.Add(p);
                options.Add(option);
            }

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }
    int r = 0;
    public void SetResolution(int resolutionIndex)
    {
        Debug.Log(gg.Count);
        Debug.Log(resolutions.Length);
        r = gg[resolutionIndex];
        Debug.Log(r);
       
        Resolution resolution = resolutions[resolutionIndex+r];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void SetVolume(float volume)
    {
        audiomixer.SetFloat("MyExposedParam", volume);
    }
    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
