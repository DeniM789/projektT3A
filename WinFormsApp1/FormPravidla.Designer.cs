namespace WinFormsApp1
{
    partial class FormPravidla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPravidla));
            btnZpet = new Button();
            lblPravidla = new Label();
            SuspendLayout();
            // 
            // btnZpet
            // 
            btnZpet.BackColor = Color.DarkSlateGray;
            btnZpet.Font = new Font("Castellar", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZpet.ForeColor = SystemColors.ControlLightLight;
            btnZpet.Location = new Point(314, 298);
            btnZpet.Name = "btnZpet";
            btnZpet.Size = new Size(152, 56);
            btnZpet.TabIndex = 1;
            btnZpet.Text = "Menu";
            btnZpet.UseVisualStyleBackColor = false;
            btnZpet.Click += btnZpet_Click;
            // 
            // lblPravidla
            // 
            lblPravidla.AutoSize = true;
            lblPravidla.BackColor = Color.DarkSlateGray;
            lblPravidla.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPravidla.ForeColor = SystemColors.ControlLightLight;
            lblPravidla.Location = new Point(139, 62);
            lblPravidla.Name = "lblPravidla";
            lblPravidla.Size = new Size(106, 29);
            lblPravidla.TabIndex = 2;
            lblPravidla.Text = "Pravidla";
            // 
            // FormPravidla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPravidla);
            Controls.Add(btnZpet);
            Name = "FormPravidla";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormPravidla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnZpet;
        private Label lblPravidla;
    }
}