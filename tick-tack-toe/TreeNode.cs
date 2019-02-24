using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tick_tack_toe
{
    class TreeNode
    {
        public TickTackToeField TickTackToeField { get; set; }

        public List<TreeNode> ChildList { get; set; }

        public TreeNode(TickTackToeField tickTackToeField)
        {
            TickTackToeField = tickTackToeField;
            ChildList = new List<TreeNode>();
        }
    }
}
