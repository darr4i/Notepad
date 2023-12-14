namespace Notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel = new FlowLayoutPanel();
            menuStrip1 = new MenuStrip();
            fileBtn = new ToolStripMenuItem();
            saveBtn = new ToolStripMenuItem();
            loadBtn = new ToolStripMenuItem();
            findBtn = new Button();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            markBtn = new Button();
            boldBtn = new Button();
            italicBtn = new Button();
            underlineBtn = new Button();
            regularBtn = new Button();
            colorBtn = new Button();
            clearBtn = new Button();
            textField = new RichTextBox();
            colorDialog1 = new ColorDialog();
            panel.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.BurlyWood;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(menuStrip1);
            panel.Controls.Add(findBtn);
            panel.Controls.Add(comboBox1);
            panel.Controls.Add(numericUpDown1);
            panel.Controls.Add(markBtn);
            panel.Controls.Add(boldBtn);
            panel.Controls.Add(italicBtn);
            panel.Controls.Add(underlineBtn);
            panel.Controls.Add(regularBtn);
            panel.Controls.Add(colorBtn);
            panel.Controls.Add(clearBtn);
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(900, 46);
            panel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Beige;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.GripMargin = new Padding(2);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileBtn });
            menuStrip1.Location = new Point(6, 3);
            menuStrip1.Margin = new Padding(6, 3, 3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 0, 0, 0);
            menuStrip1.Size = new Size(239, 36);
            menuStrip1.Stretch = false;
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileBtn
            // 
            fileBtn.DropDownItems.AddRange(new ToolStripItem[] { saveBtn, loadBtn });
            fileBtn.Image = (Image)resources.GetObject("fileBtn.Image");
            fileBtn.ImageScaling = ToolStripItemImageScaling.None;
            fileBtn.Name = "fileBtn";
            fileBtn.Padding = new Padding(0);
            fileBtn.Size = new Size(81, 36);
            fileBtn.Text = "Файл";
            fileBtn.ToolTipText = "Файл";
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Cornsilk;
            saveBtn.Image = (Image)resources.GetObject("saveBtn.Image");
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(182, 26);
            saveBtn.Text = "Зберегти";
            saveBtn.ToolTipText = "Зберегти";
            saveBtn.Click += saveBtn_Click;
            // 
            // loadBtn
            // 
            loadBtn.BackColor = Color.Cornsilk;
            loadBtn.Image = (Image)resources.GetObject("loadBtn.Image");
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(182, 26);
            loadBtn.Text = "Завантажити";
            loadBtn.ToolTipText = "Завантажити";
            loadBtn.Click += loadBtn_Click;
            // 
            // findBtn
            // 
            findBtn.Anchor = AnchorStyles.None;
            findBtn.BackColor = Color.Cornsilk;
            findBtn.FlatAppearance.BorderSize = 0;
            findBtn.FlatStyle = FlatStyle.Flat;
            findBtn.Image = (Image)resources.GetObject("findBtn.Image");
            findBtn.Location = new Point(251, 3);
            findBtn.Name = "findBtn";
            findBtn.Size = new Size(36, 36);
            findBtn.TabIndex = 9;
            findBtn.UseVisualStyleBackColor = false;
            findBtn.Click += findBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.BackColor = Color.Beige;
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Location = new Point(293, 7);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(265, 27);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Calibri";
            comboBox1.DrawItem += comboBox1_DrawItem;
            comboBox1.SelectedValueChanged += FontAtributesChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.None;
            numericUpDown1.BackColor = Color.Beige;
            numericUpDown1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(564, 8);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(62, 26);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 9, 0, 0, 0 });
            numericUpDown1.ValueChanged += FontAtributesChanged;
            // 
            // markBtn
            // 
            markBtn.Anchor = AnchorStyles.None;
            markBtn.BackColor = Color.Beige;
            markBtn.FlatAppearance.BorderSize = 0;
            markBtn.FlatStyle = FlatStyle.Flat;
            markBtn.Image = (Image)resources.GetObject("markBtn.Image");
            markBtn.Location = new Point(632, 3);
            markBtn.Name = "markBtn";
            markBtn.Size = new Size(36, 36);
            markBtn.TabIndex = 10;
            markBtn.UseVisualStyleBackColor = false;
            markBtn.Click += styleBtns_Click;
            // 
            // boldBtn
            // 
            boldBtn.Anchor = AnchorStyles.None;
            boldBtn.BackColor = Color.Beige;
            boldBtn.FlatAppearance.BorderSize = 0;
            boldBtn.FlatStyle = FlatStyle.Flat;
            boldBtn.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            boldBtn.Location = new Point(674, 3);
            boldBtn.Name = "boldBtn";
            boldBtn.Size = new Size(36, 36);
            boldBtn.TabIndex = 4;
            boldBtn.Text = "B";
            boldBtn.UseVisualStyleBackColor = false;
            boldBtn.Click += styleBtns_Click;
            // 
            // italicBtn
            // 
            italicBtn.Anchor = AnchorStyles.None;
            italicBtn.BackColor = Color.Beige;
            italicBtn.FlatAppearance.BorderSize = 0;
            italicBtn.FlatStyle = FlatStyle.Flat;
            italicBtn.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            italicBtn.Location = new Point(716, 3);
            italicBtn.Name = "italicBtn";
            italicBtn.Size = new Size(36, 36);
            italicBtn.TabIndex = 5;
            italicBtn.Text = "I";
            italicBtn.UseVisualStyleBackColor = false;
            italicBtn.Click += styleBtns_Click;
            // 
            // underlineBtn
            // 
            underlineBtn.Anchor = AnchorStyles.None;
            underlineBtn.BackColor = Color.Beige;
            underlineBtn.FlatAppearance.BorderSize = 0;
            underlineBtn.FlatStyle = FlatStyle.Flat;
            underlineBtn.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            underlineBtn.Location = new Point(758, 3);
            underlineBtn.Name = "underlineBtn";
            underlineBtn.Size = new Size(36, 36);
            underlineBtn.TabIndex = 6;
            underlineBtn.Text = "U";
            underlineBtn.UseVisualStyleBackColor = false;
            underlineBtn.Click += styleBtns_Click;
            // 
            // regularBtn
            // 
            regularBtn.Anchor = AnchorStyles.None;
            regularBtn.BackColor = Color.Beige;
            regularBtn.FlatAppearance.BorderSize = 0;
            regularBtn.FlatStyle = FlatStyle.Flat;
            regularBtn.Location = new Point(800, 3);
            regularBtn.Name = "regularBtn";
            regularBtn.Size = new Size(36, 36);
            regularBtn.TabIndex = 7;
            regularBtn.Text = "R";
            regularBtn.UseVisualStyleBackColor = false;
            regularBtn.Click += styleBtns_Click;
            // 
            // colorBtn
            // 
            colorBtn.Anchor = AnchorStyles.None;
            colorBtn.BackColor = Color.Beige;
            colorBtn.FlatAppearance.BorderSize = 0;
            colorBtn.FlatStyle = FlatStyle.Flat;
            colorBtn.Image = (Image)resources.GetObject("colorBtn.Image");
            colorBtn.Location = new Point(842, 3);
            colorBtn.Name = "colorBtn";
            colorBtn.Size = new Size(36, 36);
            colorBtn.TabIndex = 12;
            colorBtn.UseVisualStyleBackColor = false;
            colorBtn.Click += colorBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.None;
            clearBtn.BackColor = Color.Beige;
            clearBtn.FlatAppearance.BorderSize = 0;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Image = (Image)resources.GetObject("clearBtn.Image");
            clearBtn.Location = new Point(3, 45);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(36, 36);
            clearBtn.TabIndex = 11;
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += styleBtns_Click;
            // 
            // textField
            // 
            textField.AcceptsTab = true;
            textField.BackColor = Color.Beige;
            textField.BorderStyle = BorderStyle.FixedSingle;
            textField.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textField.Location = new Point(0, 46);
            textField.Name = "textField";
            textField.Size = new Size(900, 409);
            textField.TabIndex = 1;
            textField.Text = "";
            textField.FontChanged += textField_SomethingChanged;
            textField.TextChanged += textField_SomethingChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(900, 450);
            Controls.Add(textField);
            Controls.Add(panel);
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "ImLewel Notebook";
            FormClosing += Form1_FormClosing;
            Resize += Form1_Resize;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel;
    internal RichTextBox textField;
    private ComboBox comboBox1;
    private NumericUpDown numericUpDown1;
    private Button boldBtn;
    private Button italicBtn;
    private Button underlineBtn;
    private Button regularBtn;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileBtn;
    private ToolStripMenuItem saveBtn;
    private ToolStripMenuItem loadBtn;
    private Button findBtn;
    private Button markBtn;
    private Button clearBtn;
    private Button colorBtn;
    private ColorDialog colorDialog1;
  }
}