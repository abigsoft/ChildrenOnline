using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace CSharp.Entity
{
    public class Character
    {
        public string Thumb { get; set; } = string.Empty;
        public string Desc { get; set; } = string.Empty;
        public List<State> State { get; set; } = new List<State>();

    }

    public class State
    {
        public string Name { get; set; } = string.Empty;
        public int Position { get; set; } = 0;
        public XOM Physical { get; set; } = new XOM();
        public int Play { get; set; } = 0;
        public XOM Mood { get; set; } = new XOM();
        public List<Action> Action { get; set; } = new List<Action> { };
    }

    public class Action
    {
        public string Img { get; set; } = string.Empty;
        public int ShiftX { get; set; } = 0;
        public int ShiftY { get; set; } = 0;
        public int Time { get; set; } = 0;
        public int Sort { get; set; } = 0;
    }

    public class XOM
    {
        public int max { get; set; } = 0;
        public int min { get; set; } = 0;
    }

    
}
