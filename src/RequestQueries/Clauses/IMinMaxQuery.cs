﻿using OScience.Common.RequestData;

namespace OScience.MaterialsProject.RequestQueries.Clauses
{
    public interface IMinMaxQuery
    {
        int? Max { get; }
        int? Min { get; }
    }
}