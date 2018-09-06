using System;
using System.Collections.Generic;
using System.Text;

namespace SMP.ApplicationContext.Entity
{
    /// <summary>
    /// 日志
    /// </summary>
    public class Note:EntityBase
    {
        private Note()
        {

        }
        public Note(string dateNote)
        {
            DateNote = dateNote;
        }
        public string DateNote { get; set; }
    }
}
