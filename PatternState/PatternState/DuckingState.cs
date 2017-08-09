using System;

namespace PatternState
{
    public class DuckingState : HeroineState
    {
        private int _chargeTime;

        public DuckingState()
        {
            _chargeTime = 0;
        }

        public override HeroineState HandleInput(Heroine heroine, Input input)
        {
            if (input.CurrentInput == USER_INPUT.RELESE_DOWN)
            {
                return new StandingState();
            }

            return null;
        }

        public override void Update(Heroine heroine)
        {
            _chargeTime++;

            if (_chargeTime >= 500)
            {
                // Используем способность
            }
        }
    }
}