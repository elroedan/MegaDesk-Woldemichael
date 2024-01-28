namespace MegaDesk_Woldemichael
{
    partial class AddQuote
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
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.TextBox();
            this.Depth = new System.Windows.Forms.TextBox();
            this.Drawers = new System.Windows.Forms.ComboBox();
            this.DeskMaterial = new System.Windows.Forms.ComboBox();
            this.Rush = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(673, 403);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(115, 35);
            this.Close.TabIndex = 2;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Drawers :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desk Depth :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Desk Width :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Desk Material :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rush Order Selection :";
            // 
            // CustomerName
            // 
            this.CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerName.Location = new System.Drawing.Point(417, 53);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(200, 20);
            this.CustomerName.TabIndex = 9;
            // 
            // Width
            // 
            this.Width.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Width.Location = new System.Drawing.Point(417, 97);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(200, 20);
            this.Width.TabIndex = 10;
            this.Width.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Depth
            // 
            this.Depth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Depth.Location = new System.Drawing.Point(417, 148);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(200, 20);
            this.Depth.TabIndex = 11;
            // 
            // Drawers
            // 
            this.Drawers.FormattingEnabled = true;
            this.Drawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.Drawers.Location = new System.Drawing.Point(417, 201);
            this.Drawers.Name = "Drawers";
            this.Drawers.Size = new System.Drawing.Size(200, 21);
            this.Drawers.TabIndex = 12;
            // 
            // DeskMaterial
            // 
            this.DeskMaterial.FormattingEnabled = true;
            this.DeskMaterial.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "RoseWood",
            "Veneer"});
            this.DeskMaterial.Location = new System.Drawing.Point(417, 255);
            this.DeskMaterial.Name = "DeskMaterial";
            this.DeskMaterial.Size = new System.Drawing.Size(200, 21);
            this.DeskMaterial.TabIndex = 13;
            // 
            // Rush
            // 
            this.Rush.FormattingEnabled = true;
            this.Rush.Items.AddRange(new object[] {
            "3 Day",
            "5 Day",
            "7 Day",
            "No Rush"});
            this.Rush.Location = new System.Drawing.Point(417, 313);
            this.Rush.Name = "Rush";
            this.Rush.Size = new System.Drawing.Size(200, 21);
            this.Rush.TabIndex = 14;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Submit.Location = new System.Drawing.Point(317, 366);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(177, 50);
            this.Submit.TabIndex = 15;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Close;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Rush);
            this.Controls.Add(this.DeskMaterial);
            this.Controls.Add(this.Drawers);
            this.Controls.Add(this.Depth);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.TextBox Depth;
        private System.Windows.Forms.ComboBox Drawers;
        private System.Windows.Forms.ComboBox DeskMaterial;
        private System.Windows.Forms.ComboBox Rush;
        private System.Windows.Forms.Button Submit;
    }
}