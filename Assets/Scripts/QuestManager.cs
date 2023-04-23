using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    int currentStage = 0; // ステージの進行度
    public void OnNextButton()
    {
        currentStage++;
        Debug.Log("進行度増加"+ currentStage);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
