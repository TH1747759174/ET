

namespace ET
{
    public class AppStartInitFinish_CreateLoginUI : AEvent<EventType.AppStartInitFinish>
    {
        protected override async void Run(EventType.AppStartInitFinish args)
        {
            UIHelper.Create(args.ZoneScene, UIType.UILogin, UILayer.Mid).Coroutine();

            Computer computer = args.ZoneScene.AddChild<Computer>();

            computer.AddComponent<PcCaseComponent>();
            computer.AddComponent<MonitorsComponent>();
            computer.AddComponent<KeyBoardComponent>();
            computer.AddComponent<MouseComponent>();
            computer.Start();
            await TimerComponent.Instance.WaitAsync(2000);
            computer.Dispose();
        }
    }
}
