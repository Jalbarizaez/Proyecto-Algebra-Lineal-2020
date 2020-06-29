using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Proyecto_Algebra_Lineal
{
    public partial class Form1 : Form
    {
        private double[,] Difuminado =
            {{0.0625,0.125,0.0625}
            ,{0.125,0.25,0.125}
            ,{0.0625,0.125,0.0625}};
        private double[,] Realzar =
            {{-2,-1,0}
            ,{-1,1,1}
            ,{0,1,2 } };
        private double[,] Sobel_Inferior =
            {{-1,-2,-1}
            ,{0,0,0}
            ,{1,2,1}};
        private double[,] Sobel_Superior =
            {{1 ,2 ,1}
            ,{0 ,0 ,0}
            ,{-1,-2,-1}};
        private double[,] Sobel_Izquierdo =
            {{1,0,-1}
            ,{2,0,-2}
            ,{1,0,-1}};
        private double[,] Sobel_Derecho =
            {{-1,0,1}
            ,{-2,0,2}
            ,{-1,0,1}};
        private double[,] Contorno =
            {{-1,-1,-1}
            ,{-1, 8,-1}
            ,{-1,-1,-1}};
        private double[,] Afilar =
            {{0 ,-1,0}
            ,{-1,5,-1}
            ,{0,-1,0}};
        private double[,] Original =
            {{0,0,0}
            ,{0,1,0}
            ,{0,0,0}};
        private string Kernel_Seleccionado = "";
        private string Direccion_Foto = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Kernels_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = Kernels.SelectedIndex;
            Kernel_Seleccionado = Kernels.Items[indice].ToString();
        }

        private void Fotografia_Click(object sender, EventArgs e)
        {
            if(Seleccion_Imagen.ShowDialog() == DialogResult.OK)
            {
                F_Original.ImageLocation = Seleccion_Imagen.FileName;
                Direccion_Foto = Seleccion_Imagen.FileName;
            }
        }
        private Bitmap Multiplicacion(Bitmap Imagen,double[,] Kernel)
        {
            int alto = Imagen.Height;
            int ancho = Imagen.Width;
            Bitmap Resultado = new Bitmap(ancho, alto);
            for (int i = 1; i < ancho - 1; i++)
            {
                for (int j = 1; j < alto - 1; j++)
                {
                    double Resultado_Kernel = 
                       Imagen.GetPixel(i - 1, j - 1).R * Kernel[0,0] + Imagen.GetPixel(i, j - 1).R * Kernel[0, 1]+ Imagen.GetPixel(i + 1, j - 1).R * Kernel[0, 2]
                     + Imagen.GetPixel(i - 1, j).R * Kernel[1, 0]+ Imagen.GetPixel(i, j).R * Kernel[1, 1]+ Imagen.GetPixel(i + 1, j).R * Kernel[1, 2]
                     + Imagen.GetPixel(i - 1, j + 1).R * Kernel[2, 0] + Imagen.GetPixel(i, j + 1).R * Kernel[2, 1]  + Imagen.GetPixel(i + 1, j + 1).R * Kernel[2, 2];
                    int Resultado_Final = Convert.ToInt32(Resultado_Kernel);
                    if (Resultado_Final > 255)
                    {
                        Resultado.SetPixel(i, j, Color.White);
                    }
                    else if(Resultado_Final < 0)
                    {
                        Resultado.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        Resultado.SetPixel(i, j, Color.FromArgb(255, (int)Resultado_Final, (int)Resultado_Final, (int)Resultado_Final));
                    }
                }
            }
            return Resultado;
        }
        private void button1_Click(object sender, EventArgs e)
        {
          if(Direccion_Foto != "")
            {
                if(Kernel_Seleccionado !="")
                {
                    Image Nuevo;
                    switch (Kernel_Seleccionado)
                    {
                        case "Difuminado":
                            Nuevo = Multiplicacion(new Bitmap(Direccion_Foto), Difuminado);
                            F_Procesada.Image = Nuevo;
                            break;
                        case "Realzar":
                            Nuevo = Multiplicacion(new Bitmap(Direccion_Foto), Realzar);
                            F_Procesada.Image = Nuevo;
                            break;
                        case "Sobel Inferior":
                            Nuevo = Multiplicacion(new Bitmap(Direccion_Foto), Sobel_Inferior);
                            F_Procesada.Image = Nuevo;
                            break;
                        case "Sobel Superior":
                            Nuevo = Multiplicacion(new Bitmap(Direccion_Foto), Sobel_Superior);
                            F_Procesada.Image = Nuevo;
                            break;
                        case "Sobel Izquierdo":
                            Nuevo = Multiplicacion(new Bitmap(Direccion_Foto), Sobel_Izquierdo);
                            F_Procesada.Image = Nuevo;
                            break;
                        case "Sobel Derecho":
                            Nuevo = Multiplicacion(new Bitmap(Direccion_Foto), Sobel_Derecho);
                            F_Procesada.Image = Nuevo;
                            break;
                        case "Contorno":
                            Nuevo = Multiplicacion(new Bitmap(Direccion_Foto), Contorno);
                            F_Procesada.Image = Nuevo;
                            break;
                        case "Afilar":
                            Nuevo = Multiplicacion(new Bitmap(Direccion_Foto),Afilar);
                            F_Procesada.Image = Nuevo;
                            break;
                        case "Original":
                            Nuevo = Multiplicacion(new Bitmap(Direccion_Foto), Original);
                            F_Procesada.Image = Nuevo;
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un Kernel");
                }
            }
          else
            {
                MessageBox.Show("Seleccione una foto");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Direccion_Foto != "")
            {
                if (Personalizado.Text != "") 
                {
                    try
                    {
                        string[] Numeros = Personalizado.Text.Split(',');
                        double[,] Matriz_Personalizada = new double[3, 3];
                        int Posicion_Numeros = 0;
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                Matriz_Personalizada[i, j] = Convert.ToInt16(Numeros[Posicion_Numeros]);
                                Posicion_Numeros++;
                            }
                        }
                        Image Nuevo = Multiplicacion(new Bitmap(Direccion_Foto), Matriz_Personalizada);
                        F_Procesada.Image = Nuevo;

                    }
                    catch
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Kernel personalizado");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fotografia");
            }
        }
    }
}
