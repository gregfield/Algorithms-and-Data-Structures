using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TowersOfHanoi
{
    public class HanoiDisplay
    {
        PictureBox[] disks;
        TowerStack[] poles;

        public HanoiDisplay(PictureBox[] startDisks, PictureBox pole1, PictureBox pole2, PictureBox pole3)
        {
            // Standard array copy issue
            disks = new PictureBox[Constants.MaxDisks];

            for (int i = 0; i < Constants.MaxDisks; i++)
                disks[i] = startDisks[i];

	        poles = new TowerStack[Constants.NPoles];			// Tower of Hanoi has three poles

	        poles[0] = new TowerStack(pole1);
	        poles[1] = new TowerStack(pole2);
	        poles[2] = new TowerStack(pole3);
        }

        // Moves the image at the top of the sourcePole to the top of the DestPol
        // via the push and pop commands of the corresponding TowerStack instances
        // Base case action for the recursive sole algorithm.
        internal void MoveTopDisk(int sourcePole, int destPole)
        {
            PictureBox tempDisk;

            // Just check here in case something weird has happened...
            if ((sourcePole >= 0) && (destPole >= 0) && (sourcePole <= Constants.NPoles) && (destPole <= Constants.NPoles))
            {
                // The poles are held in a 0-indexed array, but referred to by 1-indexed numbers
                // Not ideal.Hence the -1 in the indices.
                tempDisk = poles[sourcePole - 1].Pop();
                poles[destPole - 1].Push(tempDisk);
            }
        }

        // Prepare initial display
        public void SetUp(int nDisks)
        {
            for (int i = 0; i < 3; i++)
                poles[i].Clear();

            for (int i = nDisks - 1; i >= 0; i--)
            {
                poles[0].Push(disks[i]);
                disks[i].Visible = true;
                disks[i].Refresh();
            }
        }
    }
}
