
namespace clrRobotAdmin
{
    partial class Form1
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
            this.btn1 = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(25, 23);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(150, 91);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Leer Config";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(25, 182);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(926, 159);
            this.txtLog.TabIndex = 1;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(226, 25);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(128, 86);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Mostrar carpetas";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(25, 347);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(926, 297);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 16;
            this.ListBox1.Location = new System.Drawing.Point(472, 45);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(226, 68);
            this.ListBox1.TabIndex = 3;
            this.ListBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(342, 22);
            this.textBox2.TabIndex = 5;
            // 
            // btn_Execute
            // 
            this.btn_Execute.Location = new System.Drawing.Point(391, 138);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(81, 31);
            this.btn_Execute.TabIndex = 6;
            this.btn_Execute.Text = "Ejecutar";
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.Click += new System.EventHandler(this.Btn_Execute_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(512, 147);
            this.maskedTextBox1.Mask = "00000000000_00000000000_000_00000_000000000.pdf";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(383, 22);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(901, 138);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(99, 31);
            this.btnRename.TabIndex = 8;
            this.btnRename.Text = "Renombrar";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1012, 671);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btn_Execute);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnRename;
    }
}

