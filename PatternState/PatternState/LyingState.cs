namespace PatternState
{
    public class LyingState : OnGroundState
    {
        public override HeroineState HandleInput(Heroine heroine, Input input)
        {
            // Пример иерархических состояний
            if (input.CurrentInput == USER_INPUT.RELESE_DOWN)
            {
                // Встаем
            }
            else
            {
                base.HandleInput(heroine, input);
            }
        }
    }
}