using RimWorld;
using RimWorld.Planet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using VFECore;
using static UnityEngine.Scripting.GarbageCollector;
using Ability = VFECore.Abilities.Ability;

namespace DourJoseph.VPEBalanced.Archon
{
    public class Ability_MindBreak : Ability
    {
        public override void Cast(params GlobalTargetInfo[] targets)
        {
            if (targets[0].Thing is Pawn dest)
            {
                dest.health.AddHediff(VPEB_DefOf.VPEB_DominatedMind);
            }
        }
    }
}