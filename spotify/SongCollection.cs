using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal class SongCollection : iPlayable
    {
        public string Title;
        private List<iPlayable> playables;

        public SongCollection(string songcollection)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
        public List<iPlayable> ShowPlayables()
        {
            return playables;
        }
    }
}
