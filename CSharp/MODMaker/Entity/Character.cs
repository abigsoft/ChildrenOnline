using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace MODMaker.Entity
{
    public class Character
    {
        public string? Thumb { get; set; }
        public string? Desc { get; set; }
        public List<State>? State { get; set; }

    }

    public class State
    {
        public string? Name { get; set; }
        public string? Position { get; set; }
        public XOM? Physical { get; set; }
        public int Play { get; set; }
        public XOM? Mood { get; set; }
        public List<Action>? Action { get; set; }
    }

    public class Action
    {
        public string? Img { get; set; }
        public int ShiftX { get; set; }
        public int ShiftY { get; set; }
        public int Time { get; set; }
        public int Sort { get; set; }
    }

    public class XOM
    {
        public int? max { get; set; }
        public string? min { get; set; }
    }

    
}
