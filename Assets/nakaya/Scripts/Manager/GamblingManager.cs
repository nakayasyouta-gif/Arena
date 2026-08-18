using UnityEngine;

public class GamblingManager : MonoBehaviour
{

    

    [SerializeField] 
    MonsterManager monsterManager;
    public WinRateManager winRateManager {  get; private set; }

    public BetManager betManager {  get; private set;}
    public void initialise()
    {
        winRateManager = new WinRateManager(monsterManager);
        betManager = new BetManager(winRateManager);
    }
}
