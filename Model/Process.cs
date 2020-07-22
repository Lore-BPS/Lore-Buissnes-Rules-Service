using System;
using System.Collections.Generic;
using System.Text;
using NodaTime;
using Npgsql.TypeHandlers;

namespace Lore_Buissnes_Rules_Service
{
    class Process
    {
        long ProcessId;

        int ProcessType;

        string ProcessName;

        NodaTime.LocalDateTime ProcessCreateTime;

        NodaTime.LocalDateTime ProcessUpdateTime;

        UuidHandler ProcessUuid;

        bool ProcessIsActive;

        bool ProcessIsDeleted;

    }
}
