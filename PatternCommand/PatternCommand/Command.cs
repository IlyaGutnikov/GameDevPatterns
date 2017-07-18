namespace PatternCommand
{
    public class Command
    {
        public virtual void Execute(GameActor _actor)
        {
            
        }
        
        /// <summary>
        /// Отмена команды
        /// </summary>
        public virtual void Undo()
        {
            
        }
    }
}