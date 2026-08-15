using MunicipalServicesApp.Models;
using System.Collections.Generic;

namespace MunicipalServicesApp.Data
{
    public static class IssueRepository
    {
        public static List<Issue> Issues { get; } = new List<Issue>();
    }
}