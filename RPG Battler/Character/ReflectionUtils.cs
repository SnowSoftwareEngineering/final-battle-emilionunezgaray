using System;
// This is also another example on how to use the requiremnt Reflection/Attributes. It does not interfere with the code
namespace RPG_Battler.Character;

public static class ReflectionUtils
{
     public static void PrintHeroMetadata(Type heroType)
    {
        var attributes = heroType.GetCustomAttributes(typeof(HeroAttribute), false);
        foreach (HeroAttribute attr in attributes)
        {
            Console.WriteLine($"Hero Description: {attr.Description}");
        }
    }
}
