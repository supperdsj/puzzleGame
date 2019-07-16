using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsControllerScript : MonoBehaviour {
    [SerializeField] GameObject settingsPanel;
    [SerializeField] Animator settingsPanelAnim;

    void Awake() {
        settingsPanel = GameObject.Find("SettingsPanel");
        settingsPanelAnim = settingsPanel.GetComponent<Animator>();
    }

    public void OpenSettingsPanel() {
        settingsPanel.SetActive(true);
        settingsPanelAnim.Play("SlideIn");
    }
    public void CloseSettingsPanel() {
        StartCoroutine(CloseSettings());
    }

    IEnumerator CloseSettings() {
        settingsPanelAnim.Play("SlideOut");
        yield return new WaitForSeconds(1f);
        settingsPanel.SetActive(false);
    }
}
