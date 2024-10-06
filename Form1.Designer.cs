namespace trafik_light_Project
{
    partial class Form1
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
            this.ctrlTraficLight1 = new trafik_light_Project.ctrlTraficLight();
            this.SuspendLayout();
            // 
            // ctrlTraficLight1
            // 
            this.ctrlTraficLight1.BackColor = System.Drawing.Color.White;
            this.ctrlTraficLight1.CurrentLight = trafik_light_Project.ctrlTraficLight.LightEnum.Green;
            this.ctrlTraficLight1.GreenTime = 6;
            this.ctrlTraficLight1.Location = new System.Drawing.Point(57, 58);
            this.ctrlTraficLight1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctrlTraficLight1.Name = "ctrlTraficLight1";
            this.ctrlTraficLight1.OrangeTime = 5;
            this.ctrlTraficLight1.RedTime = 10;
            this.ctrlTraficLight1.Size = new System.Drawing.Size(140, 223);
            this.ctrlTraficLight1.TabIndex = 0;
            this.ctrlTraficLight1.RedLightOn += new System.EventHandler<trafik_light_Project.ctrlTraficLight.TraficLightEventArgs>(this.ctrlTraficLight1_RedLightOn);
            this.ctrlTraficLight1.OrangeLightOn += new System.EventHandler<trafik_light_Project.ctrlTraficLight.TraficLightEventArgs>(this.ctrlTraficLight1_OrangeLightOn);
            this.ctrlTraficLight1.GreenLightOn += new System.EventHandler<trafik_light_Project.ctrlTraficLight.TraficLightEventArgs>(this.ctrlTraficLight1_GreenLightOn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(417, 479);
            this.Controls.Add(this.ctrlTraficLight1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTraficLight ctrlTraficLight1;
    }
}

