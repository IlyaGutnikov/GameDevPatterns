namespace PatternCommand
{
    public class Game
    {
        private InputHandler inputHandler;
        private GameActor player;
        /// <summary>
        /// Будем считать, что пишем под Юнити
        /// </summary>
        public void Update()
        {
            Command command = inputHandler.handleInput();

            if (command != null)
            {
                command.Execute(player);
            }
        }
    }
}