namespace VPE_Balanced.Archon
{
    using RimWorld;
    using RimWorld.Planet;
    using UnityEngine;
    using Verse;
    using Ability = VFECore.Abilities.Ability;

    public class Ability_MindBreak : Ability
    {
        public override void Cast(params GlobalTargetInfo[] targets)
        {
            base.Cast(targets);
            if (targets[0].Thing is not Pawn source || targets[1].Thing is not Pawn dest) return;
            mote.Attach(source, dest);
            dest.health.AddHediff(VPE_DefOf.VPE_UnLucky);
        }
    }
}