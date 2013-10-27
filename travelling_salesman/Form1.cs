using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace travelling_salesman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //pointer to multidimensional array of distances between cities
        int[,] distArray;
        //cities count
        int cityCount;

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "Text Files (.txt)|*.txt";
            openDlg.InitialDirectory = Environment.CurrentDirectory;
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader strReader = new StreamReader(openDlg.FileName);
                //read city count from first line
                cityCount = Convert.ToInt32(strReader.ReadLine());
                //init distance array based on # of cities
                distArray = new int[cityCount,cityCount];

                int x = 0;
                while (!strReader.EndOfStream)
                {
                    string temp = strReader.ReadLine();
                    string[] distances = temp.Split(' ');
                    for (int y=0; y <cityCount; y++)
                        distArray[x, y] = Convert.ToInt32(distances[y]);
                    x++;
                }
                buttonShowDist.Enabled = true;
                strReader.Close();
            }
        }

        private void buttonShowDist_Click(object sender, EventArgs e)
        {
            string temp = "";
            for (int x = 0; x < cityCount; x++)
            {
                for (int y = 0; y < cityCount; y++)
                    temp += distArray[x, y].ToString() + " ";
                temp += "\n";
            }
            MessageBox.Show(temp, "Macierz odległosci");
        }
    }
}
