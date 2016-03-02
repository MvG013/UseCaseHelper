using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseHelper
{
    public partial class Form1 : Form
    {
        List<DrawActor> drawactors = new List<DrawActor>();
        List<DrawUsecase> drawusecase = new List<DrawUsecase>();
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.X < 200 && rbActor.Checked && rbCreate.Checked)
            {
                int amount = drawactors.Count;
                if (amount < 3)
                {
                    string Actornaam = input("Wat is de naam van de actor?");
                    DrawActor nieuw = new DrawActor(e.X, e.Y , Actornaam);
                    drawactors.Add(nieuw);
                    pictureBox1.Invalidate();
                }
            }

            else if (e.X > 200 && rbUseCase.Checked && rbCreate.Checked)
            {
                int amount = drawusecase.Count;
                if (amount < 3)
                {
                    DrawUsecase nieuw = new DrawUsecase(e.X, e.Y);
                    drawusecase.Add(nieuw);
                    pictureBox1.Invalidate();
                }
            }
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (DrawActor actor in drawactors)
            {
                DrawActor.Draw(e.Graphics, actor);
            }

            foreach (DrawUsecase usecase in drawusecase)
            {
                DrawUsecase.Draw(e.Graphics, usecase);
            }

        }

        private string input(string vraag)
        {
            inputnaam inputform = new inputnaam(vraag);
            inputform.ShowDialog();
            return inputform.naam;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
