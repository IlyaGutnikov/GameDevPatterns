namespace PatternCommand
{
    public class JumpCommand : Command
    {
        public override void Execute(GameActor _actor)
        {
            _actor.Jump();
            
        }
    }
}