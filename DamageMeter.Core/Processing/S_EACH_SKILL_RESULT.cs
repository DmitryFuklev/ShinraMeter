﻿using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tera.Game;

namespace DamageMeter.Processing
{
    internal class S_EACH_SKILL_RESULT
    {

        internal S_EACH_SKILL_RESULT(Tera.Game.Messages.EachSkillResultServerMessage message)
        {
            NetworkController.Instance.EntityTracker.Update(message);
            var skillResult = new SkillResult(message, NetworkController.Instance.EntityTracker, NetworkController.Instance.PlayerTracker,
                       BasicTeraData.Instance.SkillDatabase, BasicTeraData.Instance.PetSkillDatabase, NetworkController.Instance.AbnormalityTracker);
            DamageTracker.Instance.Update(skillResult);
            NotifyProcessor.UpdateMeterBoss(message);
        }
    }
}
