using UnityEngine;


public abstract class Buff : ScriptableObject {
    public int Amount;

    public abstract void Apply(Entity entity);

}
