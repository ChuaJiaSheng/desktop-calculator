namespace Calculator_222257U
{
    partial class MainForm_222257U
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_222257U));
            this.lblID = new System.Windows.Forms.Label();
            this.txtPrint = new System.Windows.Forms.TextBox();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnModulus = new System.Windows.Forms.Button();
            this.btnDelate = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnSqure = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnEqn = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnln = new System.Windows.Forms.Button();
            this.btnExpo = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.lblStandard = new System.Windows.Forms.Label();
            this.btnMode = new System.Windows.Forms.Button();
            this.btnTrigo = new System.Windows.Forms.Button();
            this.btnDivx = new System.Windows.Forms.Button();
            this.btnDegree = new System.Windows.Forms.Button();
            this.lblRadian = new System.Windows.Forms.Label();
            this.lblSpkA = new System.Windows.Forms.Label();
            this.btnSpkA = new System.Windows.Forms.Button();
            this.btnSpkB = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblSpkB = new System.Windows.Forms.Label();
            this.btnAns = new System.Windows.Forms.Button();
            this.btnPowerx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(14, 148);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(233, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Done By: Chua Jia Sheng (222257U) Group: E2";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // txtPrint
            // 
            this.txtPrint.AllowDrop = true;
            this.txtPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.txtPrint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.txtPrint.Location = new System.Drawing.Point(17, 52);
            this.txtPrint.Margin = new System.Windows.Forms.Padding(0);
            this.txtPrint.Multiline = true;
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.ReadOnly = true;
            this.txtPrint.Size = new System.Drawing.Size(500, 33);
            this.txtPrint.TabIndex = 99;
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.btnPlusMinus.Enabled = false;
            this.btnPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusMinus.ForeColor = System.Drawing.Color.White;
            this.btnPlusMinus.Location = new System.Drawing.Point(17, 247);
            this.btnPlusMinus.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(80, 80);
            this.btnPlusMinus.TabIndex = 98;
            this.btnPlusMinus.Tag = "PlusMinus";
            this.btnPlusMinus.Text = "±";
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            this.btnPlusMinus.Click += new System.EventHandler(this.u_operatorClick);
            this.btnPlusMinus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.White;
            this.btnC.Location = new System.Drawing.Point(353, 247);
            this.btnC.Margin = new System.Windows.Forms.Padding(2);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(80, 80);
            this.btnC.TabIndex = 97;
            this.btnC.Tag = "C";
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            this.btnC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btnModulus
            // 
            this.btnModulus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.btnModulus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulus.ForeColor = System.Drawing.Color.White;
            this.btnModulus.Location = new System.Drawing.Point(269, 331);
            this.btnModulus.Margin = new System.Windows.Forms.Padding(2);
            this.btnModulus.Name = "btnModulus";
            this.btnModulus.Size = new System.Drawing.Size(80, 80);
            this.btnModulus.TabIndex = 96;
            this.btnModulus.Tag = "Modulus";
            this.btnModulus.Text = "%";
            this.btnModulus.UseVisualStyleBackColor = false;
            this.btnModulus.Click += new System.EventHandler(this.operator_Click);
            this.btnModulus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btnDelate
            // 
            this.btnDelate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.btnDelate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelate.ForeColor = System.Drawing.Color.White;
            this.btnDelate.Location = new System.Drawing.Point(353, 163);
            this.btnDelate.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelate.Name = "btnDelate";
            this.btnDelate.Size = new System.Drawing.Size(80, 80);
            this.btnDelate.TabIndex = 95;
            this.btnDelate.Tag = "Removed1";
            this.btnDelate.Text = "⌫";
            this.btnDelate.UseVisualStyleBackColor = false;
            this.btnDelate.Click += new System.EventHandler(this.btnDelate_Click);
            this.btnDelate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(138)))), ((int)(((byte)(37)))));
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.White;
            this.btnDivide.Location = new System.Drawing.Point(353, 415);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(2);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(80, 80);
            this.btnDivide.TabIndex = 94;
            this.btnDivide.Tag = "Divide";
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.operator_Click);
            this.btnDivide.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(138)))), ((int)(((byte)(37)))));
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.ForeColor = System.Drawing.Color.White;
            this.btnMulti.Location = new System.Drawing.Point(269, 415);
            this.btnMulti.Margin = new System.Windows.Forms.Padding(2);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(80, 80);
            this.btnMulti.TabIndex = 93;
            this.btnMulti.Tag = "Multi";
            this.btnMulti.Text = "x";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.operator_Click);
            this.btnMulti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btnSqure
            // 
            this.btnSqure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.btnSqure.Enabled = false;
            this.btnSqure.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqure.ForeColor = System.Drawing.Color.White;
            this.btnSqure.Location = new System.Drawing.Point(185, 247);
            this.btnSqure.Margin = new System.Windows.Forms.Padding(2);
            this.btnSqure.Name = "btnSqure";
            this.btnSqure.Size = new System.Drawing.Size(80, 80);
            this.btnSqure.TabIndex = 91;
            this.btnSqure.Tag = "Sqre";
            this.btnSqure.Text = "x²";
            this.btnSqure.UseVisualStyleBackColor = false;
            this.btnSqure.Click += new System.EventHandler(this.u_operatorClick);
            this.btnSqure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(138)))), ((int)(((byte)(37)))));
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.Color.White;
            this.btnSub.Location = new System.Drawing.Point(353, 500);
            this.btnSub.Margin = new System.Windows.Forms.Padding(2);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(80, 80);
            this.btnSub.TabIndex = 90;
            this.btnSub.Tag = "Sub";
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.operator_Click);
            this.btnSub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btnEqn
            // 
            this.btnEqn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(138)))), ((int)(((byte)(37)))));
            this.btnEqn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqn.ForeColor = System.Drawing.Color.White;
            this.btnEqn.Location = new System.Drawing.Point(269, 584);
            this.btnEqn.Margin = new System.Windows.Forms.Padding(2);
            this.btnEqn.Name = "btnEqn";
            this.btnEqn.Size = new System.Drawing.Size(164, 80);
            this.btnEqn.TabIndex = 89;
            this.btnEqn.Tag = "Eqn";
            this.btnEqn.Text = "=";
            this.btnEqn.UseVisualStyleBackColor = false;
            this.btnEqn.Click += new System.EventHandler(this.btnEqn_Click);
            this.btnEqn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterKey_Down);
            this.btnEqn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.btnSqrt.Enabled = false;
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.ForeColor = System.Drawing.Color.White;
            this.btnSqrt.Location = new System.Drawing.Point(269, 247);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(2);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(80, 80);
            this.btnSqrt.TabIndex = 88;
            this.btnSqrt.Tag = "Sqrt";
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.u_operatorClick);
            this.btnSqrt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(138)))), ((int)(((byte)(37)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(269, 500);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 80);
            this.btnAdd.TabIndex = 87;
            this.btnAdd.Tag = "Add";
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.operator_Click);
            this.btnAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.Color.White;
            this.btnCE.Location = new System.Drawing.Point(353, 331);
            this.btnCE.Margin = new System.Windows.Forms.Padding(2);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(80, 80);
            this.btnCE.TabIndex = 86;
            this.btnCE.Tag = "CE";
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            this.btnCE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.Color.White;
            this.btnDot.Location = new System.Drawing.Point(101, 583);
            this.btnDot.Margin = new System.Windows.Forms.Padding(2);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(80, 80);
            this.btnDot.TabIndex = 85;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.numPad_Click);
            this.btnDot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(17, 583);
            this.btn0.Margin = new System.Windows.Forms.Padding(2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(80, 80);
            this.btn0.TabIndex = 84;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.numPad_Click);
            this.btn0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(185, 499);
            this.btn3.Margin = new System.Windows.Forms.Padding(2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 80);
            this.btn3.TabIndex = 83;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.numPad_Click);
            this.btn3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(101, 499);
            this.btn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 80);
            this.btn2.TabIndex = 82;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.numPad_Click);
            this.btn2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(17, 499);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 80);
            this.btn1.TabIndex = 81;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.numPad_Click);
            this.btn1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(185, 415);
            this.btn6.Margin = new System.Windows.Forms.Padding(2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 80);
            this.btn6.TabIndex = 80;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.numPad_Click);
            this.btn6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(101, 415);
            this.btn5.Margin = new System.Windows.Forms.Padding(2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 80);
            this.btn5.TabIndex = 79;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.numPad_Click);
            this.btn5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(17, 415);
            this.btn4.Margin = new System.Windows.Forms.Padding(2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 80);
            this.btn4.TabIndex = 78;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.numPad_Click);
            this.btn4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(185, 331);
            this.btn9.Margin = new System.Windows.Forms.Padding(2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(80, 80);
            this.btn9.TabIndex = 77;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.numPad_Click);
            this.btn9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(101, 331);
            this.btn8.Margin = new System.Windows.Forms.Padding(2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 80);
            this.btn8.TabIndex = 76;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.numPad_Click);
            this.btn8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(17, 331);
            this.btn7.Margin = new System.Windows.Forms.Padding(2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 80);
            this.btn7.TabIndex = 75;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.numPad_Click);
            this.btn7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // txtResults
            // 
            this.txtResults.AllowDrop = true;
            this.txtResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.txtResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.txtResults.ForeColor = System.Drawing.Color.White;
            this.txtResults.Location = new System.Drawing.Point(17, 85);
            this.txtResults.Margin = new System.Windows.Forms.Padding(0);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(500, 63);
            this.txtResults.TabIndex = 74;
            this.txtResults.Text = "0";
            this.txtResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnln
            // 
            this.btnln.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.btnln.Enabled = false;
            this.btnln.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnln.ForeColor = System.Drawing.Color.White;
            this.btnln.Location = new System.Drawing.Point(185, 163);
            this.btnln.Margin = new System.Windows.Forms.Padding(2);
            this.btnln.Name = "btnln";
            this.btnln.Size = new System.Drawing.Size(80, 80);
            this.btnln.TabIndex = 105;
            this.btnln.Tag = "Ln";
            this.btnln.Text = "ln";
            this.btnln.UseVisualStyleBackColor = false;
            this.btnln.Click += new System.EventHandler(this.u_operatorClick);
            this.btnln.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btnExpo
            // 
            this.btnExpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.btnExpo.Enabled = false;
            this.btnExpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.btnExpo.ForeColor = System.Drawing.Color.White;
            this.btnExpo.Location = new System.Drawing.Point(269, 163);
            this.btnExpo.Margin = new System.Windows.Forms.Padding(2);
            this.btnExpo.Name = "btnExpo";
            this.btnExpo.Size = new System.Drawing.Size(80, 80);
            this.btnExpo.TabIndex = 104;
            this.btnExpo.Tag = "Expo";
            this.btnExpo.Text = "eˣ";
            this.btnExpo.UseVisualStyleBackColor = false;
            this.btnExpo.Click += new System.EventHandler(this.u_operatorClick);
            this.btnExpo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.btnLog.Enabled = false;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(17, 163);
            this.btnLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(80, 80);
            this.btnLog.TabIndex = 102;
            this.btnLog.Tag = "Log";
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.u_operatorClick);
            this.btnLog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // lblStandard
            // 
            this.lblStandard.AutoSize = true;
            this.lblStandard.BackColor = System.Drawing.Color.Transparent;
            this.lblStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandard.ForeColor = System.Drawing.Color.White;
            this.lblStandard.Location = new System.Drawing.Point(13, 5);
            this.lblStandard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblStandard.Size = new System.Drawing.Size(122, 38);
            this.lblStandard.TabIndex = 106;
            this.lblStandard.Text = "Standard";
            // 
            // btnMode
            // 
            this.btnMode.BackColor = System.Drawing.Color.DimGray;
            this.btnMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMode.ForeColor = System.Drawing.Color.White;
            this.btnMode.Location = new System.Drawing.Point(437, 163);
            this.btnMode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(80, 80);
            this.btnMode.TabIndex = 107;
            this.btnMode.Text = "Switch Mode";
            this.btnMode.UseVisualStyleBackColor = false;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            this.btnMode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btnTrigo
            // 
            this.btnTrigo.BackColor = System.Drawing.Color.DimGray;
            this.btnTrigo.Enabled = false;
            this.btnTrigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTrigo.ForeColor = System.Drawing.Color.White;
            this.btnTrigo.Location = new System.Drawing.Point(437, 500);
            this.btnTrigo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTrigo.Name = "btnTrigo";
            this.btnTrigo.Size = new System.Drawing.Size(80, 80);
            this.btnTrigo.TabIndex = 108;
            this.btnTrigo.Text = "Trigo";
            this.btnTrigo.UseVisualStyleBackColor = false;
            this.btnTrigo.Click += new System.EventHandler(this.btnMode_Click);
            this.btnTrigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btnDivx
            // 
            this.btnDivx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.btnDivx.Enabled = false;
            this.btnDivx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivx.ForeColor = System.Drawing.Color.White;
            this.btnDivx.Location = new System.Drawing.Point(101, 247);
            this.btnDivx.Margin = new System.Windows.Forms.Padding(2);
            this.btnDivx.Name = "btnDivx";
            this.btnDivx.Size = new System.Drawing.Size(80, 80);
            this.btnDivx.TabIndex = 109;
            this.btnDivx.Tag = "Divx";
            this.btnDivx.Text = " ¹⁄𝑥";
            this.btnDivx.UseVisualStyleBackColor = false;
            this.btnDivx.Click += new System.EventHandler(this.u_operatorClick);
            this.btnDivx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btnDegree
            // 
            this.btnDegree.BackColor = System.Drawing.Color.DimGray;
            this.btnDegree.Enabled = false;
            this.btnDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDegree.ForeColor = System.Drawing.Color.White;
            this.btnDegree.Location = new System.Drawing.Point(437, 583);
            this.btnDegree.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDegree.Name = "btnDegree";
            this.btnDegree.Size = new System.Drawing.Size(80, 80);
            this.btnDegree.TabIndex = 110;
            this.btnDegree.Text = "Change Degree";
            this.btnDegree.UseVisualStyleBackColor = false;
            this.btnDegree.Click += new System.EventHandler(this.btnMode_Click);
            this.btnDegree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // lblRadian
            // 
            this.lblRadian.AutoSize = true;
            this.lblRadian.BackColor = System.Drawing.Color.Transparent;
            this.lblRadian.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadian.ForeColor = System.Drawing.Color.White;
            this.lblRadian.Location = new System.Drawing.Point(214, 5);
            this.lblRadian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRadian.Name = "lblRadian";
            this.lblRadian.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblRadian.Size = new System.Drawing.Size(101, 38);
            this.lblRadian.TabIndex = 111;
            this.lblRadian.Text = "Radian";
            // 
            // lblSpkA
            // 
            this.lblSpkA.AutoSize = true;
            this.lblSpkA.BackColor = System.Drawing.Color.Transparent;
            this.lblSpkA.ForeColor = System.Drawing.Color.White;
            this.lblSpkA.Location = new System.Drawing.Point(460, 8);
            this.lblSpkA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpkA.Name = "lblSpkA";
            this.lblSpkA.Padding = new System.Windows.Forms.Padding(1);
            this.lblSpkA.Size = new System.Drawing.Size(57, 15);
            this.lblSpkA.TabIndex = 112;
            this.lblSpkA.Text = "Spk A ON";
            // 
            // btnSpkA
            // 
            this.btnSpkA.BackColor = System.Drawing.Color.DimGray;
            this.btnSpkA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSpkA.ForeColor = System.Drawing.Color.White;
            this.btnSpkA.Location = new System.Drawing.Point(437, 247);
            this.btnSpkA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSpkA.Name = "btnSpkA";
            this.btnSpkA.Size = new System.Drawing.Size(80, 80);
            this.btnSpkA.TabIndex = 113;
            this.btnSpkA.Text = "OFF Spk A";
            this.btnSpkA.UseVisualStyleBackColor = false;
            this.btnSpkA.Click += new System.EventHandler(this.btnMode_Click);
            this.btnSpkA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btnSpkB
            // 
            this.btnSpkB.BackColor = System.Drawing.Color.DimGray;
            this.btnSpkB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSpkB.ForeColor = System.Drawing.Color.White;
            this.btnSpkB.Location = new System.Drawing.Point(437, 331);
            this.btnSpkB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSpkB.Name = "btnSpkB";
            this.btnSpkB.Size = new System.Drawing.Size(80, 80);
            this.btnSpkB.TabIndex = 114;
            this.btnSpkB.Text = "OFF Spk B";
            this.btnSpkB.UseVisualStyleBackColor = false;
            this.btnSpkB.Click += new System.EventHandler(this.btnMode_Click);
            this.btnSpkB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.DimGray;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Location = new System.Drawing.Point(437, 415);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(80, 80);
            this.btnCopy.TabIndex = 115;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            this.btnCopy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // lblSpkB
            // 
            this.lblSpkB.AutoSize = true;
            this.lblSpkB.BackColor = System.Drawing.Color.Transparent;
            this.lblSpkB.ForeColor = System.Drawing.Color.White;
            this.lblSpkB.Location = new System.Drawing.Point(460, 26);
            this.lblSpkB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpkB.Name = "lblSpkB";
            this.lblSpkB.Padding = new System.Windows.Forms.Padding(1);
            this.lblSpkB.Size = new System.Drawing.Size(57, 15);
            this.lblSpkB.TabIndex = 116;
            this.lblSpkB.Text = "Spk B ON";
            // 
            // btnAns
            // 
            this.btnAns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.btnAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAns.ForeColor = System.Drawing.Color.White;
            this.btnAns.Location = new System.Drawing.Point(185, 583);
            this.btnAns.Margin = new System.Windows.Forms.Padding(2);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(80, 80);
            this.btnAns.TabIndex = 117;
            this.btnAns.Text = "Ans";
            this.btnAns.UseVisualStyleBackColor = false;
            this.btnAns.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // btnPowerx
            // 
            this.btnPowerx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.btnPowerx.Enabled = false;
            this.btnPowerx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.btnPowerx.ForeColor = System.Drawing.Color.White;
            this.btnPowerx.Location = new System.Drawing.Point(101, 163);
            this.btnPowerx.Margin = new System.Windows.Forms.Padding(2);
            this.btnPowerx.Name = "btnPowerx";
            this.btnPowerx.Size = new System.Drawing.Size(80, 80);
            this.btnPowerx.TabIndex = 101;
            this.btnPowerx.Tag = "PowerX";
            this.btnPowerx.Text = "10ˣ";
            this.btnPowerx.UseVisualStyleBackColor = false;
            this.btnPowerx.Click += new System.EventHandler(this.u_operatorClick);
            this.btnPowerx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            // 
            // MainForm_222257U
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(528, 682);
            this.Controls.Add(this.btnAns);
            this.Controls.Add(this.lblSpkB);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnSpkB);
            this.Controls.Add(this.btnSpkA);
            this.Controls.Add(this.lblSpkA);
            this.Controls.Add(this.lblRadian);
            this.Controls.Add(this.btnDegree);
            this.Controls.Add(this.btnDivx);
            this.Controls.Add(this.btnTrigo);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.lblStandard);
            this.Controls.Add(this.btnln);
            this.Controls.Add(this.btnExpo);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnPowerx);
            this.Controls.Add(this.txtPrint);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnModulus);
            this.Controls.Add(this.btnDelate);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSqure);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnEqn);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm_222257U";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.MainForm_222257U_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterKey_Down);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed_Press);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtPrint;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnModulus;
        private System.Windows.Forms.Button btnDelate;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnSqure;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnEqn;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnln;
        private System.Windows.Forms.Button btnExpo;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnPowerx;
        private System.Windows.Forms.Label lblStandard;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Button btnTrigo;
        private System.Windows.Forms.Button btnDivx;
        private System.Windows.Forms.Button btnDegree;
        private System.Windows.Forms.Label lblRadian;
        private System.Windows.Forms.Label lblSpkA;
        private System.Windows.Forms.Button btnSpkA;
        private System.Windows.Forms.Button btnSpkB;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblSpkB;
        private System.Windows.Forms.Button btnAns;
    }
}

