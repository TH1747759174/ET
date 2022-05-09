namespace ET
{
    public static class ComputerSystem
    {
        public static void Start(this Computer self)
        {
            self.GetComponent<PcCaseComponent>().StartPower();
            self.GetComponent<MonitorsComponent>().Display();

            Log.Debug("Computer Start!!!!!!");
        }
    }
}
