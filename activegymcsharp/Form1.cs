using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activegymcsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btnPlan = new Button();
            btnPlan.Text = "Ver Plan de Membresia";
            btnPlan.Location = new Point(10, 10);
            btnPlan.AutoSize = true;
            btnPlan.Click += new EventHandler(btnPlan_Click);
            this.Controls.Add(btnPlan);

            Button btnHorario = new Button();
            btnHorario.Text = "Horarios";
            btnHorario.Location = new Point(10, 40);
            btnHorario.AutoSize = true;
            btnHorario.Click += new EventHandler(btnHorario_Click);
            this.Controls.Add(btnHorario);

            Button btnEntrenador = new Button();
            btnEntrenador.Text = "Entrenador";
            btnEntrenador.Location = new Point(10, 60);
            btnEntrenador.AutoSize = true;
            btnEntrenador.Click += new EventHandler(btnEntrenador_Click);
            this.Controls.Add(btnEntrenador);

            Button btnInscribir = new Button();
            btnInscribir.Text = "Inscripcion";
            btnInscribir.Location = new Point(10, 80);
            btnInscribir.AutoSize = true;
            btnInscribir.Click += new EventHandler(btnIncribir_Click);
            this.Controls.Add(btnInscribir);
        }




        private void btnPlan_Click(object sender, EventArgs e)
        {
            Label label1 = new Label();

            Form plan = new Form();
            label1.Text = "Plan de Membresia";
            Label label2 = new Label();
            Label label3 = new Label();
            label2.Text = "Mensualidad:$600";
            label3.Text = "Dia:$150";
            label1.Location = new Point(10, 10);
            label2.Location = new Point(10, 40);
            label3.Location = new Point(10, 60);
            plan.Controls.Add(label3);
            plan.Controls.Add(label2);
            plan.Controls.Add(label1);
            plan.ShowDialog();


        }
        private void btnHorario_Click(object sender, EventArgs e)
        {
            Label label1 = new Label();

            Form horario = new Form();
            label1.Text = "horario";
            Label label2 = new Label();
            Label label3 = new Label();
            label2.Text = "Lunes a Domingo";
            label3.Text = "5:00 am a 12:00 am";
            label1.Location = new Point(10, 10);
            label2.Location = new Point(10, 40);
            label3.Location = new Point(10, 60);
            horario.Controls.Add(label3);
            horario.Controls.Add(label2);
            horario.Controls.Add(label1);
            horario.ShowDialog();


        }

        private void btnEntrenador_Click(object sender, EventArgs e)
        {
            Label label1 = new Label();

            Form horario = new Form();
            label1.Text = "Entrenador";
            Label label2 = new Label();
            Label label3 = new Label();
            label2.Text = "luis:luis@gmail.com";
            label3.Text = "ben:ben20@gmail.com";
            label1.Location = new Point(10, 10);
            label2.Location = new Point(10, 40);
            label3.Location = new Point(10, 60);
            horario.Controls.Add(label3);
            horario.Controls.Add(label2);
            horario.Controls.Add(label1);
            horario.ShowDialog();


        }


        private void btnIncribir_Click(object sender, EventArgs e)
        {
            Label label1 = new Label();

            Form plan = new Form();
            label1.Text = "Incribir";
            Label label2 = new Label();
            Label label3 = new Label();
            label2.Text = "Nombre";
            label3.Text = "Edad";
            Label label4 = new Label();
            label4.Text = "Numero de telefono";
            TextBox txtNombre = new TextBox();
            TextBox txtedad = new TextBox();
            TextBox txtTelefono = new TextBox();
            label1.Location = new Point(10, 10);

            label2.Location = new Point(10, 40);
            txtNombre.Location = new Point(60, 40);

            label3.Location = new Point(10, 60);
            txtedad.Location = new Point(60, 60);

            label4.Location = new Point(10, 80);
            txtTelefono.Location = new Point(120, 80);

            Button btnIncribirse = new Button();
            btnIncribirse.Text = "Aceptar";

            btnIncribirse.Click += (s, ev) =>
            {
                plan.Close(); 
            };
            plan.Controls.Add(txtNombre);
            plan.Controls.Add(txtedad);
            plan.Controls.Add(txtTelefono);

            plan.Controls.Add(btnIncribirse);
            plan.Controls.Add(label4);
            plan.Controls.Add(label3);
            plan.Controls.Add(label2);
            plan.Controls.Add(label1);
            plan.ShowDialog();

        }

        
    }
}