using StardewValley;

namespace NermNermNerm.Stardew.QuestableTractor
{
    internal class SeederQuestController
        : TractorPartQuestController<SeederQuestState>
    {
        public SeederQuestController(ModEntry mod) : base(mod) { }

        protected override SeederQuestState AdvanceStateForDayPassing(SeederQuestState oldState)
        {
            if (oldState == SeederQuestState.WaitForAlexDay1)
            {
                Game1.player.mailForTomorrow.Add(MailKeys.AlexThankYouMail);
            }

            return oldState switch
            {
                SeederQuestState.WaitForEvelyn => SeederQuestState.TalkToAlex1,
                SeederQuestState.WaitForHaleyDay1 => SeederQuestState.TalkToAlex2,
                SeederQuestState.WaitForAlexDay1 => SeederQuestState.WaitForAlexDay2,
                SeederQuestState.WaitForAlexDay2 => SeederQuestState.GetPartFromGeorge,
                _ => oldState
            };
        }

        protected override SeederQuest CreatePartQuest() => new SeederQuest(this);

        protected override string QuestCompleteMessage => "Awesome!  You've now got a way to plant and fertilize crops with your tractor!#$b#HINT: To use it, equip seeds or fertilizers while on the tractor.";

        protected override string ModDataKey => ModDataKeys.SeederQuestStatus;

        public override string WorkingAttachmentPartId => ObjectIds.WorkingSeeder;

        public override string BrokenAttachmentPartId => ObjectIds.BustedSeeder;

        public override string HintTopicConversationKey => ConversationKeys.SeederNotFound;

        protected override void HideStarterItemIfNeeded()
        {
            if (Game1.player.getFriendshipHeartLevelForNPC("George") >= SeederQuest.GeorgeSendsBrokenPartHeartLevel
                && this.Mod.RestoreTractorQuestController.IsComplete
                && !Game1.player.modData.ContainsKey(ModDataKeys.SeederQuestGeorgeSentMail))
            {
                Game1.player.mailbox.Add(MailKeys.GeorgeSeederMail);
                Game1.player.modData[ModDataKeys.SeederQuestGeorgeSentMail] = "sent";
            }
        }
    }
}
