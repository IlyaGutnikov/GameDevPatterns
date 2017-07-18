namespace PatternCommand
{
    public class FireCommand : Command
    {
        public override void Execute(GameActor _actor)
        {
            _actor.Fire();
        }
    }
}