using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise
{
    
    public class Game
    {
        public int energyLevel = 1;
        public int winningProb = 100;


        public void zeroSpin() { this.energyLevel =1; this.winningProb = 100; }

        public void firstSpin()

        {
            this.energyLevel +=1;
            this.winningProb += 10;
        }

        public void secondSpin() { this.energyLevel += 2; this.winningProb = +20; }
        public void thirdSpin () { this.energyLevel-= 3; this.winningProb -= 30; }

        public void fourthSpin () { this.energyLevel += 4; this.winningProb += 40; }

        public void fifthSpin() { this.energyLevel -= 5; this.winningProb -= 50; }


        public void sixthSpin() { this.energyLevel -=1; this.winningProb -= 60; }


        public void SevenSpin() { this.energyLevel += 1; this.winningProb -= 70; }


        public void EightSpin() { this.energyLevel -= 2; this.winningProb -= 20; }

        public void NinthSpin() { this.energyLevel -= 3; this.winningProb -= 30; }

        public void TenthSpin() { this.energyLevel += 10; this.winningProb += 100; }

    }
}
