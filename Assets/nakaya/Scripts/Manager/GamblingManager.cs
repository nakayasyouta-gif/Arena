using UnityEngine;

public class GamblingManager : MonoBehaviour
{

    WinRateManager winRateManager;

    [SerializeField] 
    MonsterManager monsterManager;

    public BetManager betManager {  get; private set;}
    public void Start()
    {
        winRateManager = new WinRateManager(monsterManager);
        betManager = new BetManager(winRateManager);
    }
}
