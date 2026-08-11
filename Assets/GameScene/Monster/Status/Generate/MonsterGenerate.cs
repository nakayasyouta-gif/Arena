using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterGenerate:MonoBehaviour
{
    [SerializeField]
    BaseStatusManager statusManager;
    [SerializeField]
    ConditionManager conditionManager;
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("ƒV[ƒ“‚ª“Ç‚İ‚Ü‚ê‚½I");
        if (scene.name == "ArenaScene")
        {
            int monstertype = Random.Range(0, statusManager.Statuss.Length - 1);
            int conditiontype = Random.Range(0, conditionManager.conditionBonuss.Length - 1);
            StatusGenerate.GenStatus(statusManager.Statuss[monstertype], conditionManager.conditionBonuss[conditiontype]);
        }
    }
}

