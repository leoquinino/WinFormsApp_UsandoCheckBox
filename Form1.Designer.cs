
namespace WinFormsApp_UsandoCheckBox
{
    partial class Form1
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
            this.btLinguasSelecionados = new System.Windows.Forms.Button();
            this.ckPython = new System.Windows.Forms.CheckBox();
            this.ckPhp = new System.Windows.Forms.CheckBox();
            this.ckDelphi = new System.Windows.Forms.CheckBox();
            this.ckCSharp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btLinguasSelecionados
            // 
            this.btLinguasSelecionados.Location = new System.Drawing.Point(268, 78);
            this.btLinguasSelecionados.Name = "btLinguasSelecionados";
            this.btLinguasSelecionados.Size = new System.Drawing.Size(175, 23);
            this.btLinguasSelecionados.TabIndex = 0;
            this.btLinguasSelecionados.Text = "Quais Linguas Selecionadas ?";
            this.btLinguasSelecionados.UseVisualStyleBackColor = true;
            this.btLinguasSelecionados.Click += new System.EventHandler(this.btLinguasSelecionados_Click);
            // 
            // ckPython
            // 
            this.ckPython.AutoSize = true;
            this.ckPython.Location = new System.Drawing.Point(42, 42);
            this.ckPython.Name = "ckPython";
            this.ckPython.Size = new System.Drawing.Size(64, 19);
            this.ckPython.TabIndex = 1;
            this.ckPython.Text = "Python";
            this.ckPython.UseVisualStyleBackColor = true;
            // 
            // ckPhp
            // 
            this.ckPhp.AutoSize = true;
            this.ckPhp.Location = new System.Drawing.Point(42, 78);
            this.ckPhp.Name = "ckPhp";
            this.ckPhp.Size = new System.Drawing.Size(47, 19);
            this.ckPhp.TabIndex = 2;
            this.ckPhp.Text = "Php";
            this.ckPhp.UseVisualStyleBackColor = true;
            // 
            // ckDelphi
            // 
            this.ckDelphi.AutoSize = true;
            this.ckDelphi.Location = new System.Drawing.Point(42, 121);
            this.ckDelphi.Name = "ckDelphi";
            this.ckDelphi.Size = new System.Drawing.Size(60, 19);
            this.ckDelphi.TabIndex = 3;
            this.ckDelphi.Text = "Delphi";
            this.ckDelphi.UseVisualStyleBackColor = true;
            // 
            // ckCSharp
            // 
            this.ckCSharp.AutoSize = true;
            this.ckCSharp.Location = new System.Drawing.Point(42, 160);
            this.ckCSharp.Name = "ckCSharp";
            this.ckCSharp.Size = new System.Drawing.Size(41, 19);
            this.ckCSharp.TabIndex = 4;
            this.ckCSharp.Text = "C#";
            this.ckCSharp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.ckCSharp);
            this.Controls.Add(this.ckDelphi);
            this.Controls.Add(this.ckPhp);
            this.Controls.Add(this.ckPython);
            this.Controls.Add(this.btLinguasSelecionados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLinguasSelecionados;
        private System.Windows.Forms.CheckBox ckPython;
        private System.Windows.Forms.CheckBox ckPhp;
        private System.Windows.Forms.CheckBox ckDelphi;
        private System.Windows.Forms.CheckBox ckCSharp;
    }
}

