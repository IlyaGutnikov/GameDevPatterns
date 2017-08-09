namespace PatternState
{
    public class StandingState : HeroineState
    {
        public override HeroineState HandleInput(Heroine heroine, Input input)
        {
            if (input.CurrentInput == USER_INPUT.PRESS_DOWN)
            {
                return new DuckingState();
            }

            return null;
        }

        public override void Update(Heroine heroine)
        {
            base.Update(heroine);
        }
    }
}