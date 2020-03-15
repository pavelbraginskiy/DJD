using Godot;
using System;

public class SlimeBasic : Enemy{
    public SlimeBasic(Vector2 _position, Vector2 _moveAreaStart, Vector2 _moveAreaEnd) : base(_position, _moveAreaStart, _moveAreaEnd){
        maxEnergy = 100f;
        curEnergy = 100f;
        maxHealth = 100f;
        curHealth = 100f;
        knockbackCutoff = 4f;
        knockbackDeceleration = 5f;
        acceleration = 4f;
        maxVelocity = 25f;

        // Children
        sprite.Frames = ResourceLoader.Load("res://entities/enemies/slime_basic/SlimeBasic.tres") as SpriteFrames;
        ChangeState(EEnemyState.STATE_IDLE);
    }

    public override void _Process(float delta){
        base._Process(delta);
    }
}
