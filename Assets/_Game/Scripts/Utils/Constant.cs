using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constant
{
    
}

namespace Game.Character.Animation
{
    public class AnimType
    {
        public const string IDLE = "idle";
        public const string WIN = "win";
        public const string RUN = "run";
        public const string ULTI = "ulti";
        public const string DANCE = "dance";
        public const string ATTACK = "attack";
        public const string DEAD = "dead";
    }
}

namespace Game.Character
{
    public class CharacterTag
    {
        public const string PLAYER = "Player";
        public const string ENEMY = "Enemy";
        public const string CHARACTER = "Character";
    }

    public class CharacterUtils
    {
        public const float ATTACK_DELAY_TIME = 1f;
    }
}

namespace Game.Weapons
{
    public class WeaponsUtils
    {
        public const string TAG = "Weapons";
    }
}
