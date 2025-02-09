using System;
using System.Collections.Generic;

using static NermNermNerm.Stardew.LocalizeFromSource.SdvLocalize;

namespace NermNermNerm.Stardew.QuestableTractor
{
    public static class MailKeys
    {
        public const string BuildTheGarage = "QuestableTractor.BuildTheGarage";
        public const string FixTheEngine = "QuestableTractor.FixTheEngine";
        public const string WatererRepaired = "QuestableTractor.WatererRepaired";
        public const string GeorgeSeederMail = "QuestableTractor.GeorgeSeederMail";
        public const string EvelynPointsToAlex = "QuestableTractor.EvelynPointsToAlex";
        public const string HaleysWorkIsDone = "QuestableTractor.HaleysWorkIsDone";
        public const string AlexThankYouMail = "QuestableTractor.AlexThankYouMail";
        public const string TractorDoneMail = "QuestableTractor.TractorDoneMail";
        public const string LinusFoundShoes = "QuestableTractor.LinusFoundShoes";
        public const string DistanceShifterMail = "QuestableTractor.DistanceShifterMail";

        public static void EditAssets(IDictionary<string, string> mailItems)
        {
            mailItems[MailKeys.BuildTheGarage] = SdvMail($"Hey there!^I talked with Sebastian about your tractor and he has agreed to work on it, but only if he's got a decent place to work.  I understand that you're just starting out here and don't have a lot of money laying around, so I'm willing to do it at-cost.^ ^For my part, I'll need 300 wood, 200 stone and 350g for supplies.  Sebastian insisted that you bring a cup of coffee as well.  He's still a bit surly I think.  I caved on that one; gotta pick your battles.^ ^See you soon!^  - Robin[#]Build the garage");
            mailItems[MailKeys.FixTheEngine] = SdvMail($"I got everything working except this engine.  I've never seen anything like it.  I mean, it's like it doesn't even need gas!^I don't know what you're gonna need to do to make it work, but I know I'm out of my area here.^If you manage to figure it out, bring it back up to my place and I'll see about getting it installed.^  - Sebastian%item object {ObjectIds.BustedEngine} 1%%[#]Wonky engine");
            mailItems[MailKeys.WatererRepaired] = SdvMail($"Thanks for letting me work on this!  I even let my Dad do some of the work on it so that he got to feel like maybe he finally did make good on his promise to your Granddad all those years ago.  But me, well, I just like gadgets!  If it ever breaks down, let me know, I have a 10-year warranty on all my work :)%item object {ObjectIds.WorkingWaterer} 1%%[#]Irrigator is fixed");
            mailItems[MailKeys.GeorgeSeederMail] = SdvMail($"I hear you're restoring that old tractor.  Here's the seeder - it spreads fertilizer and seeds.  Your Grandpa gave it to me to fix after he decided to try going organic and put chicken droppings in it. I got it cleaned up, but it needed some iron bars.  Your Grandpa took his time rounding those up, and, well, my accident and his decline put an end to it.  But you're young, you can find somebody to fix it. I'm too old to be of any use anymore.%item object {ObjectIds.BustedSeeder} 1%%[#]Seeder from George");
            mailItems[MailKeys.EvelynPointsToAlex] = SdvMail($"Hello Dear,^I gave what you said a lot of thought and I think I have a way.  George would be really uncomfortable with you doing work he would want to do.^But George has had to get used to letting Alex do a lot of things for him already.^I talked to Alex about it, but he is reluctant and he wouldn't say why.  Maybe if someone nearer his own age, who he trusted, talked to him he would come around.^Good luck!^ - Granny");
            mailItems[MailKeys.HaleysWorkIsDone] = SdvMail($"@ - I think you'll find Alex is a little more... inspired... today.^ - Haley[#]Haley has motivated Alex");
            mailItems[MailKeys.AlexThankYouMail] = SdvMail($"Hey!^Grandpa and I got the seeder working last night!  You can pick it up from Grandpa whenever.  Now that it's done, I'm really happy you rooked me into doing this. I really love my grandpa, and well, sometimes it's hard to find things to do together.  And hey, maybe if the Gridball thing doesn't work out I can get a job repairing farm equipment!^ - Your friend,^   Alex[#]Waterer is ready");
            mailItems[MailKeys.TractorDoneMail] = SdvMail($"The tractor's all ready to go!  It was kinda strange, I didn't really know how it all attached, but when I tried to plug something into the wrong place, it just wouldn't go.  Screws wouldn't find their threads, belts would jump off of pullies...^ ^But when I got a part even near the right spot, it'd just jump into place!  So I guess that engine really likes being in that tractor!^ ^Oh and the tiller was on the tractor when we found it.  It seems okay, so you'll be able to hoe areas.  The other attachments are probably around someplace!^ ^ - M^ ^HINT: To use the tractor, get on it and select your hoe.[#]Tractor is ready to go");
            mailItems[MailKeys.LinusFoundShoes] = SdvMail($"I found shoes in the garbage last night.  You're right, these are perfectly good shoes, ready for a second life!  I hope you give them a good home.%item object {ObjectIds.AlexesOldShoe} 1%%[#]Linus found shoes");
            mailItems[MailKeys.DistanceShifterMail] = SdvMail($"Hey @!  Maru here!  I forgot to tell you something about your tractor!  There's a knob down by your left knee that you can use to widen or narrow the spread of your tools!  It works well to go narrow, but the wide setting is really fiddly.  I'm sure you'll get the hang of it with practice!^ - M^ ^(Hint - use the keypad plus and minus keys to increase or decrease the area of effect of your tools.  The max area is 3x3 until you get farming skill of 10, when it goes to 5x5.)[#]Tractor Tool Shift Knob HowTo");
        }
    }
}
