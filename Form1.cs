using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int flaglist;
        int nota;
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_Click(object sender, EventArgs e)
        {
            if (texto1.Text.Trim().Length == 0 || texto2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar datos", "Aviso!");
                texto1.Focus();
            } else
            {

            nota = Convert.ToInt16(texto2.Text);

                if (nota >= 7)
                {
                    if (nota > 10)
                    {
                        MessageBox.Show("La nota no puede ser mayor a 10", "Aviso!");
                        texto2.Focus();
                    } else {
                        listapro.Items.Add(texto1.Text);
                        texto1.Clear();
                        texto2.Clear();
                        texto1.Focus();
                        cantapro.Text = listapro.Items.Count.ToString() + " Aprobados";
                    }

                } else
                {
                    if (nota < 0)
                    {
                        MessageBox.Show("La nota no puede ser negativa", "Aviso!");
                        texto2.Focus();
                    } else
                    {
                        listdesa.Items.Add(texto1.Text);
                        texto1.Clear();
                        texto2.Clear();
                        texto1.Focus();
                        cantdesa.Text = listdesa.Items.Count.ToString() + " Desaprobados";
                    }
                }
            }
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            if (flaglist == 1)
            {
                string curItem = listapro.SelectedItem.ToString();
                int index = listapro.FindString(curItem);
                listapro.Items.RemoveAt(index);
                cantapro.Text = listapro.Items.Count.ToString() + " Aprobados";
            }
            if (flaglist == 2)
            {
                string curItem = listdesa.SelectedItem.ToString();
                int index = listdesa.FindString(curItem);
                listdesa.Items.RemoveAt(index);
                cantdesa.Text = listdesa.Items.Count.ToString() + " Desaprobados";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listapro.ClearSelected();
            listdesa.ClearSelected();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void listdesa_Click(object sender, EventArgs e)
        {
            flaglist = 2;
        }

        private void listapro_Click(object sender, EventArgs e)
        {
            flaglist = 1;
        }

        private void boton3_Click(object sender,EventArgs e)
        {
            object[] objCollection = new object[listapro.Items.Count];
            object[] objCollection2 = new object[listdesa.Items.Count];
            listapro.Items.CopyTo(objCollection, 0);
            listdesa.Items.CopyTo(objCollection2, 0);

            listtotal.Items.AddRange(objCollection);
            listtotal.Items.AddRange(objCollection2);


            if (listapro.Items.Count == 0 && listdesa.Items.Count == 0)
            {
                MessageBox.Show("No hay datos ingresados", "Aviso!");
            }
            else
            {
                if (listapro.Items.Count > listdesa.Items.Count)
                {
                    listtotal.BackColor = Color.Lime;
                    MessageBox.Show("La mayoria de los alumnos estan aprobados", "Aviso!");
                }
                else
                {
                    if (listapro.Items.Count == listdesa.Items.Count)
                    {
                        listtotal.BackColor = Color.LightBlue;
                        MessageBox.Show("Hay igual cantidad de Aprobados y Desaprobados", "Aviso!");
                    }
                    else
                    { 
                        listtotal.BackColor = Color.Red;
                        MessageBox.Show("La mayoria de los alumnos estan desaprobados", "Aviso!");
                    }
                }
                boton3.Enabled = false;
            }
            cantotal.Text = listtotal.Items.Count.ToString() + " Total";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listtotal.Items.Clear();
            cantotal.Text = listtotal.Items.Count.ToString() + " Total";
            boton3.Enabled = true;
        }
    }
}
