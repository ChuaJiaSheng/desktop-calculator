using Calculator_222257U.Properties;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_222257U
{
    public partial class MainForm_222257U : Form
    {
        public SoundPlayer clickSound;
        SpeechSynthesizer synthesizer;

        public MainForm_222257U()
        {
            InitializeComponent();
        }
        private void MainForm_222257U_Load(object sender, EventArgs e)
        {
            synthesizer = new SpeechSynthesizer();
        }

        private void lblID_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var attribute = (GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
            Clipboard.SetText(attribute.Value.ToString());
        }

        bool flagOpPressed = false; //flag if operator is press
        bool flagLastOpr = false; //flag if the last input is operator
        bool flagUOpr = false; // flag if the last input is u_opr
        private void numPad_Click(object sender, EventArgs e)
        {
            click();
            Button btn = (Button)sender;
            string num = btn.Text;

            string temp = txtResults.Text;
            string temp2 = txtPrint.Text;

            //clear display if operator is pressed
            if (flagOpPressed == true)
            {
                temp = "";
                flagOpPressed = false;
            }
            switch (num)
            {
                case ".":
                    if (!temp.Contains('.'))
                    {
                        temp += '.';
                        temp2 += '.';
                    }
                    break;
                default:
                    if (temp == "0")
                    {
                        temp = "";
                    }
                    temp += num;
                    temp2 += num;
                    flagLastOpr = false;
                    break;
            }
            txtResults.Text = temp;
            txtPrint.Text = temp2;
            lblID.Focus();


        }
        string opr = "";
        double operand = 0;

        private void operator_Click(object sender, EventArgs e)
        {
            if (flagUOpr == true)
            {
                txtPrint.Text = txtResults.Text;
                flagUOpr = false;
            }
            click();
            operand = Double.Parse(txtResults.Text);

            Button btn = (Button)sender;
            opr = btn.Tag.ToString();
            flagOpPressed = true;
            if (flagLastOpr == false)
            {
                switch (opr)
                {
                    case "Add":
                        txtPrint.Text += " + ";
                        flagLastOpr = true;
                        break;

                    case "Sub":
                        txtPrint.Text += " - ";
                        flagLastOpr = true;
                        break;

                    case "Multi":
                        txtPrint.Text += " x ";
                        flagLastOpr = true;
                        break;

                    case "Divide":
                        txtPrint.Text += " ÷ ";
                        flagLastOpr = true;
                        break;
                    case "Modulus":
                        txtPrint.Text += " % ";
                        flagLastOpr = true;
                        break;
                    default:
                        break;
                }
            }
            lblID.Focus();

        }

        private void u_operatorClick(object sender, EventArgs e)
        {

            click();
            Button btn = (Button)sender;
            string opr = btn.Text.ToString();
            string u_opr = btn.Tag.ToString();
            double value = Double.Parse(txtResults.Text);
            double operand2 = Double.Parse(txtResults.Text);
            double results;
            flagUOpr = true;

            switch (u_opr)
            {
                case "Sqrt":
                    results = Math.Sqrt(value);
                    txtResults.Text = results.ToString().TrimEnd('0').TrimEnd('.');
                    txtPrint.Text = "√" + value;
                    break;
                case "Sqre":
                    results = Math.Pow(value, 2);
                    txtResults.Text = results.ToString().TrimEnd('0').TrimEnd('.');
                    txtPrint.Text = value + "²";
                    break;
                case "Log":
                    results = Math.Log10(value);
                    txtResults.Text = results.ToString().TrimEnd('0').TrimEnd('.');
                    txtPrint.Text = "log(" + value + ")";
                    break;
                case "PowerX":
                    results = Math.Pow(10, value);
                    txtResults.Text = Math.Round(results, 10).ToString();
                    txtPrint.Text = "10ᵡ    (" + value + ")";
                    break;
                case "Ln":
                    results = Math.Log(value);
                    txtResults.Text = results.ToString().TrimEnd('0').TrimEnd('.');
                    txtPrint.Text = "ln(" + value + ")";
                    break;
                case "Expo":
                    results = Math.Exp(value);
                    txtResults.Text = results.ToString().TrimEnd('0').TrimEnd('.');
                    txtPrint.Text = "eˣ(" + value + ")";
                    break;
                case "Divx":
                    results = 1 / value;
                    txtResults.Text = results.ToString().TrimEnd('0').TrimEnd('.');
                    txtPrint.Text = "1/" + value;
                    break;
                case "PlusMinus":
                    results = -1 * value;
                    txtResults.Text = Math.Round(results, 10).ToString(); ;
                    txtPrint.Text = value.ToString();
                    break;
            }
            if (lblRadian.Text == "Radian")
            {
                switch (opr)
                {
                    case "sin":
                        {
                            results = Math.Sin(value);
                            txtResults.Text = Math.Round(results, 10).ToString();
                            txtPrint.Text = "sin(" + value + ")";
                            break;
                        }
                    case "cos":
                        {
                            results = Math.Cos(value);
                            txtResults.Text = Math.Round(results, 10).ToString();
                            txtPrint.Text = "cos(" + value + ")";
                            break;
                        }
                    case "tan":
                        {
                            results = Math.Tan(value);
                            txtResults.Text = Math.Round(results, 10).ToString();
                            txtPrint.Text = "tan(" + value + ")";
                            break;
                        }
                    case "Abs":
                        {
                            results = Math.Abs(value);
                            txtResults.Text = Math.Round(results, 10).ToString();
                            txtPrint.Text = "Abs(" + value + ")";
                            break;
                        }
                    case "Asin":
                        {
                            results = Math.Asin(value);
                            txtResults.Text = Math.Round(results, 10).ToString();
                            txtPrint.Text = "Asin(" + value + ")";
                            break;
                        }
                    case "Acos":
                        {
                            results = Math.Acos(value);
                            txtResults.Text = Math.Round(results, 10).ToString();
                            txtPrint.Text = "Acos(" + value + ")";
                            break;
                        }
                    case "Atan":
                        {
                            results = Math.Atan(value);
                            txtResults.Text = Math.Round(results, 10).ToString();
                            txtPrint.Text = "Atan(" + value + ")";
                            break;
                        }
                    case "Rnd":
                        {
                            results = Math.Round(value);
                            txtResults.Text = Math.Round(results, 10).ToString();
                            txtPrint.Text = "Rnd(" + value + ")";
                            break;
                        }
                }
            }
            else if (lblRadian.Text == "Degree")
            {
                switch (opr)
                {
                    case "sin":
                        {
                            results = Math.Sin(value * Math.PI / 180);
                            txtResults.Text = Math.Round(results, 10).ToString();
                            txtPrint.Text = "sin(" + value + ")";
                            break;
                        }
                    case "cos":
                        {
                            results = Math.Cos(value * Math.PI / 180);
                            txtResults.Text = Math.Round(results, 10).ToString();
                            txtPrint.Text = "cos(" + value + ")";
                            break;
                        }
                    case "tan":
                        {
                            results = Math.Tan(value * Math.PI / 180);
                            txtResults.Text = Math.Round(results, 10).ToString();
                            txtPrint.Text = "tan(" + value + ")";
                            break;
                        }
                    case "Abs":
                        {
                            results = Math.Abs(value) * Math.PI / 180;
                            txtResults.Text = Math.Round(results, 10).ToString();
                            txtPrint.Text = "Abs(" + value + ")";
                            break;
                        }
                    case "Asin":
                        {
                            results = Math.Asin(value) * Math.PI / 180;
                            txtResults.Text = Math.Round(results, 10).ToString();
                            txtPrint.Text = "Asin(" + value + ")";
                            break;
                        }
                    case "Acos":
                        {
                            results = Math.Acos(value) * Math.PI / 180;
                            txtResults.Text = Math.Round(results, 10).ToString();
                            txtPrint.Text = "Acos(" + value + ")";
                            break;
                        }
                    case "Atan":
                        {
                            results = Math.Atan(value) * Math.PI / 180;
                            txtResults.Text = Math.Round(results, 10).ToString();
                            txtPrint.Text = "Atan(" + value + ")";
                            break;
                        }
                    case "Rnd":
                        {
                            results = Math.Round(value);
                            txtResults.Text = Math.Round(results, 10).ToString();
                            txtPrint.Text = "Rnd(" + value + ")";
                            break;
                        }
                }
            }
            lblID.Focus();
            speech();
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            click();
            double value = double.Parse(txtResults.Text);
            Button btn = (Button)sender;
            string mode = btn.Text.ToString();

            switch (mode)
            {
                case "Switch Mode":
                    {
                        if (lblStandard.Text == "Scientific")
                        {
                            lblStandard.Text = "Standard";
                            btnLog.Enabled = false;
                            btnExpo.Enabled = false;
                            btnPlusMinus.Enabled = false;
                            btnPowerx.Enabled = false;
                            btnSqure.Enabled = false;
                            btnSqrt.Enabled = false;
                            btnDivx.Enabled = false;
                            btnln.Enabled = false;
                            btnTrigo.Enabled = false;
                            btnDegree.Enabled = false;
                        }

                        else if (lblStandard.Text == "Standard")
                        {
                            lblStandard.Text = "Scientific";
                            btnLog.Enabled = true;
                            btnLog.Enabled = true;
                            btnExpo.Enabled = true;
                            btnPlusMinus.Enabled = true;
                            btnPowerx.Enabled = true;
                            btnSqure.Enabled = true;
                            btnSqrt.Enabled = true;
                            btnDivx.Enabled = true;
                            btnln.Enabled = true;
                            btnTrigo.Enabled = true;
                            btnDegree.Enabled = true;
                        }
                        break;
                    }
                case "Trigo":
                    {
                        if (lblStandard.Text == "Scientific" && btnLog.Text == "log")
                        {
                            btnLog.Text = "sin";
                            btnPowerx.Text = "cos";
                            btnln.Text = "tan";
                            btnExpo.Text = "Abs";
                            btnPlusMinus.Text = "Asin";
                            btnDivx.Text = "Acos";
                            btnSqure.Text = "Atan";
                            btnSqrt.Text = "Rnd";
                        }
                        else if (lblStandard.Text == "Scientific" && btnLog.Text == "sin")
                        {
                            btnLog.Text = "log";
                            btnPowerx.Text = "10ˣ";
                            btnln.Text = "ln";
                            btnExpo.Text = "eˣ";
                            btnPlusMinus.Text = "±";
                            btnDivx.Text = " ¹⁄𝑥\r\n";
                            btnSqure.Text = "x²";
                            btnSqrt.Text = "√";
                        }
                        break;
                    }
                case "Change Degree":
                    {
                        if (txtResults.Text == "")
                        {
                            txtResults.Text = "0";
                        }
                        else
                        {
                            lblRadian.Text = "Degree";
                            btnDegree.Text = "Change Radian";
                        }
                        break;
                    }

                case "Change Radian":
                    {
                        if (txtResults.Text == "")
                        {
                            txtResults.Text = "0";
                        }
                        else
                        {
                            lblRadian.Text = "Radian";
                            btnDegree.Text = "Change Degree";
                        }
                        break;
                    }
                case "OFF Spk A":
                    {
                        btnSpkA.Text = "ON Spk A";
                        lblSpkA.Text = "Spk A OFF";
                        break;
                    }
                case "ON Spk A":
                    {
                        btnSpkA.Text = "OFF Spk A";
                        lblSpkA.Text = "Spk A ON";
                        break;
                    }
                case "OFF Spk B":
                    {
                        btnSpkB.Text = "ON Spk B";
                        lblSpkB.Text = "Spk B OFF";
                        break;
                    }
                case "ON Spk B":
                    {
                        btnSpkB.Text = "OFF Spk B";
                        lblSpkB.Text = "Spk B ON";
                        break;
                    }
            }
            lblID.Focus();
        }
        private void btnEqn_Click(object sender, EventArgs e)
        {
            click();
            calculation();
            speech();
            lblID.Focus();
            answer = txtResults.Text;
        }

        private void btnDelate_Click(object sender, EventArgs e)
        {

            click();
            if (txtPrint.Text != "")
            {
                string value;
                value = txtPrint.Text.Remove(txtPrint.Text.Length - 1);
                txtPrint.Text = value;
                if (txtPrint.Text == "")
                {
                    txtResults.Text = "0";
                }
            }
            lblID.Focus();
        }

        private void btnC_Click(object sender, EventArgs e)
        {

            click();
            opr = "";
            operand = 0;
            flagOpPressed = false;
            txtResults.Text = "0";
            txtPrint.Text = "";
            lblID.Focus();
        }
        private void btnCE_Click(object sender, EventArgs e)
        {

            click();
            string removePrint;

            for (int i = txtPrint.Text.Length - 1; i >= 0; --i)
            {
                char c = txtPrint.Text[i];
                removePrint = txtPrint.Text.Remove(txtPrint.Text.Length - 1);
                txtPrint.Text = removePrint;
                txtResults.Text = "0";

                if (c == '+' || c == '-' || c == 'x' || c == '÷' || c == '%')
                {
                    break;
                }
            }
            lblID.Focus();
        }


        private void btnCopy_Click(object sender, EventArgs e)
        {

            click();
            Clipboard.SetText(txtPrint.Text + " = " + txtResults.Text);
        }

        string answer;
        private void btnAns_Click(object sender, EventArgs e)
        {
            click();
            if (txtResults.Text == "0")
                txtResults.Text = "";
            txtResults.Text += answer;
        }

        private void click()
        {
            if (lblSpkA.Text == "Spk A ON")
            {
                var click = Resources.Click;
                clickSound = new SoundPlayer(click);
                clickSound.Play();
            }
            lblID.Focus();
        }
        private void speech()
        {
            if (lblSpkB.Text == "Spk B ON")
            {
                synthesizer.Volume = 100;
                synthesizer.Rate = 0;
                synthesizer.Speak("The result" + "is" + txtResults.Text);
            }
            lblID.Focus();
        }
        private void calculation()
        {
            List<string> list_num = new List<string>();
            List<string> list_opr = new List<string>();
            string temp = "";

            for (int i = 0; i < txtPrint.Text.Length; i++)
            {
                char c;
                c = txtPrint.Text[i];
                if (c != '+' && c != '-' && c != 'x' && c != '÷' && c != '%')
                {
                    temp += c.ToString();
                }
                else
                {
                    list_num.Add(temp);
                    list_opr.Add(c.ToString());
                    temp = "";
                }

                if (i == txtPrint.Text.Length - 1)
                {
                    list_num.Add(temp);
                }
            }

            if (flagLastOpr == true)
            {
                int i = list_opr.Count;
                list_opr.Remove(list_opr[i - 1]);
                int j = list_num.Count;
                list_num.Remove(list_num[j - 1]);
            }

            List<double> list_bodmas = list_num.ConvertAll(double.Parse);


            //now all the numbers are now in list_bodmas

            while (list_opr.Count() > 0)
            {

                //inside the main for loop, need another for loop to loop through * / and + - 

                double result;
                for (int j = 0; j < list_opr.Count(); j++)
                {

                    if (list_opr[j] == "x")
                    {
                        result = list_bodmas[j] * list_bodmas[j + 1];
                        list_bodmas.Remove(list_bodmas[j]);
                        list_bodmas.Remove(list_bodmas[j]);
                        list_opr.Remove(list_opr[j]);
                        list_bodmas.Insert(j, result);
                        j = 0;
                    }
                    else if (list_opr[j] == "÷")
                    {
                        result = list_bodmas[j] / list_bodmas[j + 1];
                        list_bodmas.Remove(list_bodmas[j]);
                        list_bodmas.Remove(list_bodmas[j]);
                        list_opr.Remove(list_opr[j]);
                        list_bodmas.Insert(j, result);
                        j = 0;
                    }
                    else if (list_opr[j] == "%")
                    {
                        result = list_bodmas[j] % list_bodmas[j + 1];
                        list_bodmas.Remove(list_bodmas[j]);
                        list_bodmas.Remove(list_bodmas[j]);
                        list_opr.Remove(list_opr[j]);
                        list_bodmas.Insert(j, result);
                        j = 0;
                    }

                }
                for (int j = 0; j < list_opr.Count(); j++)
                {
                    if (list_opr[0] == "-")
                    {
                        result = list_bodmas[0] - list_bodmas[1];
                        list_bodmas.Remove(list_bodmas[0]);
                        list_bodmas.Remove(list_bodmas[0]);
                        list_opr.Remove(list_opr[0]);
                        list_bodmas.Insert(0, result);
                        j = 0;
                    }
                    else if (list_opr[0] == "+")
                    {
                        result = list_bodmas[0] + list_bodmas[1];
                        list_bodmas.Remove(list_bodmas[0]);
                        list_bodmas.Remove(list_bodmas[0]);
                        list_opr.Remove(list_opr[0]);
                        list_bodmas.Insert(0, result);
                        j = 0;
                    }
                }
            }
            //this is when the operator list is empty and will give ans
            txtResults.Text = list_bodmas[0].ToString();
        }


        private void keyPressed_Press(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;
            keyPressed.ToString();

            if (char.IsDigit(keyPressed))
            {
                switch (keyPressed)
                {
                    case '1':
                        btn1.PerformClick();
                        break;
                    case '2':
                        btn2.PerformClick();
                        break;
                    case '3':
                        btn3.PerformClick();
                        break;
                    case '4':
                        btn4.PerformClick();
                        break;
                    case '5':
                        btn5.PerformClick();
                        break;
                    case '6':
                        btn6.PerformClick();
                        break;
                    case '7':
                        btn7.PerformClick();
                        break;
                    case '8':
                        btn8.PerformClick();
                        break;
                    case '9':
                        btn9.PerformClick();
                        break;
                    case '0':
                        btn0.PerformClick();
                        break;
                    default:
                        break;
                }
            }
            else if (keyPressed == '+')
            {
                operator_Click(btnAdd, EventArgs.Empty);
            }
            else if (keyPressed == '-')
            {
                operator_Click(btnSub, EventArgs.Empty);
            }
            else if (keyPressed == '*' || keyPressed == 'x')
            {
                operator_Click(btnMulti, EventArgs.Empty);
            }
            else if (keyPressed == '/')
            {
                operator_Click(btnDivide, EventArgs.Empty);
            }
            else if (keyPressed == '=')
            {
                btnEqn_Click(btnEqn, EventArgs.Empty);
            }
            else if (keyPressed == 'c')
            {
                btnC_Click(btnC, EventArgs.Empty);
            }
            else if (keyPressed == '%')
            {
                operator_Click(btnModulus, EventArgs.Empty);
            }
        }

        private void enterKey_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEqn_Click(btnEqn, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnCE_Click(btnCE, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Tab && e.Modifiers == Keys.Control)
            {
                btnMode_Click(btnMode, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
            {
                btnCopy_Click(btnCopy, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.CapsLock && e.Modifiers == Keys.Control)
            {
                btnMode_Click(btnTrigo, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.ShiftKey && e.Modifiers == Keys.Control)
            {
                btnMode_Click(btnDegree, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.F1 && e.Modifiers == Keys.Control)
            {
                btnMode_Click(btnSpkA, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.F2 && e.Modifiers == Keys.Control)
            {
                btnMode_Click(btnSpkB, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Back)
            {
                btnDelate_Click(btnDelate, EventArgs.Empty);
            }
        }
    }
}

