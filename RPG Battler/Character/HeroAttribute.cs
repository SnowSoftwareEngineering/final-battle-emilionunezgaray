using System;
// this is just an example on how to use the requirement Reflection/Attributes. It does not interfere with the code.
namespace RPG_Battler.Character;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class HeroAttribute : Attribute
{
    public string Description {get;}
    public HeroAttribute(string description)
    {
        Description = description;
    }
}
