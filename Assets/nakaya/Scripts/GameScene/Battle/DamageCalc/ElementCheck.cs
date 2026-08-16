using UnityEngine;

public static class ElementCalculator
{
    public static bool elementbonus(Element attack, Element defense)
    {
        return (attack, defense) switch
        {
            (Element.red, Element.green) => true,
            (Element.green, Element.blue) => true,
            (Element.blue, Element.red) => true,
            _ => false
        };
    }
}
