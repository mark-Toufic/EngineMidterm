using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public abstract string Name { get; }

    public abstract GameObject Create(GameObject prefab);
}

public class Crab : Enemy
{
    public override string Name => "crab";

    public override GameObject Create(GameObject prefab)
    {
        GameObject enemy = Instantiate(prefab);
        Debug.Log("crab enemy is created");
        return enemy;
    }
}

public class Monster : Enemy
{
    public override string Name => "bee";

    public override GameObject Create(GameObject prefab)
    {
        GameObject enemy = Instantiate(prefab);
        Debug.Log("bee enemy is created");
        return enemy;
    }
}
