using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour, IStats
{
    [field: SerializeField] public BaseStat BaseStat { get; set; }
}