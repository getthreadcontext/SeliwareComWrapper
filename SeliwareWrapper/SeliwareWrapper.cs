using System;
using System.Runtime.InteropServices;
using SeliwareAPI;

namespace SeliwareWrapper
{
    [ComVisible(true)]
    [Guid("22222222-2222-2222-2222-222222222222")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("SeliwareWrapper.SeliwareWrapper")]
    public class SeliwareWrapper : ISeliwareWrapper
    {
        public void Initialize()
        {
            try
            {
                Seliware.Initialize();
            }
            catch (Exception ex)
            {
                throw new COMException($"Failed to initialize: {ex.Message}");
            }
        }

        public string Inject()
        {
            try
            {
                return Seliware.Inject();
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public string InjectWithPid(int pid)
        {
            try
            {
                return Seliware.Inject(pid);
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public bool IsInjected()
        {
            try
            {
                return Seliware.IsInjected();
            }
            catch
            {
                return false;
            }
        }

        public void Execute(string script)
        {
            try
            {
                Seliware.Execute(script);
            }
            catch (Exception ex)
            {
                throw new COMException($"Execution failed: {ex.Message}");
            }
        }

        public int GetClientsCount()
        {
            try
            {
                return Seliware.GetClientsCount();
            }
            catch
            {
                return 0;
            }
        }

        public string GetVersion()
        {
            try
            {
                return Seliware.GetVersion();
            }
            catch
            {
                return "Unknown";
            }
        }
    }
}