using UnityEngine;

public class MonsterStatus
{
    public string monstername { get; set; }

    public Element element { get; private set; }

    public float[] status { get; private set; } = new float[(int)StatusCategory.count];

    MonsterStatus(float[] statusvalue)
    {
        for (int i = 0; i <(int)StatusCategory.count; ++i)
        {
            status[i] = statusvalue[i];
        }
    }
}
