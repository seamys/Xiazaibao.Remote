using System.Collections.Generic;

namespace Xiazaibao.Remote.Models
{
    public class TaskListResult
    {
        public int RecycleNum { get; set; }

        public int ServerFailNum { get; set; }

        public int Rtn { get; set; }

        public int CompleteNum { get; set; }

        public int Sync { get; set; }

        public List<object> Tasks { get; set; }
        public int DlNum { get; set; }
    }
}