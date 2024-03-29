﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorElectronica
{
    public partial class MainForm : Form
    {
      private byte bandaSeleccionada = 0;
        Bandas banda1 = new Bandas(0,Color.Black,1,0);
        Bandas banda2= new Bandas(0, Color.Black, 1, 0);
        Bandas banda3= new Bandas(0,Color.Black,1,0);
        Bandas banda4 = new Bandas(0, Color.Black, 1, 0);
        Bandas bandaTemp= new Bandas(0, Color.Black, 1, 0);
        long multiplicador;
        string valores;
        long valor;
        byte index = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxBanda1.SelectedIndex = 0;
            comboBoxBanda2.SelectedIndex = 0;
            comboBoxBanda3.SelectedIndex = 0;
            comboBoxBanda4.SelectedIndex = 0;
        }

        //Evalua el indice seleccionado del comboBox (los colores), despues asigna los valores que corresponden a cada color
        //usa un objeto de la clase "Bandas" para alojar los valores de manera temporal, mas adelante estos valores seran
        //copiados a la clase destino
        private void AsignarValores(int index)
        {
            switch (index)
            {
                //Los getters y setters pertenecen a la clase "Bandas"
                case 0:
                    bandaTemp.SetColor(Color.Black);
                    bandaTemp.SetValor(0);
                    bandaTemp.SetMultiplicador(1);
                    bandaTemp.SetTolerancia(0);
                    break;
                case 1:
                    bandaTemp.SetColor(Color.Brown);
                    bandaTemp.SetValor(1);
                    bandaTemp.SetMultiplicador(10);
                    bandaTemp.SetTolerancia(1);
                    break;
                case 2:
                    bandaTemp.SetColor(Color.Red);
                    bandaTemp.SetValor(2);
                    bandaTemp.SetMultiplicador(100);
                    bandaTemp.SetTolerancia(2);
                    break;
                case 3:
                    bandaTemp.SetColor(Color.Orange);
                    bandaTemp.SetValor(3);
                    bandaTemp.SetMultiplicador(1000);
                    bandaTemp.SetTolerancia(0);
                    break;
                case 4:
                    bandaTemp.SetColor(Color.Yellow);
                    bandaTemp.SetValor(4);
                    bandaTemp.SetMultiplicador(10000);
                    bandaTemp.SetTolerancia(0);
                    break;
                case 5:
                    bandaTemp.SetColor(Color.Green);
                    bandaTemp.SetValor(5);
                    bandaTemp.SetMultiplicador(100000);
                    bandaTemp.SetTolerancia(0.5);
                    break;
                case 6:
                    bandaTemp.SetColor(Color.Blue);
                    bandaTemp.SetValor(6);
                    bandaTemp.SetMultiplicador(1000000);
                    bandaTemp.SetTolerancia(0.25);
                    break;
                case 7:
                    bandaTemp.SetColor(Color.Violet);
                    bandaTemp.SetValor(7);
                    bandaTemp.SetMultiplicador(10000000);
                    bandaTemp.SetTolerancia(0.10);
                    break;
                case 8:
                    bandaTemp.SetColor(Color.Gray);
                    bandaTemp.SetValor(8);
                    bandaTemp.SetMultiplicador(100000000);
                    bandaTemp.SetTolerancia(0.005);
                    break;
                case 9:
                    bandaTemp.SetColor(Color.White);
                    bandaTemp.SetValor(9);
                    bandaTemp.SetMultiplicador(1000000000);
                    bandaTemp.SetTolerancia(0);
                    break;
                case 10:
                    bandaTemp.SetColor(Color.Gold);
                    bandaTemp.SetValor(0);
                    bandaTemp.SetMultiplicador(0.1);
                    bandaTemp.SetTolerancia(5);
                    break;
                case 11:
                    bandaTemp.SetColor(Color.Silver);
                    bandaTemp.SetValor(0);
                    bandaTemp.SetMultiplicador(0.01);
                    bandaTemp.SetTolerancia(10);
                    break;
            }
        }
        //Asigna los valores que son exclusivos para la banda4, ya que el parametro "Tolerancia"
        //requiere valores distintos a las demas bandas
        private void AsinarValoresTolerancia(int index)
        {
            switch (index)
            {
                case 0:
                    bandaTemp.SetColor(Color.Brown);
                    bandaTemp.SetValor(1);
                    bandaTemp.SetMultiplicador(10);
                    bandaTemp.SetTolerancia(1);
                    break;
                case 1:
                    bandaTemp.SetColor(Color.Red);
                    bandaTemp.SetValor(2);
                    bandaTemp.SetMultiplicador(100);
                    bandaTemp.SetTolerancia(2);
                    break;
                case 2:
                    bandaTemp.SetColor(Color.Green);
                    bandaTemp.SetValor(5);
                    bandaTemp.SetMultiplicador(100000);
                    bandaTemp.SetTolerancia(0.5);
                    break;
                case 3:
                    bandaTemp.SetColor(Color.Blue);
                    bandaTemp.SetValor(6);
                    bandaTemp.SetMultiplicador(1000000);
                    bandaTemp.SetTolerancia(0.25);
                    break;
                case 4:
                    bandaTemp.SetColor(Color.Violet);
                    bandaTemp.SetValor(7);
                    bandaTemp.SetMultiplicador(10000000);
                    bandaTemp.SetTolerancia(0.10);
                    break;
                case 5:
                    bandaTemp.SetColor(Color.Gray);
                    bandaTemp.SetValor(8);
                    bandaTemp.SetMultiplicador(100000000);
                    bandaTemp.SetTolerancia(0.005);
                    break;
                case 6:
                    bandaTemp.SetColor(Color.Gold);
                    bandaTemp.SetValor(0);
                    bandaTemp.SetMultiplicador(0.1);
                    bandaTemp.SetTolerancia(5);
                    break;
                case 7:
                    bandaTemp.SetColor(Color.Silver);
                    bandaTemp.SetValor(0);
                    bandaTemp.SetMultiplicador(0.01);
                    bandaTemp.SetTolerancia(10);
                    break;
            }

        }
        
        //El comboBox aparece justo en el lugar del puntero al hacer click sobre el PictureBox que representa la banda de la resistencia
        private void ShowComboBoxColorOnClick()
        {
            comboBoxColor.Visible = true;
            Point cursorPosition = Cursor.Position; // Obtiene la posición actual del cursor
            Point formPosition = PointToClient(cursorPosition); // Convierte la posición del cursor a coordenadas relativas al formulario
            comboBoxColor.Location = formPosition;//el valor de las coordenadas del puntero son usadas como punto de aparicion del comboBox
            comboBoxColor.DroppedDown = true;//La lista se muestra desplegada inmediatamente despues de aparecer

        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Listeners de los pictureBox que son activados al hacer click sobre ellos
        //Los items del comboBoxColor es vaciado y llenado cada vez que se hace click sobre un pictureBox ya que
        // cada banda requiere una coleccion de Items distintos, se designa la banda activa sobre la cual se haran
        //los cambios y se muestra el comboBoxColor
        private void PicBoxBanda1_Click(object sender, EventArgs e)
        {
            comboBoxColor.Items.Clear();
            ComboBoxColorAddItems();
            bandaSeleccionada = 1;
            ShowComboBoxColorOnClick();
        }

        private void PicBoxBanda2_Click(object sender, EventArgs e)
        {
            comboBoxColor.Items.Clear();
            ComboBoxColorAddItems();
            bandaSeleccionada = 2;
            ShowComboBoxColorOnClick();
        }

        private void PicBoxBanda3_Click(object sender, EventArgs e)
        {
            comboBoxColor.Items.Clear();
            ComboBoxColorAddItems();
            bandaSeleccionada = 3;
            ShowComboBoxColorOnClick();
        }

        private void PicBoxBanda4_Click(object sender, EventArgs e)
        {
            comboBoxColor.Items.Clear();
            comboBoxColor.Items.AddRange(new object[] {
            "Café",
            "Rojo",
            "Verde",
            "Azul",
            "Violeta",
            "Gris",
            "Dorado",
            "Plata"});
            bandaSeleccionada = 4;
            ShowComboBoxColorOnClick();
        }
        /// </summary>//////////////////////////////////////////////////////////////////////////

        //Oculta el comboBox desplegable
        private void comboBoxColor_DropDownClosed(object sender, EventArgs e)
        {
            comboBoxColor.Visible = false;
        }

        //Concatena los valores de banda1 y banda2, posteriormente los multiplica por el multiplicador de la banda3
        //una vez obtenida la resistencia total ,el resultado se muestra en la txtResistencia con su prefijo correspondiente
        private void CheckMultiplicador()
        {
            valores = banda1.GetValor().ToString()+banda2.GetValor().ToString();
            valor = Convert.ToInt64(valores);

            if (banda3.GetMultiplicador() < 1000)
            {
                multiplicador = (long)banda3.GetMultiplicador();
                txtResistencia.Text = (valor * multiplicador).ToString() + "\u03A9";
            }

            if (banda3.GetMultiplicador() >= 1000)
            {
                multiplicador = (long)(banda3.GetMultiplicador() / 1000);
                txtResistencia.Text = (valor * multiplicador).ToString() + "K\u03A9";
            }
            if (banda3.GetMultiplicador() >= 1000000)
            {
                multiplicador = (long)(banda3.GetMultiplicador() / 1000000);
                txtResistencia.Text = (valor * multiplicador).ToString() + "M\u03A9";
            }
            if (banda3.GetMultiplicador() >= 1000000000)
            {
                multiplicador = (long)(banda3.GetMultiplicador() / 1000000000);
                txtResistencia.Text = (valor * multiplicador).ToString() + "G\u03A9";
            }
        }

        //Recibe 2 parammetros "banda" la cual es la banda seleccionada y en la cual se efectuaran los cambios, "indice" indica
        //el indice del comboBox, este indice dicta el color, y por lo tanto los valores de cada coloran que se asignaran.
        //Asigna los valores correspondientes a los objetos de la clase "Bandas", estos objetos "bandaX" contienen los valores de
        //color,valor,tolerancia y multiplicador, en base a estos valores se seleccionan los valores (colores) de los pictureBox,
        // y se seleccionan los indices de los comboBox correspondientes.

        private void InitBandas(int banda,int indice)
        {
            switch (banda)
            {
                case 1:
                    AsignarValores(indice);
                    banda1.SetValor(bandaTemp.GetValor());
                    banda1.SetColor(bandaTemp.GetColor());
                    picBoxBanda1.BackColor = banda1.GetColor();
                    comboBoxBanda1.SelectedIndex = banda1.GetValor();
                    CheckMultiplicador();

                    break;
                case 2:
                    AsignarValores(indice);
                    banda2.SetValor(bandaTemp.GetValor());
                    banda2.SetColor(bandaTemp.GetColor());
                    picBoxBanda2.BackColor = banda2.GetColor();
                    comboBoxBanda2.SelectedIndex = banda2.GetValor();
                    CheckMultiplicador();
                    break;
                case 3:
                    AsignarValores(indice);
                    banda3.SetValor(bandaTemp.GetValor());
                    banda3.SetColor(bandaTemp.GetColor());
                    banda3.SetMultiplicador(bandaTemp.GetMultiplicador());
                    picBoxBanda3.BackColor = banda3.GetColor();
                    comboBoxBanda3.SelectedIndex = ComboBoxSelectIndexMulti();
                    CheckMultiplicador();

                    break;
                case 4:
                    //AsignarValores(indice);
                    AsinarValoresTolerancia(indice);
                    banda4.SetValor(bandaTemp.GetValor());
                    banda4.SetColor(bandaTemp.GetColor());
                    banda4.SetTolerancia(bandaTemp.GetTolerancia());
                    picBoxBanda4.BackColor = banda4.GetColor();
                    comboBoxBanda4.SelectedIndex = ComboBoxSelectIndexTol();
                    break;
            }
            //Console.WriteLine("\n\nBanda1: " + banda1.ToString());
            //Console.WriteLine("\nBanda2: " + banda2.ToString());
            //Console.WriteLine("\nBanda3: " + banda3.ToString());
            //Console.WriteLine("\nBanda4: " + banda4.ToString());
            //Console.WriteLine("\nBanda Temp: " + bandaTemp.ToString());
            //Console.WriteLine("ComboBoxBanda1: " + comboBoxBanda1.SelectedIndex);
            //Console.WriteLine("ComboBoxBanda2: " + comboBoxBanda2.SelectedIndex);
            //Console.WriteLine("ComboBoxBanda3: " + comboBoxBanda3.SelectedIndex);
        }

        //Relaciona la tolerancia de la banda4 con un indice del comboBoxBanda4
        //se retorna el valor del indice para usarlo al invocar la funcion
        private byte ComboBoxSelectIndexTol()
        {
            Console.WriteLine("La toelrancia es: " + banda4.GetTolerancia()) ;
            if (banda4.GetTolerancia() == 1)
                index = 0;
            else if (banda4.GetTolerancia() == 2)
                index = 1;
            else if (banda4.GetTolerancia() == 0.5)
                index = 2;
            else if (banda4.GetTolerancia() == 0.25)
                index = 3;
            else if (banda4.GetTolerancia() == 0.10)
                index = 4;
            else if (banda4.GetTolerancia() == 0.05)
                index = 5;
            else if (banda4.GetTolerancia() == 5)
                index = 6;
            else if (banda4.GetTolerancia() == 10)
                index = 7;
            return index;
        }
        //Relaciona el multiplicador de la banda3 con un indice del comboBox3
        //El valor del indice se retorna para ser usado cuando se invoca la funcion
        private byte ComboBoxSelectIndexMulti()
        {
            byte index = 0;
            if (banda3.GetMultiplicador() == 1)
                index = 0;
            if (banda3.GetMultiplicador() == 10)
                index = 1;
            if (banda3.GetMultiplicador() == 100)
                index = 2;
            if (banda3.GetMultiplicador() == 1000)
                index = 3;
            if (banda3.GetMultiplicador() == 10000)
                index = 4;
            if (banda3.GetMultiplicador() == 100000)
                index = 5;
            if (banda3.GetMultiplicador() == 1000000)
                index = 6;
            if (banda3.GetMultiplicador() == 10000000)
                index = 7;
            if (banda3.GetMultiplicador() == 100000000)
                index = 8;
            if (banda3.GetMultiplicador() == 1000000000)
                index = 9;
            if (banda3.GetMultiplicador() == 0.1)
                index = 10;
            if (banda3.GetMultiplicador() == 0.001)
                index = 11;
            return index;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //listener de los comboBox ubicados en la seccion "numerica", estos invocan a la funcion InitBandas
        private void comboBoxBanda1_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitBandas(1,comboBoxBanda1.SelectedIndex);
        }

        private void comboBoxBanda2_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitBandas(2,comboBoxBanda2.SelectedIndex);
        }

        private void comboBoxBanda3_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitBandas(3, comboBoxBanda3.SelectedIndex);
        }

        private void comboBoxBanda4_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitBandas(4, comboBoxBanda4.SelectedIndex);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
         
        //Asigna una collecion de items al comboBoxColor, esta funcion es invocada por los click_Listeners de los pictureBox
        private void ComboBoxColorAddItems()
        {
            comboBoxColor.Items.AddRange(new object[] {
            "Negro",
            "Café",
            "Rojo",
            "Naranja",
            "Amarillo",
            "Verde",
            "Azul",
            "Violeta",
            "Gris",
            "Blanco",
            "Dorado",
            "Plata"});
        }

        //Listener que espera un cambio al indice, al hacerlo invoca la funcion InitBandas
        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitBandas(bandaSeleccionada, comboBoxColor.SelectedIndex);
            comboBoxColor.Visible = false;
        }
    }
}