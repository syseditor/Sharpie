using org.matheval;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public string math;
        public string eval;
        public string exportable;
        public string tempHistory;

        public float memo;
        public float tempMemo;
        
        public List<string> history = new List<string>();
        
        public Calculator()
        {
            InitializeComponent();

            // Event Init
            foreach (Control control in this.Controls)
            {
                // Button click
                if (control.GetType() == typeof(Button))
                {
                    control.Click += new EventHandler(this.OnButtonClick);
                }
                // All - key press and down
                control.KeyPress += new KeyPressEventHandler(this.OnKeyPress);
                control.KeyDown += new KeyEventHandler(this.OnKeyDown);
            }

            // No focus
            ActiveControl = focusLabel;
        }

        public void OnButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "one":
                    math += "1";
                    entry.Text += "1";
                    break;
                case "two":
                    math += "2";
                    entry.Text += "2";
                    break;
                case "three":
                    math += "3";
                    entry.Text += "3";
                    break;
                case "four":
                    math += "4";
                    entry.Text += "4";
                    break;
                case "five":
                    math += "5";
                    entry.Text += "5";
                    break;
                case "six":
                    math += "6";
                    entry.Text += "6";
                    break;
                case "seven":
                    math += "7";
                    entry.Text += "7";
                    break;
                case "eight":
                    math += "8";
                    entry.Text += "8";
                    break;
                case "nine":
                    math += "9";
                    entry.Text += "9";
                    break;
                case "zero":
                    math += "0";
                    entry.Text += "0";
                    break;
                case "sum":
                    math += "+";
                    entry.Text += "+";
                    break;
                case "sub":
                    math += "-";
                    entry.Text += "-";
                    break;
                case "multi":
                    math += "*";
                    entry.Text += "*";
                    break;
                case "div":
                    math += "/";
                    entry.Text += "/";
                    break;
                case "clear":
                    math = "";
                    entry.Text = "";
                    break;
                case "eq":
                    try
                    {
                        tempHistory = math;
                        eval = new Expression(math).Eval().ToString();
                        entry.Text = eval;
                        math = eval;
                        history.Add(tempHistory + " = " + eval);
                    }
                    catch (DivideByZeroException)
                    {
                        entry.Text = "Cannot divide by zero.";
                        math = "";
                        eval = "";
                    }
                    catch
                    {
                        entry.Text = "Invalid operation.";
                        math = "";
                        eval = "";
                    }
                    break;
                case "memadd":
                    try
                    {
                        tempMemo = float.Parse(new Expression(math).Eval().ToString());
                        memo += tempMemo;
                    }
                    catch (DivideByZeroException)
                    {
                        entry.Text = "Cannot divide by zero.";
                        math = "";
                        eval = "";
                    }
                    catch
                    {
                        entry.Text = "Invalid operation.";
                        math = "";
                        eval = "";
                    }
                    break;
                case "memsub":
                    try
                    {
                        tempMemo = float.Parse(new Expression(math).Eval().ToString());
                        memo -= tempMemo;
                    }
                    catch (DivideByZeroException)
                    {
                        entry.Text = "Cannot divide by zero.";
                        math = "";
                        eval = "";
                    }
                    catch
                    {
                        entry.Text = "Invalid operation.";
                        math = "";
                        eval = "";
                    }
                    break;
                case "memrecall":
                    math += memo.ToString();
                    entry.Text += memo.ToString();
                    break;
                case "memclear":
                    memo = 0;
                    break;
                case "showHistory":
                    if (history.Count() == 0)
                    {
                        MessageBox.Show("History is empty.\n\nTry doing some calculations!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        tempHistory = "Here are your most recent calculations:\n\n" + String.Join("\n", history);
                        MessageBox.Show(tempHistory, "History", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "conv":
                    if (Application.OpenForms.OfType<Converters>().Count() == 1)
                    {
                        Application.OpenForms.OfType<Converters>().First().Close();
                        break;
                    }
                    Converters convWindow = new Converters();
                    convWindow.Show();
                    break;
                case "help":
                    if (Application.OpenForms.OfType<Help>().Count() == 1)
                    {
                        Application.OpenForms.OfType<Help>().First().Close();
                        break;
                    }
                    Help helpWindow = new Help();
                    helpWindow.Show();
                    break;
                case "export":
                    if (history.Count() == 0)
                    {
                        MessageBox.Show("You have nothing to export.\n\nTry doing some calculations!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        exportable = String.Join("\n", history);
                        exportDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
                        if (exportDialog.ShowDialog() == DialogResult.OK)
                        {
                            FileStream file = (FileStream)exportDialog.OpenFile();
                            StreamWriter writer = new StreamWriter(file);
                            writer.Write(exportable);
                            writer.Flush();
                            writer.Close();
                        }
                    }
                    break;
                case "backspace":
                    if (math != null && entry.Text != null && math.Length != 0 && entry.Text.Length != 0)
                    {
                        math = math.Remove(math.Length - 1, 1);
                        entry.Text = entry.Text.Remove(entry.Text.Length - 1, 1);
                    }
                    break;
                case "dot":
                    math += ".";
                    entry.Text += ".";
                    break;
            }
        }

        //Keyboard
        public void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                    math += "1";
                    entry.Text += "1";
                    ActiveControl = one;
                    break;
                case '2':
                    math += "2";
                    entry.Text += "2";
                    ActiveControl = two;
                    break;
                case '3':
                    math += "3";
                    entry.Text += "3";
                    ActiveControl = three;
                    break;
                case '4':
                    math += "4";
                    entry.Text += "4";
                    ActiveControl = four;
                    break;
                case '5':
                    math += "5";
                    entry.Text += "5";
                    ActiveControl = five;
                    break;
                case '6':
                    math += "6";
                    entry.Text += "6";
                    ActiveControl = six;
                    break;
                case '7':
                    math += "7";
                    entry.Text += "7";
                    ActiveControl = seven;
                    break;
                case '8':
                    math += "8";
                    entry.Text += "8";
                    ActiveControl = eight;
                    break;
                case '9':
                    math += "9";
                    entry.Text += "9";
                    ActiveControl = nine;
                    break;
                case '0':
                    math += "0";
                    entry.Text += "0";
                    ActiveControl = zero;
                    break;
                case '+':
                    math += "+";
                    entry.Text += "+";
                    ActiveControl = sum;
                    break;
                case '-':
                    math += "-";
                    entry.Text += "-";
                    ActiveControl = sub;
                    break;
                case '*':
                    math += "*";
                    entry.Text += "*";
                    ActiveControl = multi;
                    break;
                case '/':
                    math += "/";
                    entry.Text += "/";
                    ActiveControl = div;
                    break;
                case 'c':
                case 'C':
                    math = "";
                    entry.Text = "";
                    ActiveControl = clear;
                    break;
                case 'm':
                case 'M':
                    math += memo.ToString();
                    entry.Text += memo.ToString();
                    ActiveControl = memrecall;
                    break;
                case 'd':
                case 'D':
                    memo = 0;
                    ActiveControl = memclear;
                    break;
                case 'a':
                case 'A':
                    try
                    {
                        tempMemo = float.Parse(new Expression(math).Eval().ToString());
                        memo += tempMemo;
                    }
                    catch (DivideByZeroException)
                    {
                        entry.Text = "Cannot divide by zero.";
                        math = "";
                        eval = "";
                    }
                    catch
                    {
                        entry.Text = "Invalid operation.";
                        math = "";
                        eval = "";
                    }
                    finally
                    {
                        ActiveControl = memadd;
                    }
                    break;
                case 's':
                case 'S':
                    try
                    {
                        tempMemo = float.Parse(new Expression(math).Eval().ToString());
                        memo -= tempMemo;
                    }
                    catch (DivideByZeroException)
                    {
                        entry.Text = "Cannot divide by zero.";
                        math = "";
                        eval = "";
                    }
                    catch
                    {
                        entry.Text = "Invalid operation.";
                        math = "";
                        eval = "";
                    }
                    finally
                    {
                        ActiveControl = memsub;
                    }
                    break;
                case '.':
                    math += ".";
                    entry.Text += ".";
                    ActiveControl = dot;
                    break;
            }
        }

        public void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Back:
                    if (math != null && entry.Text != null && math.Length != 0 && entry.Text.Length != 0)
                    {
                        math = math.Remove(math.Length - 1, 1);
                        entry.Text = entry.Text.Remove(entry.Text.Length - 1, 1);
                    }
                    ActiveControl = backspace;
                    break;
                case Keys.Space:
                    try
                    {
                        tempHistory = math;
                        eval = new Expression(math).Eval().ToString();
                        entry.Text = eval;
                        math = eval;
                        history.Add(tempHistory + " = " + eval);
                    }
                    catch (DivideByZeroException)
                    {
                        entry.Text = "Cannot divide by zero.";
                        math = "";
                        eval = "";
                    }
                    catch
                    {
                        entry.Text = "Invalid operation.";
                        math = "";
                        eval = "";
                    }
                    finally
                    {
                        ActiveControl = eq;
                    }
                    break;
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    break;
            }
        }
    }
}