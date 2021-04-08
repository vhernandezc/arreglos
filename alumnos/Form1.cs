using alumnos.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alumnos
{
    public partial class Form1 : Form
    {

        public string []datosUnitarios;
        private string[] ArregloNotas;
        

        public Form1()
        {

            InitializeComponent();
        }

        private void btnarreglo_Click(object sender, EventArgs e)
        {
            {

                ltbresultado.Items.Clear();
                foreach (string linea in ArregloNotas)
                {
                   

                    datosUnitarios =linea.Split(';');
                
                    ltbresultado.Items.Add(datosUnitarios [1]);
                    ltbresultado.Items.Add(datosUnitarios[3]);

                    {
                        
                    }
                }
            }
        }
        private void btncargarArchivo_Click(object sender, EventArgs e)
        {
            clsArchivo ar = new clsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "porfa selecciona el archivo";
            ofd.InitialDirectory = @"C:\Users\USER\Desktop\alumnos";
            ofd.Filter = "archivo plano (*.csv)|*.csv";
            

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = ar.leerTodoArchivo(archivo);
                ArregloNotas = ar.leerArchivo(archivo);
                txtresultado.Text = resultado;

            }

        }

        private void btnNombres_Click(object sender, EventArgs e)
        {
            ltbresultado.Items.Clear();

            foreach (string linea in ArregloNotas)
            {
                datosUnitarios = linea.Split(';');
                ltbresultado.Items.Add(datosUnitarios[1]);









            }
        }


        private void parcial1_Click(object sender, EventArgs e)
        {
            ltbresultado.Items.Clear();

            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                ltbresultado.Items.Add(datosUnitarios[1]);
                ltbresultado.Items.Add(datosUnitarios[2]);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnParcial3_Click(object sender, EventArgs e)
        {
            ltbresultado.Items.Clear();

            foreach (string linea in ArregloNotas)
            {
                
                string[] datosUnitarios = linea.Split(';');
                

                ltbresultado.Items.Add(datosUnitarios[1]);
                           
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

    

