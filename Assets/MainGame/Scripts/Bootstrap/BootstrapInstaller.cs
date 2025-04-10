using MainGame.Scripts.FSM;
using UnityEngine;
using Zenject;

public class BootstrapInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        RegisterServices();
    }

    private void RegisterServices()
    {
        Container.Bind<InputSystem>().FromNew().AsSingle();
        Container.Bind<FSM>().FromNew().AsSingle();
    }
}
