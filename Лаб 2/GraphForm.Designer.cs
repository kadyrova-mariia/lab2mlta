namespace Лаб_2
{
    partial class GraphForm
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
            this.cbGraphType = new System.Windows.Forms.ComboBox();
            this.cbTraversalMethod = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnTraverse = new System.Windows.Forms.Button();
            this.gbManipulation = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.gbShow = new System.Windows.Forms.GroupBox();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVertice = new System.Windows.Forms.ComboBox();
            this.gbManipulation.SuspendLayout();
            this.gbShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGraphType
            // 
            this.cbGraphType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGraphType.FormattingEnabled = true;
            this.cbGraphType.Items.AddRange(new object[] {
            "Неорієнтований",
            "Орієнтований"});
            this.cbGraphType.Location = new System.Drawing.Point(6, 39);
            this.cbGraphType.Name = "cbGraphType";
            this.cbGraphType.Size = new System.Drawing.Size(121, 24);
            this.cbGraphType.TabIndex = 0;
            // 
            // cbTraversalMethod
            // 
            this.cbTraversalMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTraversalMethod.FormattingEnabled = true;
            this.cbTraversalMethod.Items.AddRange(new object[] {
            "В глибину",
            "В ширину"});
            this.cbTraversalMethod.Location = new System.Drawing.Point(6, 174);
            this.cbTraversalMethod.Name = "cbTraversalMethod";
            this.cbTraversalMethod.Size = new System.Drawing.Size(121, 24);
            this.cbTraversalMethod.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(6, 69);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnTraverse
            // 
            this.btnTraverse.Location = new System.Drawing.Point(6, 204);
            this.btnTraverse.Name = "btnTraverse";
            this.btnTraverse.Size = new System.Drawing.Size(75, 23);
            this.btnTraverse.TabIndex = 3;
            this.btnTraverse.Text = "Traverse";
            this.btnTraverse.UseVisualStyleBackColor = true;
            this.btnTraverse.Click += new System.EventHandler(this.btnTraverse_Click);
            // 
            // gbManipulation
            // 
            this.gbManipulation.Controls.Add(this.cbVertice);
            this.gbManipulation.Controls.Add(this.label3);
            this.gbManipulation.Controls.Add(this.label2);
            this.gbManipulation.Controls.Add(this.label1);
            this.gbManipulation.Controls.Add(this.cbGraphType);
            this.gbManipulation.Controls.Add(this.btnTraverse);
            this.gbManipulation.Controls.Add(this.cbTraversalMethod);
            this.gbManipulation.Controls.Add(this.btnCreate);
            this.gbManipulation.Location = new System.Drawing.Point(651, 12);
            this.gbManipulation.Name = "gbManipulation";
            this.gbManipulation.Size = new System.Drawing.Size(137, 420);
            this.gbManipulation.TabIndex = 4;
            this.gbManipulation.TabStop = false;
            this.gbManipulation.Text = "Дії";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Метод обходу";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Виберіть тип графа ";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Enabled = false;
            this.textBoxOutput.Location = new System.Drawing.Point(340, 21);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(287, 399);
            this.textBoxOutput.TabIndex = 5;
            // 
            // gbShow
            // 
            this.gbShow.Controls.Add(this.pbResult);
            this.gbShow.Controls.Add(this.textBoxOutput);
            this.gbShow.Location = new System.Drawing.Point(12, 12);
            this.gbShow.Name = "gbShow";
            this.gbShow.Size = new System.Drawing.Size(633, 426);
            this.gbShow.TabIndex = 6;
            this.gbShow.TabStop = false;
            this.gbShow.Text = "Результат";
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(19, 21);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(306, 399);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbResult.TabIndex = 7;
            this.pbResult.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Вершина";
            // 
            // cbVertice
            // 
            this.cbVertice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVertice.FormattingEnabled = true;
            this.cbVertice.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.cbVertice.Location = new System.Drawing.Point(6, 119);
            this.cbVertice.Name = "cbVertice";
            this.cbVertice.Size = new System.Drawing.Size(121, 24);
            this.cbVertice.TabIndex = 11;
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbShow);
            this.Controls.Add(this.gbManipulation);
            this.Name = "GraphForm";
            this.Text = "Form1";
            this.gbManipulation.ResumeLayout(false);
            this.gbManipulation.PerformLayout();
            this.gbShow.ResumeLayout(false);
            this.gbShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGraphType;
        private System.Windows.Forms.ComboBox cbTraversalMethod;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnTraverse;
        private System.Windows.Forms.GroupBox gbManipulation;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.GroupBox gbShow;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVertice;
        private System.Windows.Forms.Label label3;
    }
}

