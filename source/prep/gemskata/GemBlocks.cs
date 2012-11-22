namespace prep.gemskata
{
    public class GemBlocks
    {
        public int width;
        public int height;
        public static GemBlocks OneByOne = new GemBlocks {width = 1, height = 1};
        public static GemBlocks OneByTwo = new GemBlocks {width = 1, height = 2};
        public static GemBlocks TwoByOne = new GemBlocks {width = 2, height = 1};
    }

    public class GemBlockVariants
    {
        public static GemBlocks[] All = new[]
                                            {
                                                GemBlocks.OneByOne,
                                                GemBlocks.OneByTwo,
                                                GemBlocks.TwoByOne,
                                            };
    }
}
