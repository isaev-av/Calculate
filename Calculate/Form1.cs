using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {

        Double result = 0;
        string operation = "";
        bool isOperationPerformed = false;

        private Rectangle textBox;
        private Rectangle buttonRectangle1;
        private Rectangle buttonRectangle2;
        private Rectangle buttonRectangle3;
        private Rectangle buttonRectangle4;
        private Rectangle buttonRectangle5;
        private Rectangle buttonRectangle6;
        private Rectangle buttonRectangle7;
        private Rectangle buttonRectangle8;
        private Rectangle buttonRectangle9;
        private Rectangle buttonRectangle10;
        private Rectangle buttonRectangle11;
        private Rectangle buttonRectangle12;
        private Rectangle buttonRectangle13;
        private Rectangle buttonRectangle14;
        private Rectangle buttonRectangle15;
        private Rectangle buttonRectangle16;
        private Rectangle buttonRectangle17;

        private Size formOriginalSize;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formOriginalSize = Size;

            textBox = new Rectangle(textBox1.Location.X, textBox1.Location.Y, textBox1.Width, textBox1.Height);
            buttonRectangle1 = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            buttonRectangle2 = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
            buttonRectangle3 = new Rectangle(button3.Location.X, button3.Location.Y, button3.Width, button3.Height);
            buttonRectangle4 = new Rectangle(button4.Location.X, button4.Location.Y, button4.Width, button4.Height);
            buttonRectangle5 = new Rectangle(button5.Location.X, button5.Location.Y, button5.Width, button5.Height);
            buttonRectangle6 = new Rectangle(button6.Location.X, button6.Location.Y, button6.Width, button6.Height);
            buttonRectangle7 = new Rectangle(button7.Location.X, button7.Location.Y, button7.Width, button7.Height);
            buttonRectangle8 = new Rectangle(button8.Location.X, button8.Location.Y, button8.Width, button8.Height);
            buttonRectangle9 = new Rectangle(button9.Location.X, button9.Location.Y, button9.Width, button9.Height);
            buttonRectangle10 = new Rectangle(button10.Location.X, button10.Location.Y, button10.Width, button10.Height);
            buttonRectangle11 = new Rectangle(button11.Location.X, button11.Location.Y, button11.Width, button11.Height);
            buttonRectangle12 = new Rectangle(button12.Location.X, button12.Location.Y, button12.Width, button12.Height);
            buttonRectangle13 = new Rectangle(button13.Location.X, button13.Location.Y, button13.Width, button13.Height);
            buttonRectangle14 = new Rectangle(button14.Location.X, button14.Location.Y, button14.Width, button14.Height);
            buttonRectangle15 = new Rectangle(button15.Location.X, button15.Location.Y, button15.Width, button15.Height);
            buttonRectangle16 = new Rectangle(button16.Location.X, button16.Location.Y, button16.Width, button16.Height);
            buttonRectangle17 = new Rectangle(button17.Location.X, button17.Location.Y, button17.Width, button17.Height);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeChildControls();
        }

        private void resizeChildControls()
        {
            resizeControl(textBox, textBox1);
            resizeControl(buttonRectangle1, button1);
            resizeControl(buttonRectangle2, button2);
            resizeControl(buttonRectangle3, button3);
            resizeControl(buttonRectangle4, button4);
            resizeControl(buttonRectangle5, button5);
            resizeControl(buttonRectangle6, button6);
            resizeControl(buttonRectangle7, button7);
            resizeControl(buttonRectangle8, button8);
            resizeControl(buttonRectangle9, button9);
            resizeControl(buttonRectangle10, button10);
            resizeControl(buttonRectangle11, button11);
            resizeControl(buttonRectangle12, button12);
            resizeControl(buttonRectangle13, button13);
            resizeControl(buttonRectangle14, button14);
            resizeControl(buttonRectangle15, button15);
            resizeControl(buttonRectangle16, button16);
            resizeControl(buttonRectangle17, button17);
        }

        private void resizeControl(Rectangle originalControlRect, Control control)
        {
            float xRatio = Width / (float)(formOriginalSize.Width);
            float yRatio = Height / (float)(formOriginalSize.Height);

            int newX = (int)(originalControlRect.X * xRatio);
            int newY = (int)(originalControlRect.Y * yRatio);
            int newWidth = (int)(originalControlRect.Width * xRatio);
            int newHeight = (int)(originalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        private void button17_Operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Double.Parse(textBox1.Text);
            label1.Text = result + " " + operation;
            isOperationPerformed = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ("0".Equals(textBox1.Text) || isOperationPerformed)
            {
                textBox1.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (!(".".Equals(button.Text) && textBox1.Text.Contains(".")))
            {
                textBox1.Text += button.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
            result = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    throw new NotImplementedException("Unknown operation!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}