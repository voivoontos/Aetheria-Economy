using System;
using System.Collections;
using System.Collections.Generic;
using MessagePack;
using Newtonsoft.Json;
using Unity.Mathematics;
using static Unity.Mathematics.math;

[InspectableField, MessagePackObject, JsonObject(MemberSerialization.OptIn), RuntimeInspectable]
public class LockWeaponData : InstantWeaponData
{
    [InspectableField, JsonProperty("speed"), Key(18), RuntimeInspectable]
    public PerformanceStat LockSpeed = new PerformanceStat();

    [InspectableField, JsonProperty("sensorImpact"), Key(19)]
    public PerformanceStat SensorImpact = new PerformanceStat();

    [InspectableField, JsonProperty("threshold"), Key(20), RuntimeInspectable]
    public PerformanceStat LockAngle = new PerformanceStat();

    [InspectableField, JsonProperty("directionImpact"), Key(21)]
    public PerformanceStat DirectionImpact = new PerformanceStat();

    [InspectableField, JsonProperty("decay"), Key(22)]
    public PerformanceStat Decay = new PerformanceStat();
    
    public override IBehavior CreateInstance(ItemManager context, Entity entity, EquippedItem item)
    {
        return new LockWeapon(context, this, entity, item);
    }
}

public class LockWeapon : InstantWeapon
{
    private LockWeaponData _data;
    private float _lock;
    private bool _locking;
    private Entity _target;

    public event Action OnLocked;
    public event Action OnBeginLocking;
    public event Action OnLockLost;

    public float LockSpeed { get; private set; }
    public float SensorImpact { get; private set; }
    public float LockAngle { get; private set; }
    public float DirectionImpact { get; private set; }
    public float Decay { get; private set; }

    public override float Progress => saturate(_cooldown > 0 ? _cooldown : _lock);

    public float Lock
    {
        get => saturate(_lock);
    }
    
    public LockWeapon(ItemManager context, LockWeaponData data, Entity entity, EquippedItem item) : base(context, data, entity, item)
    {
        _data = data;
    }

    public override bool Execute(float delta)
    {
        if (_target != Entity.Target.Value)
        {
            _lock = 0;
            _target = Entity.Target.Value;
        }

        if (Entity.Target.Value != null)
        {
            LockSpeed = Context.Evaluate(_data.LockSpeed, Item.EquippableItem, Entity);
            SensorImpact = Context.Evaluate(_data.SensorImpact, Item.EquippableItem, Entity);
            LockAngle = Context.Evaluate(_data.LockAngle, Item.EquippableItem, Entity);
            DirectionImpact = Context.Evaluate(_data.DirectionImpact, Item.EquippableItem, Entity);
            Decay = Context.Evaluate(_data.Decay, Item.EquippableItem, Entity);

            var degrees = acos(dot(normalize(Entity.Target.Value.Position - Entity.Position), normalize(Entity.LookDirection))) * 57.2958f;
            if (degrees < LockAngle)
            {
                var lerp = 1 - unlerp(0, 90, degrees);
                _lock = saturate(_lock + pow(lerp, DirectionImpact) * delta * LockSpeed);
            }
            else _lock = saturate(_lock - delta * Decay);
        }

        return base.Execute(delta);
    }

    public override void Activate()
    {
        if(_lock > .99f)
        {
            base.Activate();
        }
    }
}
