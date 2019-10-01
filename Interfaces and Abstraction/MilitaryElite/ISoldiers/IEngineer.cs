﻿namespace MilitaryElite.ISoldiers
{
    using MilitaryElite.Soldiers;
    using System.Collections.Generic;

    public interface IEngineer
    {
        List<Repair> Repairs { get; set; }
    }
}