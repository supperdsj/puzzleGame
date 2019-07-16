using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLevelScript : MonoBehaviour
{
    [SerializeField] GameObject selectPuzzleMenuPanel,puzzleLevelSelectMenuPanel;
    [SerializeField] Animator selectedPuzzleMenuAnim,puzzleLevelSelectMenuPanelAnim;
    string selectedPuzzle;

    void Awake() {
        selectPuzzleMenuPanel = GameObject.Find("SelectPuzzleMenuButtons");
        puzzleLevelSelectMenuPanel = GameObject.Find("PuzzleLevelSelectMenuPanel");
        selectedPuzzleMenuAnim = selectPuzzleMenuPanel.GetComponent<Animator>();
        puzzleLevelSelectMenuPanelAnim = puzzleLevelSelectMenuPanel.GetComponent<Animator>();
    }

    public void BackToPuzzleSelectMenu() {
        StartCoroutine(ShowPuzzleSelectMenu());
    }

    IEnumerator ShowPuzzleSelectMenu() {
        selectPuzzleMenuPanel.SetActive(true);
        selectedPuzzleMenuAnim.Play("SlideIn");
        puzzleLevelSelectMenuPanelAnim.Play("SlideOut");
        yield return new WaitForSeconds(1f);
        puzzleLevelSelectMenuPanel.SetActive(false);
    }
}
