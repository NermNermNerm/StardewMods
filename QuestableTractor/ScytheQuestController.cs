using System;
using StardewModdingAPI;
using StardewValley.TerrainFeatures;

namespace NermNermNerm.Stardew.QuestableTractor
{
    public class ScytheQuestController : TractorPartQuestController<ScytheQuestState>
    {
        public ScytheQuestController(ModEntry mod) : base(mod) { }

        protected override ScytheQuest CreatePartQuest() => new ScytheQuest(this);

        public override string WorkingAttachmentPartId => ObjectIds.WorkingScythe;
        public override string BrokenAttachmentPartId => ObjectIds.BustedScythe;
        public override string HintTopicConversationKey => ConversationKeys.ScytheNotFound;
        protected override string QuestCompleteMessage => "Sweet!  You've now got a harvester attachment for your tractor!#$b#HINT: To use it, equip the scythe while on the tractor.";
        protected override string ModDataKey => ModDataKeys.ScytheQuestStatus;
        protected override void HideStarterItemIfNeeded() => base.PlaceBrokenPartUnderClump(ResourceClump.hollowLogIndex);


        protected override ScytheQuestState AdvanceStateForDayPassing(ScytheQuestState oldState) => oldState;

        protected override bool TryParse(string rawState, out ScytheQuestState result) => ScytheQuestState.TryParse(rawState, out result);
    }
}
