using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game;
using WindowsFormsApp1;

namespace Game_club
{
    public partial class frmGameClub : Form
    {
        public frmGameClub()
        {
            InitializeComponent();
        }

        Form frmGame;

        Form _GetForm(Guna2ImageButton ibtn)
        {
            if(ibtn==null)
            {
                return null;
            }

            if (ibtn == ibtnRockPaperScissor)
                return new WindowsFormsApp1.frmMain();
            else if (ibtn == ibtnTicTacToe)
                return new frmTicTacToe();
            else if (ibtn == ibtnMemoryGame)
                return new Memory_Game.Form1();
            else if(ibtn == ibtnTypingClub)
                return new Typing_Club.frmMain();


            return null;
        }

        private void ibtn_Click(object sender, EventArgs e)
        {
            frmGame=_GetForm((Guna2ImageButton)sender);
            if(frmGame!=null)
                frmGame.ShowDialog();
        }

        private void cbtnSocialLink_Click(object sender, EventArgs e)
        {
            Guna2CircleButton cbtn = sender as Guna2CircleButton;
            System.Diagnostics.Process.Start(cbtn.Tag.ToString());
        }
    }
}
