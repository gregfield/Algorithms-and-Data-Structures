using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowersOfHanoi
{
    // Used to place, display and hide the images on an individual pole
    public class TowerStack
    {
        const int DISK_WIDTH = 90;

	    PictureBox pole;
	    int top;
	    Point[] locations;
	    PictureBox[] disks;

	    public TowerStack(PictureBox startPole)
        {
            // Primary work: Set up data structures and locations for the images

            pole = startPole;
	        top = 0;

            int maxDisks = Constants.MaxDisks;

            disks = new PictureBox[maxDisks];
            for (int i = 0; i < maxDisks; i++)
		        disks[i] = null;

            locations = new Point[maxDisks];

	        int poleWidth = pole.Width;
	        int poleHeight = pole.Height;
            int heightInc = poleHeight / maxDisks;
	        int poleBase = pole.Top + poleHeight;

            for (int i = 0; i < maxDisks; i++)
	        {
		        locations[i].X = pole.Left + (poleWidth/2);
		        locations[i].Y = poleBase - (heightInc * (i+1));
	        }
        } // end ctor
        
        // Add a disk image to the top of the stack, keeping them centred
        public void Push(PictureBox pushImage)
        {
            Point newPos = locations[top];
            
            int imageWidth = pushImage.Width;
	        int adjustment = imageWidth/2;

	        pushImage.Left = newPos.X - adjustment;
	        pushImage.Top = newPos.Y;

	        disks[top] = pushImage;
	        top++;
        }
        
        // Remove the top image from the stack
        public PictureBox Pop()
        {
            top--;
            return disks[top];
        }
        
        // Utility methods
        public bool IsEmpty()
        {
            if (top == 0)
                return true;
            else
                return false;
        }
        public void Clear()
        {
            top = 0;
        }
    } // end class TowerStack
}
