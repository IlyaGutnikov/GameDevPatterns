namespace PatternCommand
{
    public enum gamepad_buttons
    {
        BUTTON_X,
        BUTTON_Y,
        BUTTON_A,
        BUTTON_B
    }
    
    public class InputHandler
    {
        private Command _buttonX;
        private Command _buttonA;
        
        public Command handleInput()
        {
            if (isPressed(gamepad_buttons.BUTTON_A))
            {
                return _buttonA;
            }
            if (isPressed(gamepad_buttons.BUTTON_X))
            {
                return _buttonX;
            }

            return null;
        }

        private bool isPressed(gamepad_buttons _button)
        {
            //Тело этого метода не важно
            
            return true;
        }
    }
}