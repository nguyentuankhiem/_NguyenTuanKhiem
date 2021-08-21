using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCoBan.Data
{
    public class TodoItem
    {
        public string Title { get; set; }
        public bool IsComplete { get; set; } = false;

        public TodoItem(string title)
        {
            this.Title = title;
        }
    }
}
