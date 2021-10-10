
namespace cautrucdulieu
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtChuoi = new System.Windows.Forms.TextBox();
            this.txtinra = new System.Windows.Forms.TextBox();
            this.btn_KetQua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(152, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chuỗi đã cho";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(303, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 23);
            this.textBox2.TabIndex = 4;
            // 
            // txtChuoi
            // 
            this.txtChuoi.Location = new System.Drawing.Point(303, 108);
            this.txtChuoi.Name = "txtChuoi";
            this.txtChuoi.Size = new System.Drawing.Size(199, 23);
            this.txtChuoi.TabIndex = 5;
            this.txtChuoi.TextChanged += new System.EventHandler(this.txtChuoi_TextChanged);
            // 
            // txtinra
            // 
            this.txtinra.Location = new System.Drawing.Point(303, 220);
            this.txtinra.Name = "txtinra";
            this.txtinra.Size = new System.Drawing.Size(199, 23);
            this.txtinra.TabIndex = 6;
            this.txtinra.TextChanged += new System.EventHandler(this.txtinra_TextChanged);
            // 
            // btn_KetQua
            // 
            this.btn_KetQua.Location = new System.Drawing.Point(312, 308);
            this.btn_KetQua.Name = "btn_KetQua";
            this.btn_KetQua.Size = new System.Drawing.Size(111, 34);
            this.btn_KetQua.TabIndex = 3;
            this.btn_KetQua.Text = "Kết Quả";
            this.btn_KetQua.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtChuoi);
            this.Controls.Add(this.txtinra);
            this.Controls.Add(this.btn_KetQua);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtChuoi;
        private System.Windows.Forms.TextBox txtinra;
        private System.Windows.Forms.Button btn_KetQua;
    }
}