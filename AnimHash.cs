using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AnimHash
{
    public static readonly int HealerWalk = Animator.StringToHash("HealerIsWalk");
    public static readonly int HealerHeal = Animator.StringToHash("IsHealing");
    public static readonly int HealerDie = Animator.StringToHash("HealerDie");


    public static readonly int WitchWalk = Animator.StringToHash("WitchIsWalk");
    public static readonly int WitchDie = Animator.StringToHash("WitchDie");
    //public static readonly int WitchWalk = Animator.StringToHash("WitchIsWalk");

    public static readonly int KnightWalk = Animator.StringToHash("KnightIsWalk");
    public static readonly int KnighAttack = Animator.StringToHash("KnightIsAttack");
    public static readonly int KnightDie = Animator.StringToHash("KnightDie");

    public static readonly int SuperheroWalk = Animator.StringToHash("SuperIsWalk");
    public static readonly int SuperheroAttack = Animator.StringToHash("SuperIsAttack");
    public static readonly int SuperheroDie = Animator.StringToHash("SuperDie");
    public static readonly int SuperheroPushBox = Animator.StringToHash("IsPushBox");
}
