using System.Collections;
using System.Collections.Generic;
using Game.Scripts.Models.Health;
using UnityEngine;

public interface IEntity
{
    public int EntityId { get; set; }
    public IHealth Health { get; set; }
    
}