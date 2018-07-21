﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.DAL.Entities
{
    public class TaskListPriority
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum TaskListPriorityEnum
    {
        Высокий=1,
        Средний=2,
        Низкий=3
    }
}
