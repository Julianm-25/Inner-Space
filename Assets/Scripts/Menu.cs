using UnityEngine;

/// <summary>
/// This script manages the options menu
/// </summary>
public class Menu : MonoBehaviour
{
    /// <summary>
    /// Enables/disables AntiAliasing
    /// </summary>
    public void AntiAliasing()
    {
        if (QualitySettings.antiAliasing == 0)
            QualitySettings.antiAliasing = 1;
        else
            QualitySettings.antiAliasing = 0;
    }
}