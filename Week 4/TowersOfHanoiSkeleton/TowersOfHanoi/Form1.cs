using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowersOfHanoi
{
    public partial class Form1 : Form
    {
        HanoiDisplay globalHanoiDisplay;
	    PictureBox[] pictureBoxArray;
        PictureBox[] poleArray;

        const int MAX_DISKS = 8;
        const int N_POLES = 3;

        public Form1()
        {
            InitializeComponent();
        }

        //============================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxArray = new PictureBox[MAX_DISKS];
		    poleArray = new PictureBox[N_POLES];
				
            // Dynamically create pictureBoxes to hold the disk images.
		    for (int i=0; i<MAX_DISKS; i++)
		    {
                pictureBoxArray[i] = new PictureBox();
			    pictureBoxArray[i].Location = new Point(100, i*30 + 10);
			    pictureBoxArray[i].Name = "pictureBox" + Convert.ToString(i);
			    String fileName = "../../images/Disk" + Convert.ToString(i+1) + ".bmp";
			    pictureBoxArray[i].Image = Image.FromFile( fileName );
			    pictureBoxArray[i].Visible = false;
			    pictureBoxArray[i].SizeMode = PictureBoxSizeMode.AutoSize;
			    Controls.Add(pictureBoxArray[i]);
			 }

            // Dynamically create pictureBoxes to hold the poles
            for (int i=0; i<3; i++)
            {
                poleArray[i] = new PictureBox();
				poleArray[i].Location = new Point((i+1)*200, 150);
				poleArray[i].Name = "poleShape" + Convert.ToString(i+1);				
                poleArray[i].Image = Image.FromFile( "../../images/poleImage.bmp" );
				poleArray[i].SizeMode = PictureBoxSizeMode.AutoSize;
                poleArray[i].Visible = true;
			    Controls.Add(poleArray[i]);
            }

            // The main HanoiDisplay object takes an array of disks and the three poles individually.
            // This seems weird, but maps logically to the solution algorithm
            globalHanoiDisplay = new HanoiDisplay(pictureBoxArray,poleArray[0], poleArray[1], poleArray[2]);
        }

        //============================================================================
        // Used to slow the animation down
        //============================================================================
        void Pause(int msecs)
		{
            Refresh();  // Repaints the Form and its controls
            System.Threading.Thread.Sleep(msecs);
		}

        //============================================================================
        // Engine method given to the Form just for simplicity in classroom exercise
        //============================================================================
        void solveTowers(int nDisks, int sourcePole, int destPole, int auxPole)
        {
            if(nDisks == 1)
            {
                globalHanoiDisplay.MoveTopDisk(sourcePole, destPole);
                Pause(500);
            }
            else
            {
                solveTowers(nDisks - 1, sourcePole, auxPole, destPole);
                Pause(500);
                globalHanoiDisplay.MoveTopDisk(sourcePole, destPole);
                Pause(500);
                solveTowers(nDisks - 1, auxPole, destPole, sourcePole);
                Pause(500);
            }
	    }

        // Launch
        private void btnPlay_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt16(txtSize.Text);
            globalHanoiDisplay.SetUp(size);
            Pause(500);
            
            solveTowers(size, 1, 3, 2);
        }

    }
}
