using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using HarmonyLib;
using StardewValley;
using StardewValley.GameData.Tools;

namespace NermNermNerm.Stardew.QuestableTractor
{
    public class WatererQuestController
        : TractorPartQuestController<WatererQuestState>
    {
        public WatererQuestController(ModEntry mod) : base(mod) { }

        protected override WatererQuest CreatePartQuest() => new WatererQuest(this);

        protected override string QuestCompleteMessage => "Awesome!  You've now got a way to water your crops with your tractor!#$b#HINT: To use it, equip the watering can while on the tractor.";

        protected override string ModDataKey => ModDataKeys.WateringQuestStatus;

        public override string WorkingAttachmentPartId => ObjectIds.WorkingWaterer;

        public override string BrokenAttachmentPartId => ObjectIds.BustedWaterer;

        public override string HintTopicConversationKey => ConversationKeys.WatererNotFound;

        public override void AnnounceGotBrokenPart(Item brokenPart)
        {
            // We want to act a lot differently than we do in the base class, as we got the item through fishing, holding it up would look dumb
            Spout("Whoah that was heavy!  Looks like an irrigator attachment for a tractor under all that mud!");
        }

        protected override WatererQuestState AdvanceStateForDayPassing(WatererQuestState oldState)
        {
            if (oldState == WatererQuestState.WaitForMaruDay1)
            {
                Game1.player.mailForTomorrow.Add(MailKeys.WatererRepaired);
                return WatererQuestState.WaitForMaruDay2;
            }
            else
            {
                return oldState;
            }
        }

    }
}
