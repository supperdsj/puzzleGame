using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPuzzleScript : MonoBehaviour {
    [SerializeField] GameObject selectPuzzleMenuPanel,puzzleLevelSelectMenuPanel;
    [SerializeField] Animator selectedPuzzleMenuAnim,puzzleLevelSelectMenuPanelAnim;
    string selectedPuzzle;

    void Awake() {
        selectPuzzleMenuPanel = GameObject.Find("SelectPuzzleMenuButtons");
        puzzleLevelSelectMenuPanel = GameObject.Find("PuzzleLevelSelectMenuPanel");
        selectedPuzzleMenuAnim = selectPuzzleMenuPanel.GetComponent<Animator>();
        puzzleLevelSelectMenuPanelAnim = puzzleLevelSelectMenuPanel.GetComponent<Animator>();
    }

    public void SelectedPuzzle() {
        selectedPuzzle = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(selectedPuzzle);
        StartCoroutine(ShowPuzzleLevelSelectMenu());
    }

    IEnumerator ShowPuzzleLevelSelectMenu() {
        puzzleLevelSelectMenuPanel.SetActive(true);
        selectedPuzzleMenuAnim.Play("SlideOut");
        puzzleLevelSelectMenuPanelAnim.Play("SlideIn");
        yield return new WaitForSeconds(1f);
        selectPuzzleMenuPanel.SetActive(false);
    }
}
