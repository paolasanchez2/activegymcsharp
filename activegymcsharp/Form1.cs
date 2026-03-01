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

            this.Text = "Active Gym - Management System";
            this.BackColor = Color.FromArgb(45, 45, 48);
            this.Size = new Size(350, 450);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // DISEÑO DE BOTONES
            int xPos = 60;
            int btnWidth = 210;
            Color btnColor = Color.FromArgb(63, 63, 70);

            Button btnPlan = new Button();
            btnPlan.Text = "VER PLAN DE MEMBRESÍA";
            btnPlan.Location = new Point(xPos, 60);
            btnPlan.Size = new Size(btnWidth, 40);
            btnPlan.ForeColor = Color.White;
            btnPlan.BackColor = btnColor;
            btnPlan.FlatStyle = FlatStyle.Flat;
            btnPlan.FlatAppearance.BorderSize = 0;
            btnPlan.Click += new EventHandler(btnPlan_Click);
            this.Controls.Add(btnPlan);

            Button btnHorario = new Button();
            btnHorario.Text = "HORARIOS";
            btnHorario.Location = new Point(xPos, 120);
            btnHorario.Size = new Size(btnWidth, 40);
            btnHorario.ForeColor = Color.White;
            btnHorario.BackColor = btnColor;
            btnHorario.FlatStyle = FlatStyle.Flat;
            btnHorario.FlatAppearance.BorderSize = 0;
            btnHorario.Click += new EventHandler(btnHorario_Click);
            this.Controls.Add(btnHorario);

            Button btnEntrenador = new Button();
            btnEntrenador.Text = "ENTRENADORES";
            btnEntrenador.Location = new Point(xPos, 180);
            btnEntrenador.Size = new Size(btnWidth, 40);
            btnEntrenador.ForeColor = Color.White;
            btnEntrenador.BackColor = btnColor;
            btnEntrenador.FlatStyle = FlatStyle.Flat;
            btnEntrenador.FlatAppearance.BorderSize = 0;
            btnEntrenador.Click += new EventHandler(btnEntrenador_Click);
            this.Controls.Add(btnEntrenador);

            Button btnInscribir = new Button();
            btnInscribir.Text = "NUEVA INSCRIPCIÓN";
            btnInscribir.Location = new Point(xPos, 240);
            btnInscribir.Size = new Size(btnWidth, 45);
            btnInscribir.ForeColor = Color.White;
            btnInscribir.BackColor = Color.FromArgb(0, 122, 204);
            btnInscribir.FlatStyle = FlatStyle.Flat;
            btnInscribir.Font = new Font(this.Font, FontStyle.Bold);
            btnInscribir.Click += new EventHandler(btnIncribir_Click);
            this.Controls.Add(btnInscribir);
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            Form plan = new Form();
            plan.Text = "Membresías";
            plan.Size = new Size(300, 300);
            plan.StartPosition = FormStartPosition.CenterParent;

            Label label1 = new Label { Text = "TARIFAS VIGENTES", Location = new Point(20, 20), Font = new Font("Segoe UI", 12, FontStyle.Bold), AutoSize = true };
            Label label2 = new Label { Text = "• Mensualidad: $600", Location = new Point(25, 60), AutoSize = true };
            Label label4 = new Label { Text = "• Semana: $180", Location = new Point(25, 90), AutoSize = true };
            Label label3 = new Label { Text = "• Día único: $150", Location = new Point(25, 120), AutoSize = true };

            // BOTÓN REGRESAR
            Button btnVolver = new Button { Text = "REGRESAR", Location = new Point(80, 180), Size = new Size(120, 30), FlatStyle = FlatStyle.Flat };
            btnVolver.Click += (s, ev) => { plan.Close(); };

            plan.Controls.AddRange(new Control[] { label1, label2, label3, label4, btnVolver });
            plan.ShowDialog();
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            Form horario = new Form();
            horario.Text = "Horarios";
            horario.Size = new Size(300, 250);
            horario.StartPosition = FormStartPosition.CenterParent;

            Label label1 = new Label { Text = "HORARIO DE APERTURA", Location = new Point(20, 20), Font = new Font("Segoe UI", 10, FontStyle.Bold), AutoSize = true };
            Label label2 = new Label { Text = "Lunes a Domingo", Location = new Point(20, 60), AutoSize = true };
            Label label3 = new Label { Text = "05:00 AM - 12:00 AM", Location = new Point(20, 85), Font = new Font("Segoe UI", 11), AutoSize = true };

            // BOTÓN REGRESAR
            Button btnVolver = new Button { Text = "REGRESAR", Location = new Point(80, 140), Size = new Size(120, 30), FlatStyle = FlatStyle.Flat };
            btnVolver.Click += (s, ev) => { horario.Close(); };

            horario.Controls.AddRange(new Control[] { label1, label2, label3, btnVolver });
            horario.ShowDialog();
        }

        private void btnEntrenador_Click(object sender, EventArgs e)
        {
            Form entrenador = new Form();
            entrenador.Text = "CONTACTO STAFF";
            entrenador.Size = new Size(350, 350);
            entrenador.BackColor = Color.White;
            entrenador.StartPosition = FormStartPosition.CenterParent;

            Label label1 = new Label
            {
                Text = "SELECCIONA UN ENTRENADOR",
                Location = new Point(20, 20),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = true
            };

            Label labelInfo = new Label
            {
                Text = "Paola: PaolaSanchez@gmail.com\nAndreik: Andre12120@gmail.com",
                Location = new Point(20, 55),
                ForeColor = Color.Gray,
                Size = new Size(300, 40)
            };

            ComboBox comboEntrenadores = new ComboBox
            {
                Location = new Point(20, 110),
                Width = 280,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            comboEntrenadores.Items.AddRange(new string[] { "Paola", "Andreik" });
            comboEntrenadores.SelectedIndex = 0;

            Button btnContactar = new Button
            {
                Text = "CONTACTAR AHORA",
                Location = new Point(20, 160),
                Size = new Size(280, 40),
                BackColor = Color.FromArgb(0, 122, 204),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            btnContactar.FlatAppearance.BorderSize = 0;

            // BOTÓN REGRESAR
            Button btnVolver = new Button
            {
                Text = "REGRESAR",
                Location = new Point(20, 220),
                Size = new Size(280, 35),
                FlatStyle = FlatStyle.Flat
            };
            btnVolver.Click += (s, ev) => { entrenador.Close(); };

            btnContactar.Click += (s, ev) =>
            {
                string seleccionado = comboEntrenadores.SelectedItem.ToString();
                MessageBox.Show($"El entrenador {seleccionado} ha sido contactado correctamente.\nPronto recibirás una respuesta en tu correo.",
                                "Contacto Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                entrenador.Close();
            };

            entrenador.Controls.AddRange(new Control[] { label1, labelInfo, comboEntrenadores, btnContactar, btnVolver });
            entrenador.ShowDialog();
        }

        private void btnIncribir_Click(object sender, EventArgs e)
        {
            Form plan = new Form();
            plan.Text = "Registro de Socio";
            plan.Size = new Size(400, 480); 
            plan.BackColor = Color.White;
            plan.StartPosition = FormStartPosition.CenterParent;

            Label label1 = new Label { Text = "FORMULARIO DE INSCRIPCIÓN", Location = new Point(20, 20), Font = new Font("Segoe UI", 12, FontStyle.Bold), AutoSize = true, ForeColor = Color.FromArgb(45, 45, 48) };

            Label label2 = new Label { Text = "Nombre Completo:", Location = new Point(20, 70), AutoSize = true };
            TextBox txtNombre = new TextBox { Location = new Point(160, 68), Width = 180 };

            Label label3 = new Label { Text = "Edad:", Location = new Point(20, 110), AutoSize = true };
            TextBox txtedad = new TextBox { Location = new Point(160, 108), Width = 180 };

            Label label4 = new Label { Text = "Teléfono:", Location = new Point(20, 150), AutoSize = true };
            TextBox txtTelefono = new TextBox { Location = new Point(160, 148), Width = 180 };

            Label label5 = new Label { Text = "Plan de Mensualidad:", Location = new Point(20, 190), AutoSize = true };
            ComboBox comboMensualidad = new ComboBox { Location = new Point(160, 188), Width = 180, DropDownStyle = ComboBoxStyle.DropDownList };
            comboMensualidad.Items.AddRange(new string[] { "Día - $150", "Semana - $180", "Mes - $600" });
            comboMensualidad.SelectedIndex = 0;

            Button btnIncribirse = new Button();
            btnIncribirse.Text = "FINALIZAR REGISTRO";
            btnIncribirse.Location = new Point(100, 280);
            btnIncribirse.Size = new Size(200, 45);
            btnIncribirse.BackColor = Color.FromArgb(0, 122, 204);
            btnIncribirse.ForeColor = Color.White;
            btnIncribirse.FlatStyle = FlatStyle.Flat;
            btnIncribirse.FlatAppearance.BorderSize = 0;
            btnIncribirse.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            // BOTÓN REGRESAR
            Button btnVolver = new Button
            {
                Text = "CANCELAR Y REGRESAR",
                Location = new Point(100, 340),
                Size = new Size(200, 35),
                FlatStyle = FlatStyle.Flat
            };
            btnVolver.Click += (s, ev) => { plan.Close(); };

            btnIncribirse.Click += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Por favor ingrese el nombre del socio.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string seleccion = comboMensualidad.SelectedItem.ToString();
                MessageBox.Show($"¡Inscripción Exitosa!\n\nUsuario: {txtNombre.Text}\nPlan: {seleccion}", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plan.Close();
            };

            plan.Controls.AddRange(new Control[] { label1, label2, txtNombre, label3, txtedad, label4, txtTelefono, label5, comboMensualidad, btnIncribirse, btnVolver });
            plan.ShowDialog();
        }
    }
}