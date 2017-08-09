namespace PatternState
{
    public class OnGroundState : HeroineState
    {
        public override HeroineState HandleInput(Heroine heroine, Input input)
        {
            if (input.CurrentInput == USER_INPUT.PRESS_B)
            {
                // Подпрыгиваем
                return null;
            }
            
            if (input.CurrentInput == USER_INPUT.PRESS_DOWN)
            {
                // Ложимся на землю
                return null;
            }

            return null;
        }
    }
}