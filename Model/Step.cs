using System;
using System.Collections.Generic;
using System.Text;
using NodaTime;
using Npgsql.TypeHandlers;

namespace Lore_Buissnes_Rules_Service.Model
{
    class Step
    {
        long StepId;

        int StepType;

        string StepName;

        NodaTime.LocalDateTime StepCreateTime;

        NodaTime.LocalDateTime StepUpdateTime;

        UuidHandler StepUuid;

        bool StepIsActive;

        bool StepIsDeleted;
    }
}
