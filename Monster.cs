﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Unit {
    protected virtual void Awake() { }
    protected virtual void Start() { }
    protected virtual void Update() { }

    protected virtual void OnTriggerEnter2D(Collider2D collider)
    {
        Bullet bullet = collider.GetComponent<Bullet>();

        if (bullet)
        {
            ReceiveDemage();
        }

        PlatformerCharacter2D character = collider.GetComponent<PlatformerCharacter2D>();

        if (character)
        {
            character.ReceiveDemage();
        }
    }
}
