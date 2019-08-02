using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bowling.Logic
{
    public class BowlingLogic2
    {
        public class Frame
        {
            public int Bowl1 { get; set; }
            public int Bowl2 { get; set; }
            public bool IsSpare { get; set; }
            public bool IsStrike{ get; set; }
        }                                                //write down the properties I want to focus on
        
        private List<Frame> Frames = new List<Frame>();                       //create a new List made of frames
        private const int TotalAllowedFrames = 10;                              //set two variables (max frames / index of last frame)
        private const int LastFrameIndex = 9;

        public void AddFrameScore(int bowl1, int bowl2)                                         // 1 -- (method to add score)
        {
            var frame = new Frame() {Bowl1 = bowl1, Bowl2 = bowl2};         //instance of a class (object) taken from Frame class
            frame.IsSpare = IsSpare(bowl1, bowl2);                          //exception: spare
            frame.IsStrike = IsStrike(bowl1);                               //exception: strike
            Frames.Add(frame);                                              //method to add each frame to the Frames list
        }
        private bool IsSpare(int bowl1, int bowl2)                                              //2 -- (boolean)
        {
            if ((bowl1 + bowl2 == 10) && bowl1 < 10)                         //if the sum of the bowls is 10 but the first bowl is not 10
                return true;

            return false;
        }

        private bool IsStrike(int bowl1)                                                        //3 -- (boolean)
        {
            if ((bowl1) == 10) //if the first bowl is 10
                return true;

            return false;
        }

        public int GetScore()                                                                   //4 -- (method to obtain score)
        {
            var total = 0;
            for (int currentFrameIndex = 0; currentFrameIndex < Frames.Count; currentFrameIndex++)
            {
                var frame = Frames[currentFrameIndex];

                if (currentFrameIndex < TotalAllowedFrames)
                {
                    total += frame.Bowl1;
                    total += frame.Bowl2;
                }
                
                if (frame.IsSpare)         
                {
                    var nextFrameIndex = currentFrameIndex + 1;
                    
                    if (nextFrameIndex < Frames.Count)             
                    {
                        var nextFrame = Frames[nextFrameIndex];
                        total += nextFrame.Bowl1;

                        if (currentFrameIndex == LastFrameIndex)
                        {
                            total += nextFrame.Bowl1;
                        }
                    }
                }

                if (frame.IsStrike)
                {
                    var nextFrameIndex = currentFrameIndex + 1;

                    if (nextFrameIndex < Frames.Count)
                    {
                        var nextFrame = Frames[nextFrameIndex];

                        total += nextFrame.Bowl1;
                        total += nextFrame.Bowl2;

                        if (nextFrame.IsStrike)
                        {
                            nextFrameIndex = nextFrameIndex + 1;

                            if (nextFrameIndex < Frames.Count)
                            {
                                nextFrame = Frames[nextFrameIndex];
                                total += nextFrame.Bowl1;
                                total += nextFrame.Bowl2;
                            }
                        }
                        
                        if (currentFrameIndex == LastFrameIndex)
                        {
                            total += nextFrame.Bowl1;
                            total += nextFrame.Bowl2;
                        }
                    }
                }

            }
            return total;
        }
    }
}
