namespace PatternSandBox
{
    public class SkyLaunch : Superpower
    {
        protected override void Activate()
        {
            // Игрушки в песочнице
            Move();
            SoundPlayer.PlaySound();
            
            base.Activate();
        }
    }
}