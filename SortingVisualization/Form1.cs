using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingVisualization
{
    public partial class Form1 : Form
    {
        private int[] heightArray;
        private Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            heightArray = new int[Params.arraySize];
            screen.Image = new Bitmap(screen.Width, screen.Height);
            graphics = Graphics.FromImage(screen.Image);

            shuffleButton.Click += Shuffle;
            sortButton.Click += Sort;

            InitializeArray();
            RenderArray(null);
        }

        private void InitializeArray()
        {
            for(int i = 0; i < heightArray.Length; ++i) heightArray[i] = (i + 1) * Params.offset;
            Shuffle();
        }

        private void Shuffle()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < heightArray.Length; ++i)
            {
                int swapIndex = random.Next(heightArray.Length);
                int temp = heightArray[swapIndex];
                heightArray[swapIndex] = heightArray[i];
                heightArray[i] = temp;
            }
            RenderArray(null);
        }

        private void Shuffle(object sender, EventArgs e)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < heightArray.Length; ++i)
            {
                int swapIndex = random.Next(heightArray.Length);
                int temp = heightArray[swapIndex];
                heightArray[swapIndex] = heightArray[i];
                heightArray[i] = temp;
            }
            RenderArray(null);
        }

        private void Sort(object sender, EventArgs e)
        {
            ISortAlgorithm algorithm = new BubbleSort(heightArray);
            while (!algorithm.Finished())
            {
                StepChanges sc = algorithm.Step();
                RenderArray(sc);
            }
            RenderArray(null);
        }


        private void RenderArray(StepChanges sc)
        {
            graphics.Clear(screen.BackColor);
            SolidBrush backgroundBrush = new SolidBrush(Color.LightBlue);
            Pen pen = new Pen(Color.Black);
            for (int i = 0; i < heightArray.Length; ++i)
                graphics.FillRectangle(backgroundBrush, 10 + i * Params.rectWidth, 10, 
                    Params.rectWidth, heightArray[i]);
                
            
            if(sc != null)
            {
                Color color = sc.swaped ? Color.Red : Color.Green;
                SolidBrush indicatorBrush = new SolidBrush(color);
                graphics.FillRectangle(indicatorBrush, 10 + sc.i * Params.rectWidth, 10, 
                    Params.rectWidth, heightArray[sc.i]);
                graphics.FillRectangle(indicatorBrush, 10 + sc.j * Params.rectWidth, 10,
                    Params.rectWidth, heightArray[sc.j]);
            }

            for (int i = 0; i < heightArray.Length; ++i)
                graphics.DrawRectangle(pen, 10 + i * Params.rectWidth, 10, 
                    Params.rectWidth, heightArray[i]);
            
            screen.Refresh();
        }
    }
}
