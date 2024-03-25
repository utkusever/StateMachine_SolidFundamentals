using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "BaseStat", menuName = "Stat", order = 0)]
public class BaseStat : ScriptableObject
{
   public float health;
   public float speed;
   public float damage;
}