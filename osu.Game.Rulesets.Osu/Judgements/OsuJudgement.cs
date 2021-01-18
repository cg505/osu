// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Rulesets.Judgements;
using osu.Game.Rulesets.Scoring;

namespace osu.Game.Rulesets.Osu.Judgements
{
    public class OsuJudgement : Judgement
    {
        public override HitResult MaxResult => HitResult.Great;

        public override int NumericResultFor(JudgementResult result) => ToNumericResult(result.Type);

        public new static int ToNumericResult(HitResult result)
        {
            switch (result)
            {
                // Override Ok and Meh
                case HitResult.Meh:
                    return 100;

                case HitResult.Ok:
                    return 200;

                default:
                    return Judgement.ToNumericResult(result);
            }
        }

    }
}
