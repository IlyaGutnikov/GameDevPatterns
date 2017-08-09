namespace PatternState
{
    /// <summary>
    /// Ввод с геймпада
    /// </summary>
    public class Input
    {
        public USER_INPUT CurrentInput;
    }

    public enum USER_INPUT
    {
        RELESE_DOWN,
        PRESS_DOWN
    }
}