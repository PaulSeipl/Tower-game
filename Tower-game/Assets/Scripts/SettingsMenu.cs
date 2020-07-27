using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public TMPro.TMP_Dropdown resolutionDropdown;
    public TMPro.TMP_Dropdown qualityDropdown;
    public Toggle fullScreenToggle;

    Resolution[] resolutions;
    void Start() {

        fullScreenToggle.isOn = Screen.fullScreen;

        qualityDropdown.SetValueWithoutNotify(QualitySettings.GetQualityLevel());

        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();
        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.SetValueWithoutNotify(currentResolutionIndex);
    }

    public void SetResolution (int resultionIndex) {
        Resolution resolution = resolutions[resultionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
   public void SetQuality (int qualityIndex) {
       QualitySettings.SetQualityLevel(qualityIndex);
   }

   public void SetFullscreen (bool isFullscreen) {
       Screen.fullScreen = isFullscreen;
   }
}
