using System;

namespace NermNermNerm.Stardew.QuestableTractor
{
    public record struct ScytheQuestState
    {
        public ScytheQuestState() { }

        public ScytheQuestStateProgress Progress { get; init; } = ScytheQuestStateProgress.NoCluesYet;
        public bool JasTradeKnown { get; init; }
        public bool VincentTradeKnown { get; init; }
        public bool JasPartGot { get; init; }
        public bool VincentPartGot { get; init; }


        public override string ToString() => FormattableString.Invariant($"{this.Progress},{this.JasTradeKnown},{this.VincentTradeKnown},{this.JasPartGot},{this.VincentPartGot}");

        public static bool TryParse(string s, out ScytheQuestState fullState)
        {
            string[] splits = s.Split(',');
            if (splits.Length != 5
                || Enum.TryParse(splits[0], out ScytheQuestStateProgress progress))
            {
                fullState = default;
                return false;
            }

            bool[] flags = new bool[splits.Length - 1];
            for (int i = 1; i < splits.Length; i++)
            {
                if (!bool.TryParse(splits[i], out flags[i - 1]))
                {
                    fullState = default;
                    return false;
                }
            }

            fullState = new ScytheQuestState
            {
                Progress = progress,
                JasTradeKnown = flags[0],
                VincentTradeKnown = flags[1],
                JasPartGot = flags[2],
                VincentPartGot = flags[3]
            };
            return true;
        }
    }

    public enum ScytheQuestStateProgress
    {
        NotStarted,
        NoCluesYet,
        MissingParts,
        JasAndVincentFingered,
        InstallPart,
        Complete,
    }
}
