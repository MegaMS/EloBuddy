﻿using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;

using Settings = AddonTemplate.Config.Modes.Flee;

namespace AddonTemplate.Modes
{
    public sealed class Flee : ModeBase
    {
        public override bool ShouldBeExecuted()
        {
            // Only execute this mode when the orbwalker is on flee mode
            return Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.Flee);
        }

        public override void Execute()
        {
            if (Config.Modes.Combo.UseW)
            {
                var target = TargetSelector.GetTarget(W.Range, DamageType.Physical);
                if (W.IsReady() && target != null)
                {
                    W.Cast();
                }
            }

        }
    }
}
