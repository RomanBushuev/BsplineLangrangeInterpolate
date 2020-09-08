namespace HomeWorkUserInterface
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AllPictures = new System.Windows.Forms.TabControl();
            this.FirstTaskFirst = new System.Windows.Forms.TabPage();
            this.panel1_1 = new System.Windows.Forms.Panel();
            this.FirstTaskSecond = new System.Windows.Forms.TabPage();
            this.panel1_2 = new System.Windows.Forms.Panel();
            this.FirstTaskThird = new System.Windows.Forms.TabPage();
            this.panel1_3 = new System.Windows.Forms.Panel();
            this.SecondTaskFirst = new System.Windows.Forms.TabPage();
            this.panel2_1 = new System.Windows.Forms.Panel();
            this.SecondTaskSecond = new System.Windows.Forms.TabPage();
            this.panel2_FirstDerivative = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3_1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3_2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.OpenFile = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.TextBox();
            this.SaveIntoPDF = new System.Windows.Forms.Button();
            this.SaveToPNG = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.AllPictures.SuspendLayout();
            this.FirstTaskFirst.SuspendLayout();
            this.FirstTaskSecond.SuspendLayout();
            this.FirstTaskThird.SuspendLayout();
            this.SecondTaskFirst.SuspendLayout();
            this.SecondTaskSecond.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.AllPictures, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(790, 493);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AllPictures
            // 
            this.AllPictures.Controls.Add(this.FirstTaskFirst);
            this.AllPictures.Controls.Add(this.FirstTaskSecond);
            this.AllPictures.Controls.Add(this.FirstTaskThird);
            this.AllPictures.Controls.Add(this.SecondTaskFirst);
            this.AllPictures.Controls.Add(this.SecondTaskSecond);
            this.AllPictures.Controls.Add(this.tabPage1);
            this.AllPictures.Controls.Add(this.tabPage2);
            this.AllPictures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllPictures.Location = new System.Drawing.Point(3, 39);
            this.AllPictures.Name = "AllPictures";
            this.AllPictures.SelectedIndex = 0;
            this.AllPictures.Size = new System.Drawing.Size(784, 451);
            this.AllPictures.TabIndex = 0;
            // 
            // FirstTaskFirst
            // 
            this.FirstTaskFirst.Controls.Add(this.panel1_1);
            this.FirstTaskFirst.Location = new System.Drawing.Point(4, 22);
            this.FirstTaskFirst.Name = "FirstTaskFirst";
            this.FirstTaskFirst.Padding = new System.Windows.Forms.Padding(3);
            this.FirstTaskFirst.Size = new System.Drawing.Size(776, 425);
            this.FirstTaskFirst.TabIndex = 0;
            this.FirstTaskFirst.Text = "Лагранж";
            this.FirstTaskFirst.UseVisualStyleBackColor = true;
            // 
            // panel1_1
            // 
            this.panel1_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_1.Location = new System.Drawing.Point(3, 3);
            this.panel1_1.Name = "panel1_1";
            this.panel1_1.Size = new System.Drawing.Size(770, 419);
            this.panel1_1.TabIndex = 0;
            // 
            // FirstTaskSecond
            // 
            this.FirstTaskSecond.Controls.Add(this.panel1_2);
            this.FirstTaskSecond.Location = new System.Drawing.Point(4, 22);
            this.FirstTaskSecond.Name = "FirstTaskSecond";
            this.FirstTaskSecond.Padding = new System.Windows.Forms.Padding(3);
            this.FirstTaskSecond.Size = new System.Drawing.Size(776, 425);
            this.FirstTaskSecond.TabIndex = 1;
            this.FirstTaskSecond.Text = "Лагранж первая производная";
            this.FirstTaskSecond.UseVisualStyleBackColor = true;
            // 
            // panel1_2
            // 
            this.panel1_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_2.Location = new System.Drawing.Point(3, 3);
            this.panel1_2.Name = "panel1_2";
            this.panel1_2.Size = new System.Drawing.Size(770, 419);
            this.panel1_2.TabIndex = 0;
            // 
            // FirstTaskThird
            // 
            this.FirstTaskThird.Controls.Add(this.panel1_3);
            this.FirstTaskThird.Location = new System.Drawing.Point(4, 22);
            this.FirstTaskThird.Name = "FirstTaskThird";
            this.FirstTaskThird.Padding = new System.Windows.Forms.Padding(3);
            this.FirstTaskThird.Size = new System.Drawing.Size(776, 425);
            this.FirstTaskThird.TabIndex = 2;
            this.FirstTaskThird.Text = "Лагранж вторая производная";
            this.FirstTaskThird.UseVisualStyleBackColor = true;
            // 
            // panel1_3
            // 
            this.panel1_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_3.Location = new System.Drawing.Point(3, 3);
            this.panel1_3.Name = "panel1_3";
            this.panel1_3.Size = new System.Drawing.Size(770, 419);
            this.panel1_3.TabIndex = 0;
            // 
            // SecondTaskFirst
            // 
            this.SecondTaskFirst.Controls.Add(this.panel2_1);
            this.SecondTaskFirst.Location = new System.Drawing.Point(4, 22);
            this.SecondTaskFirst.Name = "SecondTaskFirst";
            this.SecondTaskFirst.Padding = new System.Windows.Forms.Padding(3);
            this.SecondTaskFirst.Size = new System.Drawing.Size(776, 425);
            this.SecondTaskFirst.TabIndex = 3;
            this.SecondTaskFirst.Text = "Сплайн первый вариант";
            this.SecondTaskFirst.UseVisualStyleBackColor = true;
            // 
            // panel2_1
            // 
            this.panel2_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2_1.Location = new System.Drawing.Point(3, 3);
            this.panel2_1.Name = "panel2_1";
            this.panel2_1.Size = new System.Drawing.Size(770, 419);
            this.panel2_1.TabIndex = 0;
            // 
            // SecondTaskSecond
            // 
            this.SecondTaskSecond.Controls.Add(this.panel2_FirstDerivative);
            this.SecondTaskSecond.Location = new System.Drawing.Point(4, 22);
            this.SecondTaskSecond.Name = "SecondTaskSecond";
            this.SecondTaskSecond.Padding = new System.Windows.Forms.Padding(3);
            this.SecondTaskSecond.Size = new System.Drawing.Size(776, 425);
            this.SecondTaskSecond.TabIndex = 4;
            this.SecondTaskSecond.Text = "Сплайн производная первый вариант";
            this.SecondTaskSecond.UseVisualStyleBackColor = true;
            // 
            // panel2_FirstDerivative
            // 
            this.panel2_FirstDerivative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2_FirstDerivative.Location = new System.Drawing.Point(3, 3);
            this.panel2_FirstDerivative.Name = "panel2_FirstDerivative";
            this.panel2_FirstDerivative.Size = new System.Drawing.Size(770, 419);
            this.panel2_FirstDerivative.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3_1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 425);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Сплайн второй вариант";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3_1
            // 
            this.panel3_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3_1.Location = new System.Drawing.Point(3, 3);
            this.panel3_1.Name = "panel3_1";
            this.panel3_1.Size = new System.Drawing.Size(770, 419);
            this.panel3_1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3_2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 425);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Сплайн производная второй вариант";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3_2
            // 
            this.panel3_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3_2.Location = new System.Drawing.Point(3, 3);
            this.panel3_2.Name = "panel3_2";
            this.panel3_2.Size = new System.Drawing.Size(770, 419);
            this.panel3_2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.OpenFile, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.fileName, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.SaveIntoPDF, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.SaveToPNG, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonRun, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxN, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 30);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // OpenFile
            // 
            this.OpenFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenFile.Location = new System.Drawing.Point(3, 3);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(124, 24);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "Открыть файл";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // fileName
            // 
            this.fileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileName.Location = new System.Drawing.Point(393, 3);
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            this.fileName.Size = new System.Drawing.Size(124, 20);
            this.fileName.TabIndex = 1;
            // 
            // SaveIntoPDF
            // 
            this.SaveIntoPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveIntoPDF.Enabled = false;
            this.SaveIntoPDF.Location = new System.Drawing.Point(263, 3);
            this.SaveIntoPDF.Name = "SaveIntoPDF";
            this.SaveIntoPDF.Size = new System.Drawing.Size(124, 24);
            this.SaveIntoPDF.TabIndex = 2;
            this.SaveIntoPDF.Text = "Сохранить в PDF";
            this.SaveIntoPDF.UseVisualStyleBackColor = true;
            this.SaveIntoPDF.Click += new System.EventHandler(this.SaveIntoPDF_Click);
            // 
            // SaveToPNG
            // 
            this.SaveToPNG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveToPNG.Enabled = false;
            this.SaveToPNG.Location = new System.Drawing.Point(133, 3);
            this.SaveToPNG.Name = "SaveToPNG";
            this.SaveToPNG.Size = new System.Drawing.Size(124, 24);
            this.SaveToPNG.TabIndex = 3;
            this.SaveToPNG.Text = "Сохранить в PNG";
            this.SaveToPNG.UseVisualStyleBackColor = true;
            this.SaveToPNG.Click += new System.EventHandler(this.SaveToPNG_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRun.Location = new System.Drawing.Point(653, 3);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(128, 24);
            this.buttonRun.TabIndex = 4;
            this.buttonRun.Text = "Расчитать N";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxN.Location = new System.Drawing.Point(523, 3);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(124, 20);
            this.textBoxN.TabIndex = 5;
            this.textBoxN.Text = "300";
            this.textBoxN.TextChanged += new System.EventHandler(this.textBoxN_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 493);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Бушуев";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.AllPictures.ResumeLayout(false);
            this.FirstTaskFirst.ResumeLayout(false);
            this.FirstTaskSecond.ResumeLayout(false);
            this.FirstTaskThird.ResumeLayout(false);
            this.SecondTaskFirst.ResumeLayout(false);
            this.SecondTaskSecond.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl AllPictures;
        private System.Windows.Forms.TabPage FirstTaskFirst;
        private System.Windows.Forms.Panel panel1_1;
        private System.Windows.Forms.TabPage FirstTaskSecond;
        private System.Windows.Forms.Panel panel1_2;
        private System.Windows.Forms.TabPage FirstTaskThird;
        private System.Windows.Forms.Panel panel1_3;
        private System.Windows.Forms.TabPage SecondTaskFirst;
        private System.Windows.Forms.Panel panel2_1;
        private System.Windows.Forms.TabPage SecondTaskSecond;
        private System.Windows.Forms.Panel panel2_FirstDerivative;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3_1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button SaveIntoPDF;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button SaveToPNG;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3_2;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TextBox textBoxN;

    }
}

