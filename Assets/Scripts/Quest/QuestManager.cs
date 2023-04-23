using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public StageUIManager stageUI;
    public GameObject enemyPrefab;
    public BattleManager battleManager;
    public SceneTranstionManager sceneTranstionManager;

    //敵に遭遇するテーブル -1なら遭遇しない、0なら遭遇
    int[] encountTable = { -1, -1, 0, -1, 0,-1 };

    int currentStage = 0; // ステージの進行度

    public void OnNextButton()
    {
        currentStage++;
        //進行度をUIに反映
        stageUI.UpdateUI(currentStage);
        if (encountTable.Length <= currentStage)
        {
            QuestClear();
        }
        else if (encountTable[currentStage] == 0)
        {
            EncountEnemy();
        }
    }

    void EncountEnemy()
    {
        stageUI.ShowButtons(false);
        GameObject enemyObj = Instantiate(enemyPrefab);
        EnemyManager enemy = enemyObj.GetComponent<EnemyManager>();
        battleManager.Setup(enemy);
    }
    // Start is called before the first frame update
    void Start()
    {
        stageUI.UpdateUI(currentStage);
    }
    public void EndBattle()
    {
        stageUI.ShowButtons(true); ;
    }

    void QuestClear()
    {
        stageUI.ShowClerText();
    }
}
