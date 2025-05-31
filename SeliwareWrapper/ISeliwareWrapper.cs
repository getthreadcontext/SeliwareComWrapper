using System;
using System.Runtime.InteropServices;

namespace SeliwareWrapper
{
    [ComVisible(true)]
    [Guid("11111111-1111-1111-1111-111111111111")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface ISeliwareWrapper
    {
        void Initialize();
        string Inject();
        string InjectWithPid(int pid);
        bool IsInjected();
        void Execute(string script);
        int GetClientsCount();
        string GetVersion();
    }
}