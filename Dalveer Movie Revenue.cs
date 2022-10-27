using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment_4
{
    public partial class Form1 : Form
    {
        StreamReader movieFile;
        const int SIZE = 16;

        public Form1()
        {
            InitializeComponent();
        }

        private void ReadIntoArray(string[] arr1, string[] arr2)
        {
            char[] delim = { '{', '}', '@', '#', '='};

            for (int i = 0; i < SIZE; i++)
            {
                string[] parts = movieFile.ReadLine().Split(delim);
                arr1[i] = parts[0];
                arr2[i] = parts[1];
            }

        }

            

        private void SelectionSortByName(string[] arr1, string[] arr2)
        {
            string[] arr3 = new string[arr1.Length];

            int smallest;
            string temp;
            string temp1;

            for (int i = 0; i < arr1.Length - 1; i++)
            {
                smallest = i;

                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[j].CompareTo(arr1[smallest]) < 0)
                    {
                        smallest = j;
                    }
                }

                if (smallest != i)
                {
                    temp = arr1[i];
                    temp1 = arr2[i];
                    arr1[i] = arr1[smallest];
                    arr2[i] = arr2[smallest];
                    arr1[smallest] = temp;
                    arr2[smallest] = temp1;
                }
            }

            for (int i = 0; i < arr1.Length; i++)
                arr3[i] = arr1[i] + ">===>" + arr2[i];

            DisplayRevenue(arr3);
        }

        private void SelectionSortByRevenue(string[] arr1, string[] arr2)
        {
            string[] arr3 = new string[arr2.Length];
            double[] arr = new double[arr2.Length];
      
            int smallest = 0;
            double temp = 0;
            string temp1;

            for(int k = 0; k < arr2.Length; k++)
            {
                double.TryParse(arr2[k], out double result);
                arr[k] = result;
            }

            

            for (int i = 0; i < arr.Length - 1; i++)
            {
                smallest = i;
                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (arr[j] < arr[smallest])
                        smallest = j;
                }
                temp = arr[smallest];
                temp1 = arr1[smallest];
                arr[smallest] = arr[i];
                arr1[smallest] = arr1[i];
                arr[i] = temp;
                arr1[i] = temp1;
            }


            
            

                for (int i = 0; i < arr.Length; i++)
                    arr3[i] = arr1[i] + "<===<" + arr[i].ToString();



            if (revenueRdBtn.Checked)
            {
                double.TryParse(searchTxtBx.Text.Trim(), out double result);
                BinSrch(arr, arr1, result);
            }
            else
            {
                DisplayRevenue(arr3);
            }
        }

        private void BinSrch(double[] arr,string[] arr2, double num)
        {
            int first = 0;
            int last = arr.Length - 1;
            int mid = -1;
            bool found = false;



            while (first <= last)
            {
                mid = (first + last) / 2;
                if (arr[mid] == num)
                {
                    found = true;
                    sortLstBx.Items.Add(arr2[mid] + "<===<" +arr[mid].ToString() + "******EXACT");
                    break;
                }
                else
                if (arr[mid] < num)
                    first = mid + 1;
                else
                    last = mid - 1;
            }
        }

        private void DisplayRevenue(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                sortLstBx.Items.Add(arr[i]);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            movieFile = File.OpenText("MovieRevenue.txt");
            string[] MovieTitleRev = sortLstBx.Items.OfType<string>().ToArray();
            string[] MovieTitle = new string[SIZE];
            string[] MovieRev = new string[SIZE];
            string find = searchTxtBx.Text.Trim();
            
            
            if (nameRdBtn.Checked)
            {
                
                    sortLstBx.Items.Clear();
                    for (int i = 0; i < MovieTitleRev.Length; i++)
                    {
                        if (MovieTitleRev[i].Contains(find))
                        {
                            sortLstBx.Items.Add(MovieTitleRev[i]);
                        }
                    }
                if (sortLstBx.Items.Count == 0)
                {
                    sortLstBx.Items.Add("no movies with those characters");
                }
            }

            if (revenueRdBtn.Checked)
            { 
                sortLstBx.Items.Clear();
             if (double.TryParse(searchTxtBx.Text.Trim(), out double result))
             {
                SelectionSortByRevenue(MovieTitle, MovieRev);

                for (int i = 0; i < MovieTitleRev.Length; i++)
                {
                    
                    if (MovieTitleRev[i].Contains(find))
                    {
                        sortLstBx.Items.Add(MovieTitleRev[i]);
                    }
                        if(sortLstBx.Items.Count == 0)
                        {
                            sortLstBx.Items.Add("no movies with those characters");
                        }
                }

             }
                else
                {
                    MessageBox.Show("non numeric value. please reenter");
                }
            }
            movieFile.Close();
        }

        private void sortNameBtn_Click(object sender, EventArgs e)
        {

            movieFile = File.OpenText("MovieRevenue.txt");
            sortLstBx.Items.Clear();
            string[] MovieTitle = new string[SIZE];
            string[] MovieRev = new string[SIZE];

            ReadIntoArray(MovieTitle, MovieRev);
            SelectionSortByName(MovieTitle, MovieRev);
            movieFile.Close();
        }

        private void sortRevBtn_Click(object sender, EventArgs e)
        {
            movieFile = File.OpenText("MovieRevenue.txt");
            sortLstBx.Items.Clear();
            string[] MovieTitle = new string[SIZE];
            string[] MovieRev = new string[SIZE];
            ReadIntoArray(MovieTitle, MovieRev);
            SelectionSortByRevenue(MovieTitle, MovieRev);
            movieFile.Close();
        }
    }
}
