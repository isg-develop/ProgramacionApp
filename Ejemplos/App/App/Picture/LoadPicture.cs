using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace App.Galería
{
    public partial class LoadPicture : Form
    {
        List<PictureBox> listaImagen = new List<PictureBox>();
        int position = 0;  
        int ejeX = 0;
        int ejeY = 0;
        int ancho = 200;
        int alto = 200;
        public LoadPicture()
        {
            InitializeComponent();
        }

        private void InitData(){
        	//Limpiamos memoria
            listaImagen = new List<PictureBox>();
            flpPanel.Controls.Clear();
        	 ejeX = 0;
       	     ejeY = 0;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Limpiamos memoria
            InitData();
            
            List<String> directorios = GetSystemImages();//new List<string>();
            foreach (var valor in directorios)
            {
                //If valor.Contains(".jpg") Or valor.Contains(".bmp") Or valor.Contains(".gif") Then
                if (valor.ToLower().Contains(".jpg") || valor.ToLower().Contains(".bmp")
                    || valor.ToLower().Contains(".gif") || valor.ToLower().Contains(".png"))
                {
                	PictureBox imagen = new PictureBox(){
                		Image = CargarImagen(valor),
                		Height = alto,
                    	Width = ancho,
                    	Location = new Point(ejeX, ejeY),
                	};
                	
                    ValidarUbicacion(imagen.Width); //Validar
                    listaImagen.Add(imagen); //agregar al listado
                }                
            }
            //flpPanel.FlowDirection = FlowDirection.LeftToRight;
            foreach (var item in listaImagen)
            {
            	//imprimir listado en pantalla
            	flpPanel.Controls.Add(item);
            	flpPanel.Refresh();
            }
        }
        
        private void ValidarUbicacion(int imagen_ancho){
        	 ejeX = ejeX + imagen_ancho + 10;
        	 if (ejeX > flpPanel.Width){
        	 	ejeX = 0;
        	 	ejeY = alto + 10;        	 
        	 }
        }

        private Bitmap CargarImagen(string ruta)
        {
            try
            {
                return new Bitmap(ruta);
            }
            catch (Exception)
            {
                Console.WriteLine("Picture Invalid");
            }
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
                
        }
        
        
        private void MostrarImagebyURL(string path){
        	//string path= @"C:\ClonarGitHub.JPG";
            PictureBox imagen = new PictureBox();
            if (path.ToLower().Contains(".jpg") || path.ToLower().Contains(".bmp")
                    || path.ToLower().Contains(".gif") || path.ToLower().Contains(".png"))
                {
                    imagen.Image = CargarImagen(path);
                    imagen.Height = 200;
                    imagen.Width = 200;
                    imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    listaImagen.Add(imagen);
                    flpPanel.Controls.Add(imagen);
                }                   
        }
        
        private List<String> GetSystemImages(){
        
            try
            {
            	string micarpeta = @"C:\GitHub\ProgramacionApp\Ejemplos\App\App\Resources";
            	var lista = Directory.EnumerateFiles(micarpeta, "*.*", SearchOption.AllDirectories)
            					.Where(s => s.EndsWith(".png") || s.EndsWith(".jpg"));
            	//lista.Add(@"C:\Carpeta");
            	return lista.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //return lista;
            }
            return null;
        }
		void IzquierdaClick(object sender, EventArgs e)
		{
			ValidarNext();
			try {
				PictureBox img = listaImagen[position];
				img.SizeMode = PictureBoxSizeMode.StretchImage;
				//imprimir listado en pantalla
	            flpPanel.Controls.Add(img);
	            flpPanel.Refresh();
	            
			} catch {}
			position--;
		}
		
		void DerechaClick(object sender, EventArgs e)
		{
			ValidarNext();
			try {
				PictureBox img = listaImagen[position];
				img.SizeMode = PictureBoxSizeMode.StretchImage;
				//imprimir listado en pantalla
	            flpPanel.Controls.Add(img);
	            flpPanel.Refresh();
	            
			} catch {}
			position++;
		}
		
		void ValidarNext(){
			if (listaImagen.Count == 0 ) return;
			flpPanel.Controls.Clear();
			if (position  > listaImagen.Count){
				position = 0;
			}
			if (position  < 0){
				position = listaImagen.Count;
			}
		}
    }
}
