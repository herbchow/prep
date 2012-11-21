using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prep.gemskata
{
    public class GemBlocks
    {
        public int width;
        public int height;
        public static GemBlocks OneByOne = new GemBlocks{width=1,height=1};
        public static GemBlocks OneByTwo = new GemBlocks{width=1,height=2};
        public static GemBlocks OneByThree = new GemBlocks { width = 2, height = 1 };
    }
}
