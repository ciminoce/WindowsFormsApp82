
namespace WindowsFormsApp82
{
    partial class frmFibonacci
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.fibonacciListBox = new System.Windows.Forms.ListBox();
            this.reiniciarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cantidad de términos:";
            // 
            // nNumericUpDown
            // 
            this.nNumericUpDown.Location = new System.Drawing.Point(200, 28);
            this.nNumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nNumericUpDown.Name = "nNumericUpDown";
            this.nNumericUpDown.ReadOnly = true;
            this.nNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.nNumericUpDown.TabIndex = 1;
            this.nNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(40, 78);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(81, 60);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(239, 78);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(81, 60);
            this.cancelarButton.TabIndex = 2;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // fibonacciListBox
            // 
            this.fibonacciListBox.FormattingEnabled = true;
            this.fibonacciListBox.Location = new System.Drawing.Point(40, 196);
            this.fibonacciListBox.Name = "fibonacciListBox";
            this.fibonacciListBox.Size = new System.Drawing.Size(103, 264);
            this.fibonacciListBox.TabIndex = 3;
            // 
            // reiniciarButton
            // 
            this.reiniciarButton.Location = new System.Drawing.Point(40, 466);
            this.reiniciarButton.Name = "reiniciarButton";
            this.reiniciarButton.Size = new System.Drawing.Size(280, 45);
            this.reiniciarButton.TabIndex = 2;
            this.reiniciarButton.Text = "Reiniciar?";
            this.reiniciarButton.UseVisualStyleBackColor = true;
            this.reiniciarButton.Click += new System.EventHandler(this.reiniciarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmFibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 523);
            this.Controls.Add(this.fibonacciListBox);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.reiniciarButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.nNumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "frmFibonacci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nNumericUpDown;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.ListBox fibonacciListBox;
        private System.Windows.Forms.Button reiniciarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

