using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGGame
{
    public class ComputerGameAdapter :PCGame
    {
        private ComputerGame computerGame;

        public ComputerGameAdapter(ComputerGame computerGame)
        {
            this.computerGame = computerGame;
        }

        public int getPegiAllowedAge()
        {
            return (int)this.computerGame.getPegiAgeRating();
        }

        public Requirements getRequirements()
        {
            return new Requirements(this.computerGame.getMinimumGpuMemoryInMegabytes(),

                this.computerGame.getDiskSpaceNeededInGB(),
                this.computerGame.getRamNeededInGb(),
                this.computerGame.getCoreSpeedInGhz(),
                this.computerGame.getCoresNeeded()
                );
        }

        public string getTitle()
        {
            return this.computerGame.getName();
        }

        public bool isTripleAGame()
        {
            return this.computerGame.getBudgetInMillionsOfDollars() > 50;
        }
    }
}
