namespace TallerDeEventos
{
    partial class ControlTareas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtIngresarTarea = new TextBox();
            BtnAgregarTareas = new Button();
            PnlTareasPorRealizar = new FlowLayoutPanel();
            PnlTareasEnProceso = new FlowLayoutPanel();
            PnlTareasTerminadas = new FlowLayoutPanel();
            LbTareasaRealizar = new Label();
            LbTareaEnProceso = new Label();
            LbTareasTerminadas = new Label();
            SuspendLayout();
            // 
            // TxtIngresarTarea
            // 
            TxtIngresarTarea.BackColor = SystemColors.ActiveCaptionText;
            TxtIngresarTarea.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtIngresarTarea.ForeColor = SystemColors.ButtonHighlight;
            TxtIngresarTarea.Location = new Point(352, 53);
            TxtIngresarTarea.Name = "TxtIngresarTarea";
            TxtIngresarTarea.PlaceholderText = "Ingresar Tareas";
            TxtIngresarTarea.Size = new Size(404, 26);
            TxtIngresarTarea.TabIndex = 0;
            TxtIngresarTarea.TextAlign = HorizontalAlignment.Center;
            TxtIngresarTarea.KeyDown += TxtIngresarTarea_KeyDown;
            // 
            // BtnAgregarTareas
            // 
            BtnAgregarTareas.BackColor = SystemColors.ActiveCaptionText;
            BtnAgregarTareas.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAgregarTareas.ForeColor = SystemColors.ButtonHighlight;
            BtnAgregarTareas.Location = new Point(502, 103);
            BtnAgregarTareas.Name = "BtnAgregarTareas";
            BtnAgregarTareas.Size = new Size(104, 29);
            BtnAgregarTareas.TabIndex = 1;
            BtnAgregarTareas.Text = "Agregar +";
            BtnAgregarTareas.UseVisualStyleBackColor = false;
            BtnAgregarTareas.Click += BtnAgregarTareas_Click;
            // 
            // PnlTareasPorRealizar
            // 
            PnlTareasPorRealizar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PnlTareasPorRealizar.AutoScroll = true;
            PnlTareasPorRealizar.BorderStyle = BorderStyle.Fixed3D;
            PnlTareasPorRealizar.FlowDirection = FlowDirection.TopDown;
            PnlTareasPorRealizar.Location = new Point(153, 215);
            PnlTareasPorRealizar.Name = "PnlTareasPorRealizar";
            PnlTareasPorRealizar.Size = new Size(211, 311);
            PnlTareasPorRealizar.TabIndex = 2;
            PnlTareasPorRealizar.Click += BtnEliminarTarea_Click;
            // 
            // PnlTareasEnProceso
            // 
            PnlTareasEnProceso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PnlTareasEnProceso.AutoScroll = true;
            PnlTareasEnProceso.BorderStyle = BorderStyle.Fixed3D;
            PnlTareasEnProceso.FlowDirection = FlowDirection.TopDown;
            PnlTareasEnProceso.Location = new Point(446, 215);
            PnlTareasEnProceso.Name = "PnlTareasEnProceso";
            PnlTareasEnProceso.Size = new Size(216, 311);
            PnlTareasEnProceso.TabIndex = 3;
            PnlTareasEnProceso.Click += BtnEliminarTarea_Click;
            // 
            // PnlTareasTerminadas
            // 
            PnlTareasTerminadas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PnlTareasTerminadas.AutoScroll = true;
            PnlTareasTerminadas.BorderStyle = BorderStyle.Fixed3D;
            PnlTareasTerminadas.FlowDirection = FlowDirection.TopDown;
            PnlTareasTerminadas.Location = new Point(744, 215);
            PnlTareasTerminadas.Name = "PnlTareasTerminadas";
            PnlTareasTerminadas.Size = new Size(216, 311);
            PnlTareasTerminadas.TabIndex = 4;
            PnlTareasTerminadas.Click += BtnEliminarTarea_Click;
            // 
            // LbTareasaRealizar
            // 
            LbTareasaRealizar.AutoSize = true;
            LbTareasaRealizar.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbTareasaRealizar.ForeColor = SystemColors.ButtonHighlight;
            LbTareasaRealizar.Location = new Point(171, 175);
            LbTareasaRealizar.Name = "LbTareasaRealizar";
            LbTareasaRealizar.Size = new Size(168, 18);
            LbTareasaRealizar.TabIndex = 5;
            LbTareasaRealizar.Text = "Tareas Por Realizar";
            // 
            // LbTareaEnProceso
            // 
            LbTareaEnProceso.AutoSize = true;
            LbTareaEnProceso.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbTareaEnProceso.ForeColor = SystemColors.ButtonHighlight;
            LbTareaEnProceso.Location = new Point(471, 175);
            LbTareaEnProceso.Name = "LbTareaEnProceso";
            LbTareaEnProceso.Size = new Size(167, 18);
            LbTareaEnProceso.TabIndex = 6;
            LbTareaEnProceso.Text = "Tareas En Ejecución";
            // 
            // LbTareasTerminadas
            // 
            LbTareasTerminadas.AutoSize = true;
            LbTareasTerminadas.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbTareasTerminadas.ForeColor = SystemColors.ButtonHighlight;
            LbTareasTerminadas.Location = new Point(774, 175);
            LbTareasTerminadas.Name = "LbTareasTerminadas";
            LbTareasTerminadas.Size = new Size(158, 18);
            LbTareasTerminadas.TabIndex = 7;
            LbTareasTerminadas.Text = "Tareas Terminadas";
            // 
            // ControlTareas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1119, 568);
            Controls.Add(PnlTareasTerminadas);
            Controls.Add(LbTareasTerminadas);
            Controls.Add(LbTareaEnProceso);
            Controls.Add(LbTareasaRealizar);
            Controls.Add(PnlTareasEnProceso);
            Controls.Add(PnlTareasPorRealizar);
            Controls.Add(BtnAgregarTareas);
            Controls.Add(TxtIngresarTarea);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ControlTareas";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtIngresarTarea;
        private Button BtnAgregarTareas;
        private FlowLayoutPanel PnlTareasPorRealizar;
        private FlowLayoutPanel PnlTareasEnProceso;
        private FlowLayoutPanel PnlTareasTerminadas;
        private Label LbTareasaRealizar;
        private Label LbTareaEnProceso;
        private Label LbTareasTerminadas;
    }
}
