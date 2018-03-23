using Ryujinx.Core.OsHle.Ipc;
using System.Collections.Generic;

namespace Ryujinx.Core.OsHle.Services.Apm
{
    class ISession : IpcService
    {
        private Dictionary<int, ServiceProcessRequest> m_Commands;

        public override IReadOnlyDictionary<int, ServiceProcessRequest> Commands => m_Commands;

        public ISession()
        {
            m_Commands = new Dictionary<int, ServiceProcessRequest>()
            {
                { 0, SetPerformanceConfiguration }
            };
        }

        public long SetPerformanceConfiguration(ServiceCtx Context)
        {
            int PerfMode   = Context.RequestData.ReadInt32();
            int PerfConfig = Context.RequestData.ReadInt32();

            return 0;
        }
    }
}